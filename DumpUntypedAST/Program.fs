//////////////////////////////////////////////////////////////////////////////
// 
// DumpUntypedAST - Expandable F# compiler project
//   Author: Kouji Matsui (@kekyo2), bleis-tift (@bleis-tift)
//   GutHub: https://github.com/fscx-projects/
//
// Creative Commons Legal Code
// 
// CC0 1.0 Universal
// 
//   CREATIVE COMMONS CORPORATION IS NOT A LAW FIRM AND DOES NOT PROVIDE
//   LEGAL SERVICES.DISTRIBUTION OF THIS DOCUMENT DOES NOT CREATE AN
//   ATTORNEY-CLIENT RELATIONSHIP.CREATIVE COMMONS PROVIDES THIS
//   INFORMATION ON AN "AS-IS" BASIS.CREATIVE COMMONS MAKES NO WARRANTIES
//   REGARDING THE USE OF THIS DOCUMENT OR THE INFORMATION OR WORKS
//   PROVIDED HEREUNDER, AND DISCLAIMS LIABILITY FOR DAMAGES RESULTING FROM
//   THE USE OF THIS DOCUMENT OR THE INFORMATION OR WORKS PROVIDED
//   HEREUNDER.
//
//////////////////////////////////////////////////////////////////////////////

open System
open System.Collections
open System.Collections.Concurrent
open System.Collections.Generic
open System.IO
open System.Linq
open System.Text

open FSharp.Reflection

open Microsoft.FSharp.Compiler
open Microsoft.FSharp.Compiler.Ast
open Microsoft.FSharp.Compiler.SourceCodeServices

//////////////////////////////////////////////

type Writer(tw: TextWriter) =
  let indents = new ConcurrentDictionary<int, string>()
  let postFixStack = new Stack<string>()
  let mutable currentIndent = ""
  let mutable postFix = ""
  let mutable first = true

  let createIndent count =
    indents.GetOrAdd(count, fun _ ->
      let sb = new StringBuilder()
      Enumerable.Range(0, count) |> Seq.iter(fun _ -> sb.Append(' ') |> ignore)
      sb.ToString())

  member __.AsyncWrite (line: string) = async {
    if first then
      do! tw.WriteAsync("\r\n" + currentIndent + line)
      do first <- false
    else
      do! tw.WriteAsync(postFix + "\r\n" + currentIndent + line)
  }

  member this.AsyncWriteFormat (format: string, [<ParamArray>] args: obj[]) =
    let line = String.Format(format, args)
    this.AsyncWrite line

  member this.AsyncEnter (postFixChar: string) = async {
    do postFixStack.Push postFix
    do postFix <- postFixChar
    do currentIndent <- createIndent (postFixStack.Count * 2)
    do first <- true
  }

  member __.AsyncLeave (closer: string) = async {
    do postFix <- postFixStack.Pop()
    do currentIndent <- createIndent (postFixStack.Count * 2)
    do! tw.WriteAsync(closer)
    do first <- false
  }

let rec getFileNameWithoutExtension path =
  let name = Path.GetFileNameWithoutExtension path
  if name <> path then 
    getFileNameWithoutExtension name
  else 
    name

let toSeq (o: obj) =
  Enumerable.Cast<obj>(o :?> IEnumerable) 

