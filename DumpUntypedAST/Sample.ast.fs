// AST dumped by DumpUntypedAST [Fri, 28 Oct 2016 05:49:37 GMT]

open System
open Microsoft.FSharp.Compiler
open Microsoft.FSharp.Compiler.Ast
open Microsoft.FSharp.Compiler.SourceCodeServices

// open System
// 
// type AspectContext() =
//   member __.Leave(result: 'T) =
//     Console.WriteLine("Result={0}", result)
//     result
//   member __.Caught(ex: exn) =
//     Console.WriteLine("Exception={0}", ex)
// 
// type Aspect() =
//   static member Enter(name: string, line: int, column: int, args: obj[]) =
//     Console.WriteLine("{0}({1},{2}): {3}", name, line, column, String.Join(",", args))
//     new AspectContext()
// 
// let original = 
//   System.String.Format("ABC", 123, 456, 789)
// 
// let filtered =
//   let arg0 = "ABC"
//   let arg1 = 123
//   let arg2 = 456
//   let arg3 = 789
//   let context = Aspect.Enter("Sample.fs", 12, 34, [|arg0;arg1;arg2;arg3|])
//   try
//     context.Leave(System.String.Format(arg0, arg1, arg2, arg3))
//   with
//   | ex ->
//     context.Caught(ex)
//     reraise()
// 

