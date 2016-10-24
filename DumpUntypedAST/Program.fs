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
open System.IO
open System.Text
open System.Xml.Linq

open Microsoft.FSharp.Compiler
open Microsoft.FSharp.Compiler.Ast
open Microsoft.FSharp.Compiler.SourceCodeServices

//////////////////////////////////////////////

let rec getFileNameWithoutExtension path =
  let name = Path.GetFileNameWithoutExtension path
  if name <> path then 
    getFileNameWithoutExtension name
  else 
    name

let asyncDumpAst (path: string) (tree: ParsedInput) = async {
  use fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None)
  let tw = new StreamWriter(fs, Encoding.UTF8)
  let dumpedTree = sprintf "%A" tree
  do! tw.WriteLineAsync dumpedTree
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
  let astPath = Path.Combine(Path.GetDirectoryName(path), Path.GetFileName(path) + ".ast")
  do! asyncDumpAst astPath tree
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