module RefObj =

  let private typeMap (mapper: Type -> 'T option) (o: obj) =
    if o = null then None
    else mapper (o.GetType())

  let (|Primitive|_|) o =
    typeMap (fun t -> if t.IsPrimitive then Some t else None) o

  let private boolType = typeof<bool>
  let private stringType = typeof<string>

  let (|Printable|_|) (o: obj) =
    typeMap (fun t ->
      if t = boolType then Some(t, if o :?> bool then "true" else "false")
      else if t.IsPrimitive then Some(t, o.ToString())
      else if t.IsEnum then Some(t, String.Format("{0}.{1}", t.Name, o))
      else if t = stringType then Some(t, String.Format("\"{0}\"", o))
      else None) o

  let (|Enum|_|) o =
    typeMap (fun t -> if t.IsEnum then Some(t, t.GetEnumUnderlyingType()) else None) o

  let (|Class|_|) o =
    typeMap (fun t -> if t.IsClass then Some t else None) o

  let (|Struct|_|) o =
    typeMap (fun t -> if t.IsValueType then Some t else None) o

  let (|Generic|_|) o =
    typeMap (fun t -> if t.IsGenericType then Some(t, t.GetGenericTypeDefinition(), t.GetGenericArguments()) else None) o

  let (|Array|_|) (o: obj) =
    match o with
    | :? (obj[]) as ar ->
      let t = o.GetType()
      let elementType = t.GetElementType()
      Some(elementType, ar)
    | _ -> None

  let private (|Type|_|) (targ: Type) (t: Type) =
    if targ = t then Some()
    else None

  let private seqs gtd (o: obj) =
    match o with
    | Generic(_, Type(gtd), [| arg0 |]) -> Some(arg0, o :?> IEnumerable |> Seq.cast<obj>)
    | _ -> None

  // TODO: BUG
  let private seqType = typedefof<IEnumerable<obj>>
  let (|Seq|_|) o =
    seqs seqType o

  // TODO: BUG
  let private listType = typedefof<System.Collections.Generic.IList<obj>>
  let (|List|_|) o =
    seqs listType o

  // TODO: BUG
  let private readonlyListType = typedefof<System.Collections.Generic.IReadOnlyList<obj>>
  let (|ReadOnlyList|_|) o =
    seqs readonlyListType o

  let private fsharpListType = typedefof<FSharp.Collections.List<obj>>
  let (|FSharpList|_|) o =
    seqs fsharpListType o

  let (|FSharpTuple|_|) o =
    typeMap (fun t ->
      if FSharpType.IsTuple t then
        Some(Array.zip (FSharpType.GetTupleElements t) (FSharpValue.GetTupleFields o))
      else None) o

  let (|FSharpUnion|_|) o =
    typeMap (fun t ->
      if FSharpType.IsUnion t then
        let unionCase, fields = FSharpValue.GetUnionFields(o, t)
        Some(unionCase, Array.zip (unionCase.GetFields()) (fields))
      else None) o

  let (|FSharpRecord|_|) (o: obj) =
    typeMap (fun t ->
      if FSharpType.IsRecord t then
        Some(Array.zip (FSharpType.GetRecordFields t) (FSharpValue.GetRecordFields o))
      else None) o

module Reflection =
  let (|Array|_|) (t: Type) =
    if t.IsArray then
      Some(t.GetElementType())
    else
      None

  let (|FSharpList|_|) (t: Type) =
    if t.IsGenericType then
      if typedefof<FSharp.Collections.List<obj>>.IsAssignableFrom(t.GetGenericTypeDefinition()) then
        Some(t.GetGenericArguments())
      else
        None
    else
      None

  let (|Tuple|_|) (t: Type) =
    if FSharpType.IsTuple t then
      Some(FSharpType.GetTupleElements t)
    else
      None

let createComment comment =
  if String.IsNullOrWhiteSpace comment then
    ""
  else
    String.Format(" (* {0} *)", comment)

let rec createSafeTypeName (t: Type) =
  let name =
    if t.FullName.StartsWith "Microsoft.FSharp.Core.FSharp" then
      t.FullName.Substring("Microsoft.FSharp.Core.FSharp".Length)
    else
      t.FullName
  let index = name.IndexOf('`')
  let name = if index >= 0 then name.Substring(0, index) else name
  let name =
    if t.IsGenericType then
      let args = String.Join(",", t.GetGenericArguments() |> Seq.map createSafeTypeName)
      String.Format("{0}<{1}>", name, args)
    else name
  name.Split('.').Last().Replace('+', '.')

let rec asyncDumpNode (node: obj) (w: Writer) (comment: string) = async {
  match node with
  | null ->
    do! w.AsyncWrite ("null" + createComment comment)
  | RefObj.Printable(_, value) ->
    do! w.AsyncWriteFormat("{0}{1}", value, createComment comment)
  | RefObj.Struct t ->
    do! w.AsyncWriteFormat("new {0}(){1}", createSafeTypeName t, createComment comment)
  | RefObj.Array(_, values) ->
    do! w.AsyncWriteFormat("[|{0}", createComment comment)
    do! w.AsyncEnter(";")
    for value, index in values |> Seq.mapi (fun i v -> v, i) do
      do! asyncDumpNode value w ("[" + index.ToString() + "]")
    do! w.AsyncLeave("|]")
  | RefObj.FSharpList(_, list) ->
    do! w.AsyncWriteFormat("[{0}", createComment comment)
    do! w.AsyncEnter(";")
    for value, index in list |> Seq.mapi (fun i v -> v, i) do
      do! asyncDumpNode value w ("[" + index.ToString() + "]")
    do! w.AsyncLeave("]")
  | RefObj.FSharpTuple values ->
    do! w.AsyncWriteFormat("({0}", createComment comment)
    do! w.AsyncEnter(",")
    for value, index in values |> Seq.mapi (fun i (v, _) -> v, i) do
      do! asyncDumpNode value w ("[" + index.ToString() + "]")
    do! w.AsyncLeave(")")
  | RefObj.FSharpUnion(unionCase, values) ->
    do! w.AsyncWriteFormat("{0}.{1}({2}", createSafeTypeName unionCase.DeclaringType, unionCase.Name, createComment comment)
    do! w.AsyncEnter(",")
    for field, value in values do
      do! asyncDumpNode value w field.Name
    do! w.AsyncLeave(")")
  | RefObj.FSharpRecord values ->
    do! w.AsyncWriteFormat("{{{0}", createComment comment)
    do! w.AsyncEnter(";")
    for field, value in values do
      do! asyncDumpNode value w field.Name
    do! w.AsyncLeave("}")
  | _ ->
    do! w.AsyncWrite (sprintf "%A%s" node (createComment comment))
}

let asyncDumpComment (text: string) (tw: TextWriter) = async {
  for line in text.Split([|'\n'|]) |> Seq.map (fun line -> line.Replace("\r", "")) do
    let commented = String.Format("// {0}", line)
    do! tw.WriteLineAsync commented
}

let asyncDumpAst (path: string) (tree: ParsedInput) (body: string) = async {
  use fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None)
  let tw = new StreamWriter(fs, Encoding.UTF8)

  let header = String.Format("// AST dumped by DumpUntypedAST [{0:R}]", DateTime.UtcNow)
  do! tw.WriteLineAsync header
  do! tw.WriteLineAsync()
  do! tw.WriteLineAsync "open System"
  do! tw.WriteLineAsync "open Microsoft.FSharp.Compiler"
  do! tw.WriteLineAsync "open Microsoft.FSharp.Compiler.Ast"
  do! tw.WriteLineAsync "open Microsoft.FSharp.Compiler.SourceCodeServices"

  do! tw.WriteLineAsync()
  do! asyncDumpComment body tw

  do! tw.WriteLineAsync()
  let pureDump = sprintf "%A" tree
  do! asyncDumpComment pureDump tw

  do! tw.WriteLineAsync()
  let w = new Writer(tw)
  do! w.AsyncWrite("let ast =")
  do! w.AsyncEnter("")
  do! asyncDumpNode tree w ""
  do! w.AsyncLeave("")
  do! tw.WriteLineAsync()
  do! tw.FlushAsync()
}