// ImplFile
//   (ParsedImplFileInput
//      ("D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs",false,
//       QualifiedNameOfFile Sample,[],[],
//       [SynModuleOrNamespace
//          ([Sample],false,true,
//           [Open
//              (LongIdentWithDots ([System],[]),
//               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (1,5--1,11) IsSynthetic=false);
//            Types
//              ([TypeDefn
//                  (ComponentInfo
//                     ([],[],[],[AspectContext],
//                      PreXmlDoc
//                        (Microsoft.FSharp.Compiler.Range+pos,
//                         Microsoft.FSharp.Compiler.Ast+XmlDocCollector),false,
//                      null,
//                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (3,5--3,18) IsSynthetic=false),
//                   ObjectModel
//                     (TyconUnspecified,
//                      [ImplicitCtor
//                         (null,[],[],null,
//                          D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (3,5--3,18) IsSynthetic=false);
//                       Member
//                         (Binding
//                            (null,NormalBinding,false,false,[],
//                             PreXmlDoc
//                               (Microsoft.FSharp.Compiler.Range+pos,
//                                Microsoft.FSharp.Compiler.Ast+XmlDocCollector),
//                             SynValData
//                               (Some {IsInstance = true;
//                                      IsDispatchSlot = false;
//                                      IsOverrideOrExplicitImpl = false;
//                                      IsFinal = false;
//                                      MemberKind = Member;},
//                                SynValInfo
//                                  ([[SynArgInfo ([],false,null)];
//                                    [SynArgInfo ([],false,Some result)]],
//                                   SynArgInfo ([],false,null)),null),
//                             LongIdent
//                               (LongIdentWithDots
//                                  ([__; Leave],
//                                   [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,11--4,12) IsSynthetic=false]),
//                                null,null,
//                                Pats
//                                  [Paren
//                                     (Typed
//                                        (Named
//                                           (Wild
//                                              D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,18--4,24) IsSynthetic=false,
//                                            result,false,null,
//                                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,18--4,24) IsSynthetic=false),
//                                         Var
//                                           (Typar (T,NoStaticReq,false),
//                                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,26--4,28) IsSynthetic=false),
//                                         D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,18--4,28) IsSynthetic=false),
//                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,17--4,29) IsSynthetic=false)],
//                                null,
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,9--4,29) IsSynthetic=false),
//                             null,
//                             Sequential
//                               (SequencePointsAtSeq,true,
//                                App
//                                  (Atomic,false,
//                                   LongIdent
//                                     (false,
//                                      LongIdentWithDots
//                                        ([Console; WriteLine],
//                                         [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,11--5,12) IsSynthetic=false]),
//                                      null,
//                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,4--5,21) IsSynthetic=false),
//                                   Paren
//                                     (Tuple
//                                        ([Const
//                                            (String
//                                               ("Result={0}",
//                                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,22--5,34) IsSynthetic=false),
//                                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,22--5,34) IsSynthetic=false);
//                                          Ident result],
//                                         [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,34--5,35) IsSynthetic=false],
//                                         D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,22--5,42) IsSynthetic=false),
//                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,21--5,22) IsSynthetic=false,
//                                      Some
//                                        D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,42--5,43) IsSynthetic=false,
//                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,21--5,43) IsSynthetic=false),
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,4--5,43) IsSynthetic=false),
//                                Ident result,
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,4--6,10) IsSynthetic=false),
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,9--4,29) IsSynthetic=false,
//                             NoSequencePointAtInvisibleBinding),
//                          D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,9--6,10) IsSynthetic=false);
//                       Member
//                         (Binding
//                            (null,NormalBinding,false,false,[],
//                             PreXmlDoc
//                               (Microsoft.FSharp.Compiler.Range+pos,
//                                Microsoft.FSharp.Compiler.Ast+XmlDocCollector),
//                             SynValData
//                               (Some {IsInstance = true;
//                                      IsDispatchSlot = false;
//                                      IsOverrideOrExplicitImpl = false;
//                                      IsFinal = false;
//                                      MemberKind = Member;},
//                                SynValInfo
//                                  ([[SynArgInfo ([],false,null)];
//                                    [SynArgInfo ([],false,Some ex)]],
//                                   SynArgInfo ([],false,null)),null),
//                             LongIdent
//                               (LongIdentWithDots
//                                  ([__; Caught],
//                                   [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (7,11--7,12) IsSynthetic=false]),
//                                null,null,
//                                Pats
//                                  [Paren
//                                     (Typed
//                                        (Named
//                                           (Wild
//                                              D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (7,19--7,21) IsSynthetic=false,
//                                            ex,false,null,
//                                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (7,19--7,21) IsSynthetic=false),
//                                         LongIdent (LongIdentWithDots ([exn],[])),
//                                         D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (7,19--7,26) IsSynthetic=false),
//                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (7,18--7,27) IsSynthetic=false)],
//                                null,
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (7,9--7,27) IsSynthetic=false),
//                             null,
//                             App
//                               (Atomic,false,
//                                LongIdent
//                                  (false,
//                                   LongIdentWithDots
//                                     ([Console; WriteLine],
//                                      [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (8,11--8,12) IsSynthetic=false]),
//                                   null,
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (8,4--8,21) IsSynthetic=false),
//                                Paren
//                                  (Tuple
//                                     ([Const
//                                         (String
//                                            ("Exception={0}",
//                                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (8,22--8,37) IsSynthetic=false),
//                                          D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (8,22--8,37) IsSynthetic=false);
//                                       Ident ex],
//                                      [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (8,37--8,38) IsSynthetic=false],
//                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (8,22--8,41) IsSynthetic=false),
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (8,21--8,22) IsSynthetic=false,
//                                   Some
//                                     D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (8,41--8,42) IsSynthetic=false,
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (8,21--8,42) IsSynthetic=false),
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (8,4--8,42) IsSynthetic=false),
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (7,9--7,27) IsSynthetic=false,
//                             NoSequencePointAtInvisibleBinding),
//                          D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (7,9--8,42) IsSynthetic=false)],
//                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,2--8,42) IsSynthetic=false),
//                   [],
//                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (3,5--8,42) IsSynthetic=false)],
//               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (3,0--8,42) IsSynthetic=false);
//            Types
//              ([TypeDefn
//                  (ComponentInfo
//                     ([],[],[],[Aspect],
//                      PreXmlDoc
//                        (Microsoft.FSharp.Compiler.Range+pos,
//                         Microsoft.FSharp.Compiler.Ast+XmlDocCollector),false,
//                      null,
//                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (10,5--10,11) IsSynthetic=false),
//                   ObjectModel
//                     (TyconUnspecified,
//                      [ImplicitCtor
//                         (null,[],[],null,
//                          D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (10,5--10,11) IsSynthetic=false);
//                       Member
//                         (Binding
//                            (null,NormalBinding,false,false,[],
//                             PreXmlDoc
//                               (Microsoft.FSharp.Compiler.Range+pos,
//                                Microsoft.FSharp.Compiler.Ast+XmlDocCollector),
//                             SynValData
//                               (Some {IsInstance = false;
//                                      IsDispatchSlot = false;
//                                      IsOverrideOrExplicitImpl = false;
//                                      IsFinal = false;
//                                      MemberKind = Member;},
//                                SynValInfo
//                                  ([[SynArgInfo ([],false,Some name);
//                                     SynArgInfo ([],false,Some line);
//                                     SynArgInfo ([],false,Some column);
//                                     SynArgInfo ([],false,Some args)]],
//                                   SynArgInfo ([],false,null)),null),
//                             LongIdent
//                               (LongIdentWithDots ([Enter],[]),null,null,
//                                Pats
//                                  [Paren
//                                     (Tuple
//                                        ([Typed
//                                            (Named
//                                               (Wild
//                                                  D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (11,22--11,26) IsSynthetic=false,
//                                                name,false,null,
//                                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (11,22--11,26) IsSynthetic=false),
//                                             LongIdent
//                                               (LongIdentWithDots ([string],[])),
//                                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (11,22--11,34) IsSynthetic=false);
//                                          Typed
//                                            (Named
//                                               (Wild
//                                                  D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (11,36--11,40) IsSynthetic=false,
//                                                line,false,null,
//                                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (11,36--11,40) IsSynthetic=false),
//                                             LongIdent
//                                               (LongIdentWithDots ([int],[])),
//                                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (11,36--11,45) IsSynthetic=false);
//                                          Typed
//                                            (Named
//                                               (Wild
//                                                  D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (11,47--11,53) IsSynthetic=false,
//                                                column,false,null,
//                                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (11,47--11,53) IsSynthetic=false),
//                                             LongIdent
//                                               (LongIdentWithDots ([int],[])),
//                                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (11,47--11,58) IsSynthetic=false);
//                                          Typed
//                                            (Named
//                                               (Wild
//                                                  D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (11,60--11,64) IsSynthetic=false,
//                                                args,false,null,
//                                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (11,60--11,64) IsSynthetic=false),
//                                             Array
//                                               (1,
//                                                LongIdent
//                                                  (LongIdentWithDots ([obj],[])),
//                                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (11,66--11,71) IsSynthetic=false),
//                                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (11,60--11,71) IsSynthetic=false)],
//                                         D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (11,22--11,71) IsSynthetic=false),
//                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (11,21--11,72) IsSynthetic=false)],
//                                null,
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (11,16--11,72) IsSynthetic=false),
//                             null,
//                             Sequential
//                               (SequencePointsAtSeq,true,
//                                App
//                                  (Atomic,false,
//                                   LongIdent
//                                     (false,
//                                      LongIdentWithDots
//                                        ([Console; WriteLine],
//                                         [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (12,11--12,12) IsSynthetic=false]),
//                                      null,
//                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (12,4--12,21) IsSynthetic=false),
//                                   Paren
//                                     (Tuple
//                                        ([Const
//                                            (String
//                                               ("{0}({1},{2}): {3}",
//                                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (12,22--12,41) IsSynthetic=false),
//                                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (12,22--12,41) IsSynthetic=false);
//                                          Ident name; Ident line; Ident column;
//                                          App
//                                            (Atomic,false,
//                                             LongIdent
//                                               (false,
//                                                LongIdentWithDots
//                                                  ([String; Join],
//                                                   [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (12,69--12,70) IsSynthetic=false]),
//                                                null,
//                                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (12,63--12,74) IsSynthetic=false),
//                                             Paren
//                                               (Tuple
//                                                  ([Const
//                                                      (String
//                                                         (",",
//                                                          D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (12,75--12,78) IsSynthetic=false),
//                                                       D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (12,75--12,78) IsSynthetic=false);
//                                                    Ident args],
//                                                   [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (12,78--12,79) IsSynthetic=false],
//                                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (12,75--12,84) IsSynthetic=false),
//                                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (12,74--12,75) IsSynthetic=false,
//                                                Some
//                                                  D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (12,84--12,85) IsSynthetic=false,
//                                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (12,74--12,85) IsSynthetic=false),
//                                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (12,63--12,85) IsSynthetic=false)],
//                                         [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (12,41--12,42) IsSynthetic=false;
//                                          D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (12,47--12,48) IsSynthetic=false;
//                                          D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (12,53--12,54) IsSynthetic=false;
//                                          D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (12,61--12,62) IsSynthetic=false],
//                                         D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (12,22--12,85) IsSynthetic=false),
//                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (12,21--12,22) IsSynthetic=false,
//                                      Some
//                                        D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (12,85--12,86) IsSynthetic=false,
//                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (12,21--12,86) IsSynthetic=false),
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (12,4--12,86) IsSynthetic=false),
//                                New
//                                  (false,
//                                   LongIdent
//                                     (LongIdentWithDots ([AspectContext],[])),
//                                   Const
//                                     (Unit,
//                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (13,21--13,23) IsSynthetic=false),
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (13,4--13,23) IsSynthetic=false),
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (12,4--13,23) IsSynthetic=false),
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (11,16--11,72) IsSynthetic=false,
//                             NoSequencePointAtInvisibleBinding),
//                          D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (11,16--13,23) IsSynthetic=false)],
//                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (11,2--13,23) IsSynthetic=false),
//                   [],
//                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (10,5--13,23) IsSynthetic=false)],
//               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (10,0--13,23) IsSynthetic=false);
//            Let
//              (false,
//               [Binding
//                  (null,NormalBinding,false,false,[],
//                   PreXmlDoc
//                     (Microsoft.FSharp.Compiler.Range+pos,
//                      Microsoft.FSharp.Compiler.Ast+XmlDocCollector),
//                   SynValData
//                     (null,SynValInfo ([],SynArgInfo ([],false,null)),null),
//                   Named
//                     (Wild
//                        D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (15,4--15,12) IsSynthetic=false,
//                      original,false,null,
//                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (15,4--15,12) IsSynthetic=false),
//                   null,
//                   App
//                     (Atomic,false,
//                      LongIdent
//                        (false,
//                         LongIdentWithDots
//                           ([System; String; Format],
//                            [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,8--16,9) IsSynthetic=false;
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,15--16,16) IsSynthetic=false]),
//                         null,
//                         D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,2--16,22) IsSynthetic=false),
//                      Paren
//                        (Tuple
//                           ([Const
//                               (String
//                                  ("ABC",
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,23--16,28) IsSynthetic=false),
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,23--16,28) IsSynthetic=false);
//                             Const
//                               (Int32 123,
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,30--16,33) IsSynthetic=false);
//                             Const
//                               (Int32 456,
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,35--16,38) IsSynthetic=false);
//                             Const
//                               (Int32 789,
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,40--16,43) IsSynthetic=false)],
//                            [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,28--16,29) IsSynthetic=false;
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,33--16,34) IsSynthetic=false;
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,38--16,39) IsSynthetic=false],
//                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,23--16,43) IsSynthetic=false),
//                         D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,22--16,23) IsSynthetic=false,
//                         Some
//                           D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,43--16,44) IsSynthetic=false,
//                         D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,22--16,44) IsSynthetic=false),
//                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,2--16,44) IsSynthetic=false),
//                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (15,4--15,12) IsSynthetic=false,
//                   SequencePointAtBinding
//                     D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (15,0--16,44) IsSynthetic=false)],
//               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (15,0--16,44) IsSynthetic=false);
//            Let
//              (false,
//               [Binding
//                  (null,NormalBinding,false,false,[],
//                   PreXmlDoc
//                     (Microsoft.FSharp.Compiler.Range+pos,
//                      Microsoft.FSharp.Compiler.Ast+XmlDocCollector),
//                   SynValData
//                     (null,SynValInfo ([],SynArgInfo ([],false,null)),null),
//                   Named
//                     (Wild
//                        D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (18,4--18,12) IsSynthetic=false,
//                      filtered,false,null,
//                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (18,4--18,12) IsSynthetic=false),
//                   null,
//                   LetOrUse
//                     (false,false,
//                      [Binding
//                         (null,NormalBinding,false,false,[],
//                          PreXmlDoc
//                            (Microsoft.FSharp.Compiler.Range+pos,
//                             Microsoft.FSharp.Compiler.Ast+XmlDocCollector),
//                          SynValData
//                            (null,SynValInfo ([],SynArgInfo ([],false,null)),null),
//                          Named
//                            (Wild
//                               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (19,6--19,10) IsSynthetic=false,
//                             arg0,false,null,
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (19,6--19,10) IsSynthetic=false),
//                          null,
//                          Const
//                            (String
//                               ("ABC",
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (19,13--19,18) IsSynthetic=false),
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (19,13--19,18) IsSynthetic=false),
//                          D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (19,6--19,10) IsSynthetic=false,
//                          SequencePointAtBinding
//                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (19,2--19,18) IsSynthetic=false)],
//                      LetOrUse
//                        (false,false,
//                         [Binding
//                            (null,NormalBinding,false,false,[],
//                             PreXmlDoc
//                               (Microsoft.FSharp.Compiler.Range+pos,
//                                Microsoft.FSharp.Compiler.Ast+XmlDocCollector),
//                             SynValData
//                               (null,SynValInfo ([],SynArgInfo ([],false,null)),
//                                null),
//                             Named
//                               (Wild
//                                  D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (20,6--20,10) IsSynthetic=false,
//                                arg1,false,null,
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (20,6--20,10) IsSynthetic=false),
//                             null,
//                             Const
//                               (Int32 123,
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (20,13--20,16) IsSynthetic=false),
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (20,6--20,10) IsSynthetic=false,
//                             SequencePointAtBinding
//                               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (20,2--20,16) IsSynthetic=false)],
//                         LetOrUse
//                           (false,false,
//                            [Binding
//                               (null,NormalBinding,false,false,[],
//                                PreXmlDoc
//                                  (Microsoft.FSharp.Compiler.Range+pos,
//                                   Microsoft.FSharp.Compiler.Ast+XmlDocCollector),
//                                SynValData
//                                  (null,
//                                   SynValInfo ([],SynArgInfo ([],false,null)),
//                                   null),
//                                Named
//                                  (Wild
//                                     D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (21,6--21,10) IsSynthetic=false,
//                                   arg2,false,null,
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (21,6--21,10) IsSynthetic=false),
//                                null,
//                                Const
//                                  (Int32 456,
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (21,13--21,16) IsSynthetic=false),
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (21,6--21,10) IsSynthetic=false,
//                                SequencePointAtBinding
//                                  D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (21,2--21,16) IsSynthetic=false)],
//                            LetOrUse
//                              (false,false,
//                               [Binding
//                                  (null,NormalBinding,false,false,[],
//                                   PreXmlDoc
//                                     (Microsoft.FSharp.Compiler.Range+pos,
//                                      Microsoft.FSharp.Compiler.Ast+XmlDocCollector),
//                                   SynValData
//                                     (null,
//                                      SynValInfo ([],SynArgInfo ([],false,null)),
//                                      null),
//                                   Named
//                                     (Wild
//                                        D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (22,6--22,10) IsSynthetic=false,
//                                      arg3,false,null,
//                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (22,6--22,10) IsSynthetic=false),
//                                   null,
//                                   Const
//                                     (Int32 789,
//                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (22,13--22,16) IsSynthetic=false),
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (22,6--22,10) IsSynthetic=false,
//                                   SequencePointAtBinding
//                                     D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (22,2--22,16) IsSynthetic=false)],
//                               LetOrUse
//                                 (false,false,
//                                  [Binding
//                                     (null,NormalBinding,false,false,[],
//                                      PreXmlDoc
//                                        (Microsoft.FSharp.Compiler.Range+pos,
//                                         Microsoft.FSharp.Compiler.Ast+XmlDocCollector),
//                                      SynValData
//                                        (null,
//                                         SynValInfo
//                                           ([],SynArgInfo ([],false,null)),null),
//                                      Named
//                                        (Wild
//                                           D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (23,6--23,13) IsSynthetic=false,
//                                         context,false,null,
//                                         D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (23,6--23,13) IsSynthetic=false),
//                                      null,
//                                      App
//                                        (Atomic,false,
//                                         LongIdent
//                                           (false,
//                                            LongIdentWithDots
//                                              ([Aspect; Enter],
//                                               [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (23,22--23,23) IsSynthetic=false]),
//                                            null,
//                                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (23,16--23,28) IsSynthetic=false),
//                                         Paren
//                                           (Tuple
//                                              ([Const
//                                                  (String
//                                                     ("Sample.fs",
//                                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (23,29--23,40) IsSynthetic=false),
//                                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (23,29--23,40) IsSynthetic=false);
//                                                Const
//                                                  (Int32 12,
//                                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (23,42--23,44) IsSynthetic=false);
//                                                Const
//                                                  (Int32 34,
//                                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (23,46--23,48) IsSynthetic=false);
//                                                ArrayOrListOfSeqExpr
//                                                  (true,
//                                                   CompExpr
//                                                     (true,{contents = true;},
//                                                      Sequential
//                                                        (SequencePointsAtSeq,true,
//                                                         Ident arg0,
//                                                         Sequential
//                                                           (SequencePointsAtSeq,
//                                                            true,Ident arg1,
//                                                            Sequential
//                                                              (SequencePointsAtSeq,
//                                                               true,Ident arg2,
//                                                               Ident arg3,
//                                                               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (23,62--23,71) IsSynthetic=false),
//                                                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (23,57--23,71) IsSynthetic=false),
//                                                         D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (23,52--23,71) IsSynthetic=false),
//                                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (23,52--23,71) IsSynthetic=false),
//                                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (23,50--23,73) IsSynthetic=false)],
//                                               [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (23,40--23,41) IsSynthetic=false;
//                                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (23,44--23,45) IsSynthetic=false;
//                                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (23,48--23,49) IsSynthetic=false],
//                                               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (23,29--23,73) IsSynthetic=false),
//                                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (23,28--23,29) IsSynthetic=false,
//                                            Some
//                                              D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (23,73--23,74) IsSynthetic=false,
//                                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (23,28--23,74) IsSynthetic=false),
//                                         D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (23,16--23,74) IsSynthetic=false),
//                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (23,6--23,13) IsSynthetic=false,
//                                      SequencePointAtBinding
//                                        D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (23,2--23,74) IsSynthetic=false)],
//                                  TryWith
//                                    (App
//                                       (Atomic,false,
//                                        LongIdent
//                                          (false,
//                                           LongIdentWithDots
//                                             ([context; Leave],
//                                              [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,11--25,12) IsSynthetic=false]),
//                                           null,
//                                           D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,4--25,17) IsSynthetic=false),
//                                        Paren
//                                          (App
//                                             (Atomic,false,
//                                              LongIdent
//                                                (false,
//                                                 LongIdentWithDots
//                                                   ([System; String; Format],
//                                                    [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,24--25,25) IsSynthetic=false;
//                                                     D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,31--25,32) IsSynthetic=false]),
//                                                 null,
//                                                 D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,18--25,38) IsSynthetic=false),
//                                              Paren
//                                                (Tuple
//                                                   ([Ident arg0; Ident arg1;
//                                                     Ident arg2; Ident arg3],
//                                                    [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,43--25,44) IsSynthetic=false;
//                                                     D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,49--25,50) IsSynthetic=false;
//                                                     D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,55--25,56) IsSynthetic=false],
//                                                    D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,39--25,61) IsSynthetic=false),
//                                                 D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,38--25,39) IsSynthetic=false,
//                                                 Some
//                                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,61--25,62) IsSynthetic=false,
//                                                 D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,38--25,62) IsSynthetic=false),
//                                              D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,18--25,62) IsSynthetic=false),
//                                           D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,17--25,18) IsSynthetic=false,
//                                           Some
//                                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,62--25,63) IsSynthetic=false,
//                                           D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,17--25,63) IsSynthetic=false),
//                                        D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,4--25,63) IsSynthetic=false),
//                                     D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (24,2--26,6) IsSynthetic=false,
//                                     [Clause
//                                        (Named
//                                           (Wild
//                                              D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (27,4--27,6) IsSynthetic=false,
//                                            ex,false,null,
//                                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (27,4--27,6) IsSynthetic=false),
//                                         null,
//                                         Sequential
//                                           (SequencePointsAtSeq,true,
//                                            App
//                                              (Atomic,false,
//                                               LongIdent
//                                                 (false,
//                                                  LongIdentWithDots
//                                                    ([context; Caught],
//                                                     [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (28,11--28,12) IsSynthetic=false]),
//                                                  null,
//                                                  D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (28,4--28,18) IsSynthetic=false),
//                                               Paren
//                                                 (Ident ex,
//                                                  D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (28,18--28,19) IsSynthetic=false,
//                                                  Some
//                                                    D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (28,21--28,22) IsSynthetic=false,
//                                                  D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (28,18--28,22) IsSynthetic=false),
//                                               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (28,4--28,22) IsSynthetic=false),
//                                            App
//                                              (Atomic,false,Ident reraise,
//                                               Const
//                                                 (Unit,
//                                                  D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (29,11--29,13) IsSynthetic=false),
//                                               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (29,4--29,13) IsSynthetic=false),
//                                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (28,4--29,13) IsSynthetic=false),
//                                         D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (27,4--27,6) IsSynthetic=false,
//                                         SequencePointAtTarget)],
//                                     D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (26,2--29,13) IsSynthetic=false,
//                                     D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (24,2--29,13) IsSynthetic=false,
//                                     SequencePointAtTry
//                                       D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (24,2--24,5) IsSynthetic=false,
//                                     SequencePointAtWith
//                                       D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (26,2--26,6) IsSynthetic=false),
//                                  D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (23,2--29,13) IsSynthetic=false),
//                               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (22,2--29,13) IsSynthetic=false),
//                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (21,2--29,13) IsSynthetic=false),
//                         D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (20,2--29,13) IsSynthetic=false),
//                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (19,2--29,13) IsSynthetic=false),
//                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (18,4--18,12) IsSynthetic=false,
//                   NoSequencePointAtLetBinding)],
//               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (18,0--29,13) IsSynthetic=false)],
//           PreXmlDocEmpty,[],null,
//           D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (1,0--30,0) IsSynthetic=false)],
//       (true, false)))