//////////////////////////////////////////////

// Load source code
let asyncLoadSourceCode path = async {
  use fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read)
  let tr = new StreamReader(fs, Encoding.UTF8, true)
  return! tr.ReadToEndAsync()
}

// Get untyped tree for a specified input code
let asyncGetUntypedTree path body = async {
  let checker = FSharpChecker.Create()

  // Get compiler options for the 'project' implied by a single script file
  //let! projOptions = checker.GetProjectOptionsFromScript(path, body)
  let projOptions =
   let fp = Path.Combine(Path.GetDirectoryName path, Path.GetFileNameWithoutExtension path)
   checker.GetProjectOptionsFromCommandLineArgs(
    fp + ".fsproj",
    [| "-o:" + fp + ".dll";
       "-g";
       "--debug:full";
       "--noframework";
       "--define:DEBUG";
       "--define:TRACE";
       "--optimize-";
       "--tailcalls-";
       "--platform:anycpu32bitpreferred";
       @"-r:C:\Program Files (x86)\Reference Assemblies\Microsoft\FSharp\.NETFramework\v4.0\4.4.0.0\FSharp.Core.dll";
       @"-r:C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\mscorlib.dll";
       @"-r:C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.Core.dll";
       @"-r:C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.dll";
       @"-r:C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.1\System.Numerics.dll";
       "--target:library";
       "--warn:3";
       "--warnaserror:76";
       "--vserrors";
       "--LCID:1041";
       "--utf8output";
       "--fullpaths";
       "--flaterrors";
       "--subsystemversion:6.00";
       "--highentropyva+";
       path |])

  // Run the first phase (untyped parsing) of the compiler
  let! parseFileResults = checker.ParseFileInProject(path, body, projOptions) 

  return
    match parseFileResults.ParseTree with
    | Some tree -> tree
    | None -> failwith "Something went wrong during parsing!"
}

// Dumper
let asyncDump path = async {
  let! body = asyncLoadSourceCode path
  let! tree = asyncGetUntypedTree path body
  let astPath = Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path) + ".ast.fs")
  do! asyncDumpAst astPath tree body
  return 0
}

// Async main
let asyncMain (argv: string[]) = async {
  let! results = argv |> Seq.map (fun path -> Path.GetFullPath path |> asyncDump) |> Async.Parallel
  return
    match results |> Seq.tryFind (fun result -> result <> 0) with
    | Some result -> result
    | None -> 0
}

// Main
[<EntryPoint>]
let main argv = 
  asyncMain argv |> Async.RunSynchronously