let ast =
  Ast.ParsedInput.ImplFile(
    Ast.ParsedImplFileInput.ParsedImplFileInput( (* Item *)
      "D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs" (* filename *),
      false (* isScript *),
      Ast.QualifiedNameOfFile.QualifiedNameOfFile( (* Item3 *)
        Sample (* Item *)),
      [ (* Item4 *)],
      [ (* Item5 *)],
      [ (* Item6 *)
        Ast.SynModuleOrNamespace.SynModuleOrNamespace( (* [0] *)
          [ (* id *)
            Sample (* [0] *)],
          false (* isRec *),
          true (* isModule *),
          [ (* decls *)
            Ast.SynModuleDecl.Open( (* [0] *)
              Ast.LongIdentWithDots.LongIdentWithDots( (* Item1 *)
                [ (* id *)
                  System (* [0] *)],
                [ (* dotms *)]),
              new Range.range() (* Item2 *));
            Ast.SynModuleDecl.Types( (* [1] *)
              [ (* Item1 *)
                Ast.SynTypeDefn.TypeDefn( (* [0] *)
                  Ast.SynComponentInfo.ComponentInfo( (* Item1 *)
                    [ (* attributes *)],
                    [ (* typeParams *)],
                    [ (* constraints *)],
                    [ (* Item4 *)
                      AspectContext (* [0] *)],
                    Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                      new Range.pos() (* Item1 *),
                      Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                    false (* preferPostfix *),
                    null (* accessiblity *),
                    new Range.range() (* range *)),
                  Ast.SynTypeDefnRepr.ObjectModel( (* Item2 *)
                    Ast.SynTypeDefnKind.TyconUnspecified( (* Item1 *)),
                    [ (* members *)
                      Ast.SynMemberDefn.ImplicitCtor( (* [0] *)
                        null (* accessiblity *),
                        [ (* attributes *)],
                        [ (* ctorArgs *)],
                        null (* selfIdentifier *),
                        new Range.range() (* range *));
                      Ast.SynMemberDefn.Member( (* [1] *)
                        Ast.SynBinding.Binding( (* memberDefn *)
                          null (* access *),
                          Ast.SynBindingKind.NormalBinding( (* bindingKind *)),
                          false (* mustInline *),
                          false (* isMutable *),
                          [ (* attributes *)],
                          Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                            new Range.pos() (* Item1 *),
                            Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                          Ast.SynValData.SynValData( (* Item7 *)
                            MemberFlags>.Some( (* Item1 *)
                              { (* Value *)
                                true (* IsInstance *);
                                false (* IsDispatchSlot *);
                                false (* IsOverrideOrExplicitImpl *);
                                false (* IsFinal *);
                                Ast.MemberKind.Member( (* MemberKind *))}),
                            Ast.SynValInfo.SynValInfo( (* Item2 *)
                              [ (* Item1 *)
                                [ (* [0] *)
                                  Ast.SynArgInfo.SynArgInfo( (* [0] *)
                                    [ (* attributes *)],
                                    false (* optional *),
                                    null (* id *))];
                                [ (* [1] *)
                                  Ast.SynArgInfo.SynArgInfo( (* [0] *)
                                    [ (* attributes *)],
                                    false (* optional *),
                                    Ident>.Some( (* id *)
                                      result (* Value *)))]],
                              Ast.SynArgInfo.SynArgInfo( (* Item2 *)
                                [ (* attributes *)],
                                false (* optional *),
                                null (* id *))),
                            null (* Item3 *)),
                          Ast.SynPat.LongIdent( (* headPat *)
                            Ast.LongIdentWithDots.LongIdentWithDots( (* dotId *)
                              [ (* id *)
                                __ (* [0] *);
                                Leave (* [1] *)],
                              [ (* dotms *)
                                new Range.range() (* [0] *)]),
                            null (* Item2 *),
                            null (* Item3 *),
                            Ast.SynConstructorArgs.Pats( (* Item4 *)
                              [ (* Item *)
                                Ast.SynPat.Paren( (* [0] *)
                                  Ast.SynPat.Typed( (* Item1 *)
                                    Ast.SynPat.Named( (* Item1 *)
                                      Ast.SynPat.Wild( (* Item1 *)
                                        new Range.range() (* range *)),
                                      result (* id *),
                                      false (* isThisVar *),
                                      null (* accessiblity *),
                                      new Range.range() (* range *)),
                                    Ast.SynType.Var( (* typeName *)
                                      Ast.SynTypar.Typar( (* Item1 *)
                                        T (* id *),
                                        Ast.TyparStaticReq.NoStaticReq( (* staticReq *)),
                                        false (* isCompGen *)),
                                      new Range.range() (* range *)),
                                    new Range.range() (* range *)),
                                  new Range.range() (* range *))]),
                            null (* Item5 *),
                            new Range.range() (* range *)),
                          null (* Item9 *),
                          Ast.SynExpr.Sequential( (* expr *)
                            Ast.SequencePointInfoForSeq.SequencePointsAtSeq( (* spSeq *)),
                            true (* isTrueSeq *),
                            Ast.SynExpr.App( (* expr1 *)
                              ExprAtomicFlag.Atomic (* exprAtomicFlag *),
                              false (* isInfix *),
                              Ast.SynExpr.LongIdent( (* funcExpr *)
                                false (* isOptional *),
                                Ast.LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                                  [ (* id *)
                                    Console (* [0] *);
                                    WriteLine (* [1] *)],
                                  [ (* dotms *)
                                    new Range.range() (* [0] *)]),
                                null (* altNameRefCell *),
                                new Range.range() (* range *)),
                              Ast.SynExpr.Paren( (* argExpr *)
                                Ast.SynExpr.Tuple( (* expr *)
                                  [ (* exprs *)
                                    Ast.SynExpr.Const( (* [0] *)
                                      Ast.SynConst.String( (* constant *)
                                        "Result={0}" (* text *),
                                        new Range.range() (* range *)),
                                      new Range.range() (* range *));
                                    Ast.SynExpr.Ident( (* [1] *)
                                      result (* Item *))],
                                  [ (* commaRanges *)
                                    new Range.range() (* [0] *)],
                                  new Range.range() (* range *)),
                                new Range.range() (* leftParenRange *),
                                range>.Some( (* rightParenRange *)
                                  new Range.range() (* Value *)),
                                new Range.range() (* range *)),
                              new Range.range() (* range *)),
                            Ast.SynExpr.Ident( (* expr2 *)
                              result (* Item *)),
                            new Range.range() (* range *)),
                          new Range.range() (* lhsRange *),
                          Ast.SequencePointInfoForBinding.NoSequencePointAtInvisibleBinding( (* spBind *))),
                        new Range.range() (* range *));
                      Ast.SynMemberDefn.Member( (* [2] *)
                        Ast.SynBinding.Binding( (* memberDefn *)
                          null (* access *),
                          Ast.SynBindingKind.NormalBinding( (* bindingKind *)),
                          false (* mustInline *),
                          false (* isMutable *),
                          [ (* attributes *)],
                          Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                            new Range.pos() (* Item1 *),
                            Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                          Ast.SynValData.SynValData( (* Item7 *)
                            MemberFlags>.Some( (* Item1 *)
                              { (* Value *)
                                true (* IsInstance *);
                                false (* IsDispatchSlot *);
                                false (* IsOverrideOrExplicitImpl *);
                                false (* IsFinal *);
                                Ast.MemberKind.Member( (* MemberKind *))}),
                            Ast.SynValInfo.SynValInfo( (* Item2 *)
                              [ (* Item1 *)
                                [ (* [0] *)
                                  Ast.SynArgInfo.SynArgInfo( (* [0] *)
                                    [ (* attributes *)],
                                    false (* optional *),
                                    null (* id *))];
                                [ (* [1] *)
                                  Ast.SynArgInfo.SynArgInfo( (* [0] *)
                                    [ (* attributes *)],
                                    false (* optional *),
                                    Ident>.Some( (* id *)
                                      ex (* Value *)))]],
                              Ast.SynArgInfo.SynArgInfo( (* Item2 *)
                                [ (* attributes *)],
                                false (* optional *),
                                null (* id *))),
                            null (* Item3 *)),
                          Ast.SynPat.LongIdent( (* headPat *)
                            Ast.LongIdentWithDots.LongIdentWithDots( (* dotId *)
                              [ (* id *)
                                __ (* [0] *);
                                Caught (* [1] *)],
                              [ (* dotms *)
                                new Range.range() (* [0] *)]),
                            null (* Item2 *),
                            null (* Item3 *),
                            Ast.SynConstructorArgs.Pats( (* Item4 *)
                              [ (* Item *)
                                Ast.SynPat.Paren( (* [0] *)
                                  Ast.SynPat.Typed( (* Item1 *)
                                    Ast.SynPat.Named( (* Item1 *)
                                      Ast.SynPat.Wild( (* Item1 *)
                                        new Range.range() (* range *)),
                                      ex (* id *),
                                      false (* isThisVar *),
                                      null (* accessiblity *),
                                      new Range.range() (* range *)),
                                    Ast.SynType.LongIdent( (* typeName *)
                                      Ast.LongIdentWithDots.LongIdentWithDots( (* Item *)
                                        [ (* id *)
                                          exn (* [0] *)],
                                        [ (* dotms *)])),
                                    new Range.range() (* range *)),
                                  new Range.range() (* range *))]),
                            null (* Item5 *),
                            new Range.range() (* range *)),
                          null (* Item9 *),
                          Ast.SynExpr.App( (* expr *)
                            ExprAtomicFlag.Atomic (* exprAtomicFlag *),
                            false (* isInfix *),
                            Ast.SynExpr.LongIdent( (* funcExpr *)
                              false (* isOptional *),
                              Ast.LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                                [ (* id *)
                                  Console (* [0] *);
                                  WriteLine (* [1] *)],
                                [ (* dotms *)
                                  new Range.range() (* [0] *)]),
                              null (* altNameRefCell *),
                              new Range.range() (* range *)),
                            Ast.SynExpr.Paren( (* argExpr *)
                              Ast.SynExpr.Tuple( (* expr *)
                                [ (* exprs *)
                                  Ast.SynExpr.Const( (* [0] *)
                                    Ast.SynConst.String( (* constant *)
                                      "Exception={0}" (* text *),
                                      new Range.range() (* range *)),
                                    new Range.range() (* range *));
                                  Ast.SynExpr.Ident( (* [1] *)
                                    ex (* Item *))],
                                [ (* commaRanges *)
                                  new Range.range() (* [0] *)],
                                new Range.range() (* range *)),
                              new Range.range() (* leftParenRange *),
                              range>.Some( (* rightParenRange *)
                                new Range.range() (* Value *)),
                              new Range.range() (* range *)),
                            new Range.range() (* range *)),
                          new Range.range() (* lhsRange *),
                          Ast.SequencePointInfoForBinding.NoSequencePointAtInvisibleBinding( (* spBind *))),
                        new Range.range() (* range *))],
                    new Range.range() (* range *)),
                  [ (* members *)],
                  new Range.range() (* range *))],
              new Range.range() (* Item2 *));
            Ast.SynModuleDecl.Types( (* [2] *)
              [ (* Item1 *)
                Ast.SynTypeDefn.TypeDefn( (* [0] *)
                  Ast.SynComponentInfo.ComponentInfo( (* Item1 *)
                    [ (* attributes *)],
                    [ (* typeParams *)],
                    [ (* constraints *)],
                    [ (* Item4 *)
                      Aspect (* [0] *)],
                    Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                      new Range.pos() (* Item1 *),
                      Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                    false (* preferPostfix *),
                    null (* accessiblity *),
                    new Range.range() (* range *)),
                  Ast.SynTypeDefnRepr.ObjectModel( (* Item2 *)
                    Ast.SynTypeDefnKind.TyconUnspecified( (* Item1 *)),
                    [ (* members *)
                      Ast.SynMemberDefn.ImplicitCtor( (* [0] *)
                        null (* accessiblity *),
                        [ (* attributes *)],
                        [ (* ctorArgs *)],
                        null (* selfIdentifier *),
                        new Range.range() (* range *));
                      Ast.SynMemberDefn.Member( (* [1] *)
                        Ast.SynBinding.Binding( (* memberDefn *)
                          null (* access *),
                          Ast.SynBindingKind.NormalBinding( (* bindingKind *)),
                          false (* mustInline *),
                          false (* isMutable *),
                          [ (* attributes *)],
                          Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                            new Range.pos() (* Item1 *),
                            Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                          Ast.SynValData.SynValData( (* Item7 *)
                            MemberFlags>.Some( (* Item1 *)
                              { (* Value *)
                                false (* IsInstance *);
                                false (* IsDispatchSlot *);
                                false (* IsOverrideOrExplicitImpl *);
                                false (* IsFinal *);
                                Ast.MemberKind.Member( (* MemberKind *))}),
                            Ast.SynValInfo.SynValInfo( (* Item2 *)
                              [ (* Item1 *)
                                [ (* [0] *)
                                  Ast.SynArgInfo.SynArgInfo( (* [0] *)
                                    [ (* attributes *)],
                                    false (* optional *),
                                    Ident>.Some( (* id *)
                                      name (* Value *)));
                                  Ast.SynArgInfo.SynArgInfo( (* [1] *)
                                    [ (* attributes *)],
                                    false (* optional *),
                                    Ident>.Some( (* id *)
                                      line (* Value *)));
                                  Ast.SynArgInfo.SynArgInfo( (* [2] *)
                                    [ (* attributes *)],
                                    false (* optional *),
                                    Ident>.Some( (* id *)
                                      column (* Value *)));
                                  Ast.SynArgInfo.SynArgInfo( (* [3] *)
                                    [ (* attributes *)],
                                    false (* optional *),
                                    Ident>.Some( (* id *)
                                      args (* Value *)))]],
                              Ast.SynArgInfo.SynArgInfo( (* Item2 *)
                                [ (* attributes *)],
                                false (* optional *),
                                null (* id *))),
                            null (* Item3 *)),
                          Ast.SynPat.LongIdent( (* headPat *)
                            Ast.LongIdentWithDots.LongIdentWithDots( (* dotId *)
                              [ (* id *)
                                Enter (* [0] *)],
                              [ (* dotms *)]),
                            null (* Item2 *),
                            null (* Item3 *),
                            Ast.SynConstructorArgs.Pats( (* Item4 *)
                              [ (* Item *)
                                Ast.SynPat.Paren( (* [0] *)
                                  Ast.SynPat.Tuple( (* Item1 *)
                                    [ (* Item1 *)
                                      Ast.SynPat.Typed( (* [0] *)
                                        Ast.SynPat.Named( (* Item1 *)
                                          Ast.SynPat.Wild( (* Item1 *)
                                            new Range.range() (* range *)),
                                          name (* id *),
                                          false (* isThisVar *),
                                          null (* accessiblity *),
                                          new Range.range() (* range *)),
                                        Ast.SynType.LongIdent( (* typeName *)
                                          Ast.LongIdentWithDots.LongIdentWithDots( (* Item *)
                                            [ (* id *)
                                              string (* [0] *)],
                                            [ (* dotms *)])),
                                        new Range.range() (* range *));
                                      Ast.SynPat.Typed( (* [1] *)
                                        Ast.SynPat.Named( (* Item1 *)
                                          Ast.SynPat.Wild( (* Item1 *)
                                            new Range.range() (* range *)),
                                          line (* id *),
                                          false (* isThisVar *),
                                          null (* accessiblity *),
                                          new Range.range() (* range *)),
                                        Ast.SynType.LongIdent( (* typeName *)
                                          Ast.LongIdentWithDots.LongIdentWithDots( (* Item *)
                                            [ (* id *)
                                              int (* [0] *)],
                                            [ (* dotms *)])),
                                        new Range.range() (* range *));
                                      Ast.SynPat.Typed( (* [2] *)
                                        Ast.SynPat.Named( (* Item1 *)
                                          Ast.SynPat.Wild( (* Item1 *)
                                            new Range.range() (* range *)),
                                          column (* id *),
                                          false (* isThisVar *),
                                          null (* accessiblity *),
                                          new Range.range() (* range *)),
                                        Ast.SynType.LongIdent( (* typeName *)
                                          Ast.LongIdentWithDots.LongIdentWithDots( (* Item *)
                                            [ (* id *)
                                              int (* [0] *)],
                                            [ (* dotms *)])),
                                        new Range.range() (* range *));
                                      Ast.SynPat.Typed( (* [3] *)
                                        Ast.SynPat.Named( (* Item1 *)
                                          Ast.SynPat.Wild( (* Item1 *)
                                            new Range.range() (* range *)),
                                          args (* id *),
                                          false (* isThisVar *),
                                          null (* accessiblity *),
                                          new Range.range() (* range *)),
                                        Ast.SynType.Array( (* typeName *)
                                          1 (* Item1 *),
                                          Ast.SynType.LongIdent( (* elementType *)
                                            Ast.LongIdentWithDots.LongIdentWithDots( (* Item *)
                                              [ (* id *)
                                                obj (* [0] *)],
                                              [ (* dotms *)])),
                                          new Range.range() (* range *)),
                                        new Range.range() (* range *))],
                                    new Range.range() (* range *)),
                                  new Range.range() (* range *))]),
                            null (* Item5 *),
                            new Range.range() (* range *)),
                          null (* Item9 *),
                          Ast.SynExpr.Sequential( (* expr *)
                            Ast.SequencePointInfoForSeq.SequencePointsAtSeq( (* spSeq *)),
                            true (* isTrueSeq *),
                            Ast.SynExpr.App( (* expr1 *)
                              ExprAtomicFlag.Atomic (* exprAtomicFlag *),
                              false (* isInfix *),
                              Ast.SynExpr.LongIdent( (* funcExpr *)
                                false (* isOptional *),
                                Ast.LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                                  [ (* id *)
                                    Console (* [0] *);
                                    WriteLine (* [1] *)],
                                  [ (* dotms *)
                                    new Range.range() (* [0] *)]),
                                null (* altNameRefCell *),
                                new Range.range() (* range *)),
                              Ast.SynExpr.Paren( (* argExpr *)
                                Ast.SynExpr.Tuple( (* expr *)
                                  [ (* exprs *)
                                    Ast.SynExpr.Const( (* [0] *)
                                      Ast.SynConst.String( (* constant *)
                                        "{0}({1},{2}): {3}" (* text *),
                                        new Range.range() (* range *)),
                                      new Range.range() (* range *));
                                    Ast.SynExpr.Ident( (* [1] *)
                                      name (* Item *));
                                    Ast.SynExpr.Ident( (* [2] *)
                                      line (* Item *));
                                    Ast.SynExpr.Ident( (* [3] *)
                                      column (* Item *));
                                    Ast.SynExpr.App( (* [4] *)
                                      ExprAtomicFlag.Atomic (* exprAtomicFlag *),
                                      false (* isInfix *),
                                      Ast.SynExpr.LongIdent( (* funcExpr *)
                                        false (* isOptional *),
                                        Ast.LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                                          [ (* id *)
                                            String (* [0] *);
                                            Join (* [1] *)],
                                          [ (* dotms *)
                                            new Range.range() (* [0] *)]),
                                        null (* altNameRefCell *),
                                        new Range.range() (* range *)),
                                      Ast.SynExpr.Paren( (* argExpr *)
                                        Ast.SynExpr.Tuple( (* expr *)
                                          [ (* exprs *)
                                            Ast.SynExpr.Const( (* [0] *)
                                              Ast.SynConst.String( (* constant *)
                                                "," (* text *),
                                                new Range.range() (* range *)),
                                              new Range.range() (* range *));
                                            Ast.SynExpr.Ident( (* [1] *)
                                              args (* Item *))],
                                          [ (* commaRanges *)
                                            new Range.range() (* [0] *)],
                                          new Range.range() (* range *)),
                                        new Range.range() (* leftParenRange *),
                                        range>.Some( (* rightParenRange *)
                                          new Range.range() (* Value *)),
                                        new Range.range() (* range *)),
                                      new Range.range() (* range *))],
                                  [ (* commaRanges *)
                                    new Range.range() (* [0] *);
                                    new Range.range() (* [1] *);
                                    new Range.range() (* [2] *);
                                    new Range.range() (* [3] *)],
                                  new Range.range() (* range *)),
                                new Range.range() (* leftParenRange *),
                                range>.Some( (* rightParenRange *)
                                  new Range.range() (* Value *)),
                                new Range.range() (* range *)),
                              new Range.range() (* range *)),
                            Ast.SynExpr.New( (* expr2 *)
                              false (* isProtected *),
                              Ast.SynType.LongIdent( (* typeName *)
                                Ast.LongIdentWithDots.LongIdentWithDots( (* Item *)
                                  [ (* id *)
                                    AspectContext (* [0] *)],
                                  [ (* dotms *)])),
                              Ast.SynExpr.Const( (* expr *)
                                Ast.SynConst.Unit( (* constant *)),
                                new Range.range() (* range *)),
                              new Range.range() (* range *)),
                            new Range.range() (* range *)),
                          new Range.range() (* lhsRange *),
                          Ast.SequencePointInfoForBinding.NoSequencePointAtInvisibleBinding( (* spBind *))),
                        new Range.range() (* range *))],
                    new Range.range() (* range *)),
                  [ (* members *)],
                  new Range.range() (* range *))],
              new Range.range() (* Item2 *));
            Ast.SynModuleDecl.Let( (* [3] *)
              false (* Item1 *),
              [ (* Item2 *)
                Ast.SynBinding.Binding( (* [0] *)
                  null (* access *),
                  Ast.SynBindingKind.NormalBinding( (* bindingKind *)),
                  false (* mustInline *),
                  false (* isMutable *),
                  [ (* attributes *)],
                  Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                    new Range.pos() (* Item1 *),
                    Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                  Ast.SynValData.SynValData( (* Item7 *)
                    null (* Item1 *),
                    Ast.SynValInfo.SynValInfo( (* Item2 *)
                      [ (* Item1 *)],
                      Ast.SynArgInfo.SynArgInfo( (* Item2 *)
                        [ (* attributes *)],
                        false (* optional *),
                        null (* id *))),
                    null (* Item3 *)),
                  Ast.SynPat.Named( (* headPat *)
                    Ast.SynPat.Wild( (* Item1 *)
                      new Range.range() (* range *)),
                    original (* id *),
                    false (* isThisVar *),
                    null (* accessiblity *),
                    new Range.range() (* range *)),
                  null (* Item9 *),
                  Ast.SynExpr.App( (* expr *)
                    ExprAtomicFlag.Atomic (* exprAtomicFlag *),
                    false (* isInfix *),
                    Ast.SynExpr.LongIdent( (* funcExpr *)
                      false (* isOptional *),
                      Ast.LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                        [ (* id *)
                          System (* [0] *);
                          String (* [1] *);
                          Format (* [2] *)],
                        [ (* dotms *)
                          new Range.range() (* [0] *);
                          new Range.range() (* [1] *)]),
                      null (* altNameRefCell *),
                      new Range.range() (* range *)),
                    Ast.SynExpr.Paren( (* argExpr *)
                      Ast.SynExpr.Tuple( (* expr *)
                        [ (* exprs *)
                          Ast.SynExpr.Const( (* [0] *)
                            Ast.SynConst.String( (* constant *)
                              "ABC" (* text *),
                              new Range.range() (* range *)),
                            new Range.range() (* range *));
                          Ast.SynExpr.Const( (* [1] *)
                            Ast.SynConst.Int32( (* constant *)
                              123 (* Item *)),
                            new Range.range() (* range *));
                          Ast.SynExpr.Const( (* [2] *)
                            Ast.SynConst.Int32( (* constant *)
                              456 (* Item *)),
                            new Range.range() (* range *));
                          Ast.SynExpr.Const( (* [3] *)
                            Ast.SynConst.Int32( (* constant *)
                              789 (* Item *)),
                            new Range.range() (* range *))],
                        [ (* commaRanges *)
                          new Range.range() (* [0] *);
                          new Range.range() (* [1] *);
                          new Range.range() (* [2] *)],
                        new Range.range() (* range *)),
                      new Range.range() (* leftParenRange *),
                      range>.Some( (* rightParenRange *)
                        new Range.range() (* Value *)),
                      new Range.range() (* range *)),
                    new Range.range() (* range *)),
                  new Range.range() (* lhsRange *),
                  Ast.SequencePointInfoForBinding.SequencePointAtBinding( (* spBind *)
                    new Range.range() (* Item *)))],
              new Range.range() (* Item3 *));
            Ast.SynModuleDecl.Let( (* [4] *)
              false (* Item1 *),
              [ (* Item2 *)
                Ast.SynBinding.Binding( (* [0] *)
                  null (* access *),
                  Ast.SynBindingKind.NormalBinding( (* bindingKind *)),
                  false (* mustInline *),
                  false (* isMutable *),
                  [ (* attributes *)],
                  Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                    new Range.pos() (* Item1 *),
                    Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                  Ast.SynValData.SynValData( (* Item7 *)
                    null (* Item1 *),
                    Ast.SynValInfo.SynValInfo( (* Item2 *)
                      [ (* Item1 *)],
                      Ast.SynArgInfo.SynArgInfo( (* Item2 *)
                        [ (* attributes *)],
                        false (* optional *),
                        null (* id *))),
                    null (* Item3 *)),
                  Ast.SynPat.Named( (* headPat *)
                    Ast.SynPat.Wild( (* Item1 *)
                      new Range.range() (* range *)),
                    filtered (* id *),
                    false (* isThisVar *),
                    null (* accessiblity *),
                    new Range.range() (* range *)),
                  null (* Item9 *),
                  Ast.SynExpr.LetOrUse( (* expr *)
                    false (* isRecursive *),
                    false (* isUse *),
                    [ (* bindings *)
                      Ast.SynBinding.Binding( (* [0] *)
                        null (* access *),
                        Ast.SynBindingKind.NormalBinding( (* bindingKind *)),
                        false (* mustInline *),
                        false (* isMutable *),
                        [ (* attributes *)],
                        Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                          new Range.pos() (* Item1 *),
                          Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                        Ast.SynValData.SynValData( (* Item7 *)
                          null (* Item1 *),
                          Ast.SynValInfo.SynValInfo( (* Item2 *)
                            [ (* Item1 *)],
                            Ast.SynArgInfo.SynArgInfo( (* Item2 *)
                              [ (* attributes *)],
                              false (* optional *),
                              null (* id *))),
                          null (* Item3 *)),
                        Ast.SynPat.Named( (* headPat *)
                          Ast.SynPat.Wild( (* Item1 *)
                            new Range.range() (* range *)),
                          arg0 (* id *),
                          false (* isThisVar *),
                          null (* accessiblity *),
                          new Range.range() (* range *)),
                        null (* Item9 *),
                        Ast.SynExpr.Const( (* expr *)
                          Ast.SynConst.String( (* constant *)
                            "ABC" (* text *),
                            new Range.range() (* range *)),
                          new Range.range() (* range *)),
                        new Range.range() (* lhsRange *),
                        Ast.SequencePointInfoForBinding.SequencePointAtBinding( (* spBind *)
                          new Range.range() (* Item *)))],
                    Ast.SynExpr.LetOrUse( (* exprBody *)
                      false (* isRecursive *),
                      false (* isUse *),
                      [ (* bindings *)
                        Ast.SynBinding.Binding( (* [0] *)
                          null (* access *),
                          Ast.SynBindingKind.NormalBinding( (* bindingKind *)),
                          false (* mustInline *),
                          false (* isMutable *),
                          [ (* attributes *)],
                          Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                            new Range.pos() (* Item1 *),
                            Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                          Ast.SynValData.SynValData( (* Item7 *)
                            null (* Item1 *),
                            Ast.SynValInfo.SynValInfo( (* Item2 *)
                              [ (* Item1 *)],
                              Ast.SynArgInfo.SynArgInfo( (* Item2 *)
                                [ (* attributes *)],
                                false (* optional *),
                                null (* id *))),
                            null (* Item3 *)),
                          Ast.SynPat.Named( (* headPat *)
                            Ast.SynPat.Wild( (* Item1 *)
                              new Range.range() (* range *)),
                            arg1 (* id *),
                            false (* isThisVar *),
                            null (* accessiblity *),
                            new Range.range() (* range *)),
                          null (* Item9 *),
                          Ast.SynExpr.Const( (* expr *)
                            Ast.SynConst.Int32( (* constant *)
                              123 (* Item *)),
                            new Range.range() (* range *)),
                          new Range.range() (* lhsRange *),
                          Ast.SequencePointInfoForBinding.SequencePointAtBinding( (* spBind *)
                            new Range.range() (* Item *)))],
                      Ast.SynExpr.LetOrUse( (* exprBody *)
                        false (* isRecursive *),
                        false (* isUse *),
                        [ (* bindings *)
                          Ast.SynBinding.Binding( (* [0] *)
                            null (* access *),
                            Ast.SynBindingKind.NormalBinding( (* bindingKind *)),
                            false (* mustInline *),
                            false (* isMutable *),
                            [ (* attributes *)],
                            Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                              new Range.pos() (* Item1 *),
                              Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                            Ast.SynValData.SynValData( (* Item7 *)
                              null (* Item1 *),
                              Ast.SynValInfo.SynValInfo( (* Item2 *)
                                [ (* Item1 *)],
                                Ast.SynArgInfo.SynArgInfo( (* Item2 *)
                                  [ (* attributes *)],
                                  false (* optional *),
                                  null (* id *))),
                              null (* Item3 *)),
                            Ast.SynPat.Named( (* headPat *)
                              Ast.SynPat.Wild( (* Item1 *)
                                new Range.range() (* range *)),
                              arg2 (* id *),
                              false (* isThisVar *),
                              null (* accessiblity *),
                              new Range.range() (* range *)),
                            null (* Item9 *),
                            Ast.SynExpr.Const( (* expr *)
                              Ast.SynConst.Int32( (* constant *)
                                456 (* Item *)),
                              new Range.range() (* range *)),
                            new Range.range() (* lhsRange *),
                            Ast.SequencePointInfoForBinding.SequencePointAtBinding( (* spBind *)
                              new Range.range() (* Item *)))],
                        Ast.SynExpr.LetOrUse( (* exprBody *)
                          false (* isRecursive *),
                          false (* isUse *),
                          [ (* bindings *)
                            Ast.SynBinding.Binding( (* [0] *)
                              null (* access *),
                              Ast.SynBindingKind.NormalBinding( (* bindingKind *)),
                              false (* mustInline *),
                              false (* isMutable *),
                              [ (* attributes *)],
                              Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                                new Range.pos() (* Item1 *),
                                Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                              Ast.SynValData.SynValData( (* Item7 *)
                                null (* Item1 *),
                                Ast.SynValInfo.SynValInfo( (* Item2 *)
                                  [ (* Item1 *)],
                                  Ast.SynArgInfo.SynArgInfo( (* Item2 *)
                                    [ (* attributes *)],
                                    false (* optional *),
                                    null (* id *))),
                                null (* Item3 *)),
                              Ast.SynPat.Named( (* headPat *)
                                Ast.SynPat.Wild( (* Item1 *)
                                  new Range.range() (* range *)),
                                arg3 (* id *),
                                false (* isThisVar *),
                                null (* accessiblity *),
                                new Range.range() (* range *)),
                              null (* Item9 *),
                              Ast.SynExpr.Const( (* expr *)
                                Ast.SynConst.Int32( (* constant *)
                                  789 (* Item *)),
                                new Range.range() (* range *)),
                              new Range.range() (* lhsRange *),
                              Ast.SequencePointInfoForBinding.SequencePointAtBinding( (* spBind *)
                                new Range.range() (* Item *)))],
                          Ast.SynExpr.LetOrUse( (* exprBody *)
                            false (* isRecursive *),
                            false (* isUse *),
                            [ (* bindings *)
                              Ast.SynBinding.Binding( (* [0] *)
                                null (* access *),
                                Ast.SynBindingKind.NormalBinding( (* bindingKind *)),
                                false (* mustInline *),
                                false (* isMutable *),
                                [ (* attributes *)],
                                Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                                  new Range.pos() (* Item1 *),
                                  Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                                Ast.SynValData.SynValData( (* Item7 *)
                                  null (* Item1 *),
                                  Ast.SynValInfo.SynValInfo( (* Item2 *)
                                    [ (* Item1 *)],
                                    Ast.SynArgInfo.SynArgInfo( (* Item2 *)
                                      [ (* attributes *)],
                                      false (* optional *),
                                      null (* id *))),
                                  null (* Item3 *)),
                                Ast.SynPat.Named( (* headPat *)
                                  Ast.SynPat.Wild( (* Item1 *)
                                    new Range.range() (* range *)),
                                  context (* id *),
                                  false (* isThisVar *),
                                  null (* accessiblity *),
                                  new Range.range() (* range *)),
                                null (* Item9 *),
                                Ast.SynExpr.App( (* expr *)
                                  ExprAtomicFlag.Atomic (* exprAtomicFlag *),
                                  false (* isInfix *),
                                  Ast.SynExpr.LongIdent( (* funcExpr *)
                                    false (* isOptional *),
                                    Ast.LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                                      [ (* id *)
                                        Aspect (* [0] *);
                                        Enter (* [1] *)],
                                      [ (* dotms *)
                                        new Range.range() (* [0] *)]),
                                    null (* altNameRefCell *),
                                    new Range.range() (* range *)),
                                  Ast.SynExpr.Paren( (* argExpr *)
                                    Ast.SynExpr.Tuple( (* expr *)
                                      [ (* exprs *)
                                        Ast.SynExpr.Const( (* [0] *)
                                          Ast.SynConst.String( (* constant *)
                                            "Sample.fs" (* text *),
                                            new Range.range() (* range *)),
                                          new Range.range() (* range *));
                                        Ast.SynExpr.Const( (* [1] *)
                                          Ast.SynConst.Int32( (* constant *)
                                            12 (* Item *)),
                                          new Range.range() (* range *));
                                        Ast.SynExpr.Const( (* [2] *)
                                          Ast.SynConst.Int32( (* constant *)
                                            34 (* Item *)),
                                          new Range.range() (* range *));
                                        Ast.SynExpr.ArrayOrListOfSeqExpr( (* [3] *)
                                          true (* isList *),
                                          Ast.SynExpr.CompExpr( (* elements *)
                                            true (* isArrayOrList *),
                                            { (* isNotNakedRefCell *)
                                              true (* contents *)},
                                            Ast.SynExpr.Sequential( (* expr *)
                                              Ast.SequencePointInfoForSeq.SequencePointsAtSeq( (* spSeq *)),
                                              true (* isTrueSeq *),
                                              Ast.SynExpr.Ident( (* expr1 *)
                                                arg0 (* Item *)),
                                              Ast.SynExpr.Sequential( (* expr2 *)
                                                Ast.SequencePointInfoForSeq.SequencePointsAtSeq( (* spSeq *)),
                                                true (* isTrueSeq *),
                                                Ast.SynExpr.Ident( (* expr1 *)
                                                  arg1 (* Item *)),
                                                Ast.SynExpr.Sequential( (* expr2 *)
                                                  Ast.SequencePointInfoForSeq.SequencePointsAtSeq( (* spSeq *)),
                                                  true (* isTrueSeq *),
                                                  Ast.SynExpr.Ident( (* expr1 *)
                                                    arg2 (* Item *)),
                                                  Ast.SynExpr.Ident( (* expr2 *)
                                                    arg3 (* Item *)),
                                                  new Range.range() (* range *)),
                                                new Range.range() (* range *)),
                                              new Range.range() (* range *)),
                                            new Range.range() (* range *)),
                                          new Range.range() (* range *))],
                                      [ (* commaRanges *)
                                        new Range.range() (* [0] *);
                                        new Range.range() (* [1] *);
                                        new Range.range() (* [2] *)],
                                      new Range.range() (* range *)),
                                    new Range.range() (* leftParenRange *),
                                    range>.Some( (* rightParenRange *)
                                      new Range.range() (* Value *)),
                                    new Range.range() (* range *)),
                                  new Range.range() (* range *)),
                                new Range.range() (* lhsRange *),
                                Ast.SequencePointInfoForBinding.SequencePointAtBinding( (* spBind *)
                                  new Range.range() (* Item *)))],
                            Ast.SynExpr.TryWith( (* exprBody *)
                              Ast.SynExpr.App( (* tryExpr *)
                                ExprAtomicFlag.Atomic (* exprAtomicFlag *),
                                false (* isInfix *),
                                Ast.SynExpr.LongIdent( (* funcExpr *)
                                  false (* isOptional *),
                                  Ast.LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                                    [ (* id *)
                                      context (* [0] *);
                                      Leave (* [1] *)],
                                    [ (* dotms *)
                                      new Range.range() (* [0] *)]),
                                  null (* altNameRefCell *),
                                  new Range.range() (* range *)),
                                Ast.SynExpr.Paren( (* argExpr *)
                                  Ast.SynExpr.App( (* expr *)
                                    ExprAtomicFlag.Atomic (* exprAtomicFlag *),
                                    false (* isInfix *),
                                    Ast.SynExpr.LongIdent( (* funcExpr *)
                                      false (* isOptional *),
                                      Ast.LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                                        [ (* id *)
                                          System (* [0] *);
                                          String (* [1] *);
                                          Format (* [2] *)],
                                        [ (* dotms *)
                                          new Range.range() (* [0] *);
                                          new Range.range() (* [1] *)]),
                                      null (* altNameRefCell *),
                                      new Range.range() (* range *)),
                                    Ast.SynExpr.Paren( (* argExpr *)
                                      Ast.SynExpr.Tuple( (* expr *)
                                        [ (* exprs *)
                                          Ast.SynExpr.Ident( (* [0] *)
                                            arg0 (* Item *));
                                          Ast.SynExpr.Ident( (* [1] *)
                                            arg1 (* Item *));
                                          Ast.SynExpr.Ident( (* [2] *)
                                            arg2 (* Item *));
                                          Ast.SynExpr.Ident( (* [3] *)
                                            arg3 (* Item *))],
                                        [ (* commaRanges *)
                                          new Range.range() (* [0] *);
                                          new Range.range() (* [1] *);
                                          new Range.range() (* [2] *)],
                                        new Range.range() (* range *)),
                                      new Range.range() (* leftParenRange *),
                                      range>.Some( (* rightParenRange *)
                                        new Range.range() (* Value *)),
                                      new Range.range() (* range *)),
                                    new Range.range() (* range *)),
                                  new Range.range() (* leftParenRange *),
                                  range>.Some( (* rightParenRange *)
                                    new Range.range() (* Value *)),
                                  new Range.range() (* range *)),
                                new Range.range() (* range *)),
                              new Range.range() (* Item2 *),
                              [ (* Item3 *)
                                Ast.SynMatchClause.Clause( (* [0] *)
                                  Ast.SynPat.Named( (* Item1 *)
                                    Ast.SynPat.Wild( (* Item1 *)
                                      new Range.range() (* range *)),
                                    ex (* id *),
                                    false (* isThisVar *),
                                    null (* accessiblity *),
                                    new Range.range() (* range *)),
                                  null (* Item2 *),
                                  Ast.SynExpr.Sequential( (* Item3 *)
                                    Ast.SequencePointInfoForSeq.SequencePointsAtSeq( (* spSeq *)),
                                    true (* isTrueSeq *),
                                    Ast.SynExpr.App( (* expr1 *)
                                      ExprAtomicFlag.Atomic (* exprAtomicFlag *),
                                      false (* isInfix *),
                                      Ast.SynExpr.LongIdent( (* funcExpr *)
                                        false (* isOptional *),
                                        Ast.LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                                          [ (* id *)
                                            context (* [0] *);
                                            Caught (* [1] *)],
                                          [ (* dotms *)
                                            new Range.range() (* [0] *)]),
                                        null (* altNameRefCell *),
                                        new Range.range() (* range *)),
                                      Ast.SynExpr.Paren( (* argExpr *)
                                        Ast.SynExpr.Ident( (* expr *)
                                          ex (* Item *)),
                                        new Range.range() (* leftParenRange *),
                                        range>.Some( (* rightParenRange *)
                                          new Range.range() (* Value *)),
                                        new Range.range() (* range *)),
                                      new Range.range() (* range *)),
                                    Ast.SynExpr.App( (* expr2 *)
                                      ExprAtomicFlag.Atomic (* exprAtomicFlag *),
                                      false (* isInfix *),
                                      Ast.SynExpr.Ident( (* funcExpr *)
                                        reraise (* Item *)),
                                      Ast.SynExpr.Const( (* argExpr *)
                                        Ast.SynConst.Unit( (* constant *)),
                                        new Range.range() (* range *)),
                                      new Range.range() (* range *)),
                                    new Range.range() (* range *)),
                                  new Range.range() (* range *),
                                  Ast.SequencePointInfoForTarget.SequencePointAtTarget( (* spTarget *)))],
                              new Range.range() (* Item4 *),
                              new Range.range() (* range *),
                              Ast.SequencePointInfoForTry.SequencePointAtTry( (* spTry *)
                                new Range.range() (* Item *)),
                              Ast.SequencePointInfoForWith.SequencePointAtWith( (* spWith *)
                                new Range.range() (* Item *))),
                            new Range.range() (* range *)),
                          new Range.range() (* range *)),
                        new Range.range() (* range *)),
                      new Range.range() (* range *)),
                    new Range.range() (* range *)),
                  new Range.range() (* lhsRange *),
                  Ast.SequencePointInfoForBinding.NoSequencePointAtLetBinding( (* spBind *)))],
              new Range.range() (* Item3 *))],
          Ast.PreXmlDoc.PreXmlDocEmpty( (* xmlDoc *)),
          [ (* attributes *)],
          null (* access *),
          new Range.range() (* range *))],
      ( (* Item7 *)
        System.Boolean (* [0] *),
        System.Boolean (* [1] *))))
