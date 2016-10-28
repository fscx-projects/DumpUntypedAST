// AST dumped by DumpUntypedAST [Fri, 28 Oct 2016 04:54:03 GMT]

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
//     context.Leave(System.String.Format("ABC", 123, 456, 789))
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
//                                                   ([Const
//                                                       (String
//                                                          ("ABC",
//                                                           D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,39--25,44) IsSynthetic=false),
//                                                        D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,39--25,44) IsSynthetic=false);
//                                                     Const
//                                                       (Int32 123,
//                                                        D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,46--25,49) IsSynthetic=false);
//                                                     Const
//                                                       (Int32 456,
//                                                        D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,51--25,54) IsSynthetic=false);
//                                                     Const
//                                                       (Int32 789,
//                                                        D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,56--25,59) IsSynthetic=false)],
//                                                    [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,44--25,45) IsSynthetic=false;
//                                                     D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,49--25,50) IsSynthetic=false;
//                                                     D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,54--25,55) IsSynthetic=false],
//                                                    D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,39--25,59) IsSynthetic=false),
//                                                 D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,38--25,39) IsSynthetic=false,
//                                                 Some
//                                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,59--25,60) IsSynthetic=false,
//                                                 D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,38--25,60) IsSynthetic=false),
//                                              D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,18--25,60) IsSynthetic=false),
//                                           D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,17--25,18) IsSynthetic=false,
//                                           Some
//                                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,60--25,61) IsSynthetic=false,
//                                           D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,17--25,61) IsSynthetic=false),
//                                        D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (25,4--25,61) IsSynthetic=false),
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
  ParsedInput.ImplFile(
    ParsedImplFileInput.ParsedImplFileInput( (* Item *)
      "D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs",
      false,
      QualifiedNameOfFile.QualifiedNameOfFile( (* Item3 *)
        Sample (* Item *)),
      [ (* Item4 *)],
      [ (* Item5 *)],
      [ (* Item6 *)
        SynModuleOrNamespace.SynModuleOrNamespace(
          [ (* id *)
            Sample],
          false,
          true,
          [ (* decls *)
            SynModuleDecl.Open(
              LongIdentWithDots.LongIdentWithDots( (* Item1 *)
                [ (* id *)
                  System],
                [ (* dotms *)]),
              new Microsoft.FSharp.Compiler.Range.range());
            SynModuleDecl.Types(
              [ (* Item1 *)
                SynTypeDefn.TypeDefn(
                  SynComponentInfo.ComponentInfo( (* Item1 *)
                    [ (* attributes *)],
                    [ (* typeParams *)],
                    [ (* constraints *)],
                    [ (* Item4 *)
                      AspectContext],
                    PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                      new Microsoft.FSharp.Compiler.Range.pos(),
                      Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                    false,
                    null (* accessiblity *),
                    new Microsoft.FSharp.Compiler.Range.range()),
                  SynTypeDefnRepr.ObjectModel( (* Item2 *)
                    SynTypeDefnKind.TyconUnspecified( (* Item1 *)),
                    [ (* members *)
                      SynMemberDefn.ImplicitCtor(
                        null (* accessiblity *),
                        [ (* attributes *)],
                        [ (* ctorArgs *)],
                        null (* selfIdentifier *),
                        new Microsoft.FSharp.Compiler.Range.range());
                      SynMemberDefn.Member(
                        SynBinding.Binding( (* memberDefn *)
                          null (* access *),
                          SynBindingKind.NormalBinding( (* bindingKind *)),
                          false,
                          false,
                          [ (* attributes *)],
                          PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                            new Microsoft.FSharp.Compiler.Range.pos(),
                            Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                          SynValData.SynValData( (* Item7 *)
                            Option<MemberFlags>.Some( (* Item1 *)
                              { (* Value *)
                                true;
                                false;
                                false;
                                false;
                                MemberKind.Member( (* MemberKind *))}),
                            SynValInfo.SynValInfo( (* Item2 *)
                              [ (* Item1 *)
                                [
                                  SynArgInfo.SynArgInfo(
                                    [ (* attributes *)],
                                    false,
                                    null (* id *))];
                                [
                                  SynArgInfo.SynArgInfo(
                                    [ (* attributes *)],
                                    false,
                                    Option<Ident>.Some( (* id *)
                                      result (* Value *)))]],
                              SynArgInfo.SynArgInfo( (* Item2 *)
                                [ (* attributes *)],
                                false,
                                null (* id *))),
                            null (* Item3 *)),
                          SynPat.LongIdent( (* headPat *)
                            LongIdentWithDots.LongIdentWithDots( (* dotId *)
                              [ (* id *)
                                __;
                                Leave],
                              [ (* dotms *)
                                new Microsoft.FSharp.Compiler.Range.range()]),
                            null (* Item2 *),
                            null (* Item3 *),
                            SynConstructorArgs.Pats( (* Item4 *)
                              [ (* Item *)
                                SynPat.Paren(
                                  SynPat.Typed( (* Item1 *)
                                    SynPat.Named( (* Item1 *)
                                      SynPat.Wild( (* Item1 *)
                                        new Microsoft.FSharp.Compiler.Range.range()),
                                      result (* id *),
                                      false,
                                      null (* accessiblity *),
                                      new Microsoft.FSharp.Compiler.Range.range()),
                                    SynType.Var( (* typeName *)
                                      SynTypar.Typar( (* Item1 *)
                                        T (* id *),
                                        TyparStaticReq.NoStaticReq( (* staticReq *)),
                                        false),
                                      new Microsoft.FSharp.Compiler.Range.range()),
                                    new Microsoft.FSharp.Compiler.Range.range()),
                                  new Microsoft.FSharp.Compiler.Range.range())]),
                            null (* Item5 *),
                            new Microsoft.FSharp.Compiler.Range.range()),
                          null (* Item9 *),
                          SynExpr.Sequential( (* expr *)
                            SequencePointInfoForSeq.SequencePointsAtSeq( (* spSeq *)),
                            true,
                            SynExpr.App( (* expr1 *)
                              ExprAtomicFlag.Atomic,
                              false,
                              SynExpr.LongIdent( (* funcExpr *)
                                false,
                                LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                                  [ (* id *)
                                    Console;
                                    WriteLine],
                                  [ (* dotms *)
                                    new Microsoft.FSharp.Compiler.Range.range()]),
                                null (* altNameRefCell *),
                                new Microsoft.FSharp.Compiler.Range.range()),
                              SynExpr.Paren( (* argExpr *)
                                SynExpr.Tuple( (* expr *)
                                  [ (* exprs *)
                                    SynExpr.Const(
                                      SynConst.String( (* constant *)
                                        "Result={0}",
                                        new Microsoft.FSharp.Compiler.Range.range()),
                                      new Microsoft.FSharp.Compiler.Range.range());
                                    SynExpr.Ident(
                                      result (* Item *))],
                                  [ (* commaRanges *)
                                    new Microsoft.FSharp.Compiler.Range.range()],
                                  new Microsoft.FSharp.Compiler.Range.range()),
                                new Microsoft.FSharp.Compiler.Range.range(),
                                Option<range>.Some( (* rightParenRange *)
                                  new Microsoft.FSharp.Compiler.Range.range()),
                                new Microsoft.FSharp.Compiler.Range.range()),
                              new Microsoft.FSharp.Compiler.Range.range()),
                            SynExpr.Ident( (* expr2 *)
                              result (* Item *)),
                            new Microsoft.FSharp.Compiler.Range.range()),
                          new Microsoft.FSharp.Compiler.Range.range(),
                          SequencePointInfoForBinding.NoSequencePointAtInvisibleBinding( (* spBind *))),
                        new Microsoft.FSharp.Compiler.Range.range());
                      SynMemberDefn.Member(
                        SynBinding.Binding( (* memberDefn *)
                          null (* access *),
                          SynBindingKind.NormalBinding( (* bindingKind *)),
                          false,
                          false,
                          [ (* attributes *)],
                          PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                            new Microsoft.FSharp.Compiler.Range.pos(),
                            Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                          SynValData.SynValData( (* Item7 *)
                            Option<MemberFlags>.Some( (* Item1 *)
                              { (* Value *)
                                true;
                                false;
                                false;
                                false;
                                MemberKind.Member( (* MemberKind *))}),
                            SynValInfo.SynValInfo( (* Item2 *)
                              [ (* Item1 *)
                                [
                                  SynArgInfo.SynArgInfo(
                                    [ (* attributes *)],
                                    false,
                                    null (* id *))];
                                [
                                  SynArgInfo.SynArgInfo(
                                    [ (* attributes *)],
                                    false,
                                    Option<Ident>.Some( (* id *)
                                      ex (* Value *)))]],
                              SynArgInfo.SynArgInfo( (* Item2 *)
                                [ (* attributes *)],
                                false,
                                null (* id *))),
                            null (* Item3 *)),
                          SynPat.LongIdent( (* headPat *)
                            LongIdentWithDots.LongIdentWithDots( (* dotId *)
                              [ (* id *)
                                __;
                                Caught],
                              [ (* dotms *)
                                new Microsoft.FSharp.Compiler.Range.range()]),
                            null (* Item2 *),
                            null (* Item3 *),
                            SynConstructorArgs.Pats( (* Item4 *)
                              [ (* Item *)
                                SynPat.Paren(
                                  SynPat.Typed( (* Item1 *)
                                    SynPat.Named( (* Item1 *)
                                      SynPat.Wild( (* Item1 *)
                                        new Microsoft.FSharp.Compiler.Range.range()),
                                      ex (* id *),
                                      false,
                                      null (* accessiblity *),
                                      new Microsoft.FSharp.Compiler.Range.range()),
                                    SynType.LongIdent( (* typeName *)
                                      LongIdentWithDots.LongIdentWithDots( (* Item *)
                                        [ (* id *)
                                          exn],
                                        [ (* dotms *)])),
                                    new Microsoft.FSharp.Compiler.Range.range()),
                                  new Microsoft.FSharp.Compiler.Range.range())]),
                            null (* Item5 *),
                            new Microsoft.FSharp.Compiler.Range.range()),
                          null (* Item9 *),
                          SynExpr.App( (* expr *)
                            ExprAtomicFlag.Atomic,
                            false,
                            SynExpr.LongIdent( (* funcExpr *)
                              false,
                              LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                                [ (* id *)
                                  Console;
                                  WriteLine],
                                [ (* dotms *)
                                  new Microsoft.FSharp.Compiler.Range.range()]),
                              null (* altNameRefCell *),
                              new Microsoft.FSharp.Compiler.Range.range()),
                            SynExpr.Paren( (* argExpr *)
                              SynExpr.Tuple( (* expr *)
                                [ (* exprs *)
                                  SynExpr.Const(
                                    SynConst.String( (* constant *)
                                      "Exception={0}",
                                      new Microsoft.FSharp.Compiler.Range.range()),
                                    new Microsoft.FSharp.Compiler.Range.range());
                                  SynExpr.Ident(
                                    ex (* Item *))],
                                [ (* commaRanges *)
                                  new Microsoft.FSharp.Compiler.Range.range()],
                                new Microsoft.FSharp.Compiler.Range.range()),
                              new Microsoft.FSharp.Compiler.Range.range(),
                              Option<range>.Some( (* rightParenRange *)
                                new Microsoft.FSharp.Compiler.Range.range()),
                              new Microsoft.FSharp.Compiler.Range.range()),
                            new Microsoft.FSharp.Compiler.Range.range()),
                          new Microsoft.FSharp.Compiler.Range.range(),
                          SequencePointInfoForBinding.NoSequencePointAtInvisibleBinding( (* spBind *))),
                        new Microsoft.FSharp.Compiler.Range.range())],
                    new Microsoft.FSharp.Compiler.Range.range()),
                  [ (* members *)],
                  new Microsoft.FSharp.Compiler.Range.range())],
              new Microsoft.FSharp.Compiler.Range.range());
            SynModuleDecl.Types(
              [ (* Item1 *)
                SynTypeDefn.TypeDefn(
                  SynComponentInfo.ComponentInfo( (* Item1 *)
                    [ (* attributes *)],
                    [ (* typeParams *)],
                    [ (* constraints *)],
                    [ (* Item4 *)
                      Aspect],
                    PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                      new Microsoft.FSharp.Compiler.Range.pos(),
                      Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                    false,
                    null (* accessiblity *),
                    new Microsoft.FSharp.Compiler.Range.range()),
                  SynTypeDefnRepr.ObjectModel( (* Item2 *)
                    SynTypeDefnKind.TyconUnspecified( (* Item1 *)),
                    [ (* members *)
                      SynMemberDefn.ImplicitCtor(
                        null (* accessiblity *),
                        [ (* attributes *)],
                        [ (* ctorArgs *)],
                        null (* selfIdentifier *),
                        new Microsoft.FSharp.Compiler.Range.range());
                      SynMemberDefn.Member(
                        SynBinding.Binding( (* memberDefn *)
                          null (* access *),
                          SynBindingKind.NormalBinding( (* bindingKind *)),
                          false,
                          false,
                          [ (* attributes *)],
                          PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                            new Microsoft.FSharp.Compiler.Range.pos(),
                            Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                          SynValData.SynValData( (* Item7 *)
                            Option<MemberFlags>.Some( (* Item1 *)
                              { (* Value *)
                                false;
                                false;
                                false;
                                false;
                                MemberKind.Member( (* MemberKind *))}),
                            SynValInfo.SynValInfo( (* Item2 *)
                              [ (* Item1 *)
                                [
                                  SynArgInfo.SynArgInfo(
                                    [ (* attributes *)],
                                    false,
                                    Option<Ident>.Some( (* id *)
                                      name (* Value *)));
                                  SynArgInfo.SynArgInfo(
                                    [ (* attributes *)],
                                    false,
                                    Option<Ident>.Some( (* id *)
                                      line (* Value *)));
                                  SynArgInfo.SynArgInfo(
                                    [ (* attributes *)],
                                    false,
                                    Option<Ident>.Some( (* id *)
                                      column (* Value *)));
                                  SynArgInfo.SynArgInfo(
                                    [ (* attributes *)],
                                    false,
                                    Option<Ident>.Some( (* id *)
                                      args (* Value *)))]],
                              SynArgInfo.SynArgInfo( (* Item2 *)
                                [ (* attributes *)],
                                false,
                                null (* id *))),
                            null (* Item3 *)),
                          SynPat.LongIdent( (* headPat *)
                            LongIdentWithDots.LongIdentWithDots( (* dotId *)
                              [ (* id *)
                                Enter],
                              [ (* dotms *)]),
                            null (* Item2 *),
                            null (* Item3 *),
                            SynConstructorArgs.Pats( (* Item4 *)
                              [ (* Item *)
                                SynPat.Paren(
                                  SynPat.Tuple( (* Item1 *)
                                    [ (* Item1 *)
                                      SynPat.Typed(
                                        SynPat.Named( (* Item1 *)
                                          SynPat.Wild( (* Item1 *)
                                            new Microsoft.FSharp.Compiler.Range.range()),
                                          name (* id *),
                                          false,
                                          null (* accessiblity *),
                                          new Microsoft.FSharp.Compiler.Range.range()),
                                        SynType.LongIdent( (* typeName *)
                                          LongIdentWithDots.LongIdentWithDots( (* Item *)
                                            [ (* id *)
                                              string],
                                            [ (* dotms *)])),
                                        new Microsoft.FSharp.Compiler.Range.range());
                                      SynPat.Typed(
                                        SynPat.Named( (* Item1 *)
                                          SynPat.Wild( (* Item1 *)
                                            new Microsoft.FSharp.Compiler.Range.range()),
                                          line (* id *),
                                          false,
                                          null (* accessiblity *),
                                          new Microsoft.FSharp.Compiler.Range.range()),
                                        SynType.LongIdent( (* typeName *)
                                          LongIdentWithDots.LongIdentWithDots( (* Item *)
                                            [ (* id *)
                                              int],
                                            [ (* dotms *)])),
                                        new Microsoft.FSharp.Compiler.Range.range());
                                      SynPat.Typed(
                                        SynPat.Named( (* Item1 *)
                                          SynPat.Wild( (* Item1 *)
                                            new Microsoft.FSharp.Compiler.Range.range()),
                                          column (* id *),
                                          false,
                                          null (* accessiblity *),
                                          new Microsoft.FSharp.Compiler.Range.range()),
                                        SynType.LongIdent( (* typeName *)
                                          LongIdentWithDots.LongIdentWithDots( (* Item *)
                                            [ (* id *)
                                              int],
                                            [ (* dotms *)])),
                                        new Microsoft.FSharp.Compiler.Range.range());
                                      SynPat.Typed(
                                        SynPat.Named( (* Item1 *)
                                          SynPat.Wild( (* Item1 *)
                                            new Microsoft.FSharp.Compiler.Range.range()),
                                          args (* id *),
                                          false,
                                          null (* accessiblity *),
                                          new Microsoft.FSharp.Compiler.Range.range()),
                                        SynType.Array( (* typeName *)
                                          1,
                                          SynType.LongIdent( (* elementType *)
                                            LongIdentWithDots.LongIdentWithDots( (* Item *)
                                              [ (* id *)
                                                obj],
                                              [ (* dotms *)])),
                                          new Microsoft.FSharp.Compiler.Range.range()),
                                        new Microsoft.FSharp.Compiler.Range.range())],
                                    new Microsoft.FSharp.Compiler.Range.range()),
                                  new Microsoft.FSharp.Compiler.Range.range())]),
                            null (* Item5 *),
                            new Microsoft.FSharp.Compiler.Range.range()),
                          null (* Item9 *),
                          SynExpr.Sequential( (* expr *)
                            SequencePointInfoForSeq.SequencePointsAtSeq( (* spSeq *)),
                            true,
                            SynExpr.App( (* expr1 *)
                              ExprAtomicFlag.Atomic,
                              false,
                              SynExpr.LongIdent( (* funcExpr *)
                                false,
                                LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                                  [ (* id *)
                                    Console;
                                    WriteLine],
                                  [ (* dotms *)
                                    new Microsoft.FSharp.Compiler.Range.range()]),
                                null (* altNameRefCell *),
                                new Microsoft.FSharp.Compiler.Range.range()),
                              SynExpr.Paren( (* argExpr *)
                                SynExpr.Tuple( (* expr *)
                                  [ (* exprs *)
                                    SynExpr.Const(
                                      SynConst.String( (* constant *)
                                        "{0}({1},{2}): {3}",
                                        new Microsoft.FSharp.Compiler.Range.range()),
                                      new Microsoft.FSharp.Compiler.Range.range());
                                    SynExpr.Ident(
                                      name (* Item *));
                                    SynExpr.Ident(
                                      line (* Item *));
                                    SynExpr.Ident(
                                      column (* Item *));
                                    SynExpr.App(
                                      ExprAtomicFlag.Atomic,
                                      false,
                                      SynExpr.LongIdent( (* funcExpr *)
                                        false,
                                        LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                                          [ (* id *)
                                            String;
                                            Join],
                                          [ (* dotms *)
                                            new Microsoft.FSharp.Compiler.Range.range()]),
                                        null (* altNameRefCell *),
                                        new Microsoft.FSharp.Compiler.Range.range()),
                                      SynExpr.Paren( (* argExpr *)
                                        SynExpr.Tuple( (* expr *)
                                          [ (* exprs *)
                                            SynExpr.Const(
                                              SynConst.String( (* constant *)
                                                ",",
                                                new Microsoft.FSharp.Compiler.Range.range()),
                                              new Microsoft.FSharp.Compiler.Range.range());
                                            SynExpr.Ident(
                                              args (* Item *))],
                                          [ (* commaRanges *)
                                            new Microsoft.FSharp.Compiler.Range.range()],
                                          new Microsoft.FSharp.Compiler.Range.range()),
                                        new Microsoft.FSharp.Compiler.Range.range(),
                                        Option<range>.Some( (* rightParenRange *)
                                          new Microsoft.FSharp.Compiler.Range.range()),
                                        new Microsoft.FSharp.Compiler.Range.range()),
                                      new Microsoft.FSharp.Compiler.Range.range())],
                                  [ (* commaRanges *)
                                    new Microsoft.FSharp.Compiler.Range.range();
                                    new Microsoft.FSharp.Compiler.Range.range();
                                    new Microsoft.FSharp.Compiler.Range.range();
                                    new Microsoft.FSharp.Compiler.Range.range()],
                                  new Microsoft.FSharp.Compiler.Range.range()),
                                new Microsoft.FSharp.Compiler.Range.range(),
                                Option<range>.Some( (* rightParenRange *)
                                  new Microsoft.FSharp.Compiler.Range.range()),
                                new Microsoft.FSharp.Compiler.Range.range()),
                              new Microsoft.FSharp.Compiler.Range.range()),
                            SynExpr.New( (* expr2 *)
                              false,
                              SynType.LongIdent( (* typeName *)
                                LongIdentWithDots.LongIdentWithDots( (* Item *)
                                  [ (* id *)
                                    AspectContext],
                                  [ (* dotms *)])),
                              SynExpr.Const( (* expr *)
                                SynConst.Unit( (* constant *)),
                                new Microsoft.FSharp.Compiler.Range.range()),
                              new Microsoft.FSharp.Compiler.Range.range()),
                            new Microsoft.FSharp.Compiler.Range.range()),
                          new Microsoft.FSharp.Compiler.Range.range(),
                          SequencePointInfoForBinding.NoSequencePointAtInvisibleBinding( (* spBind *))),
                        new Microsoft.FSharp.Compiler.Range.range())],
                    new Microsoft.FSharp.Compiler.Range.range()),
                  [ (* members *)],
                  new Microsoft.FSharp.Compiler.Range.range())],
              new Microsoft.FSharp.Compiler.Range.range());
            SynModuleDecl.Let(
              false,
              [ (* Item2 *)
                SynBinding.Binding(
                  null (* access *),
                  SynBindingKind.NormalBinding( (* bindingKind *)),
                  false,
                  false,
                  [ (* attributes *)],
                  PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                    new Microsoft.FSharp.Compiler.Range.pos(),
                    Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                  SynValData.SynValData( (* Item7 *)
                    null (* Item1 *),
                    SynValInfo.SynValInfo( (* Item2 *)
                      [ (* Item1 *)],
                      SynArgInfo.SynArgInfo( (* Item2 *)
                        [ (* attributes *)],
                        false,
                        null (* id *))),
                    null (* Item3 *)),
                  SynPat.Named( (* headPat *)
                    SynPat.Wild( (* Item1 *)
                      new Microsoft.FSharp.Compiler.Range.range()),
                    original (* id *),
                    false,
                    null (* accessiblity *),
                    new Microsoft.FSharp.Compiler.Range.range()),
                  null (* Item9 *),
                  SynExpr.App( (* expr *)
                    ExprAtomicFlag.Atomic,
                    false,
                    SynExpr.LongIdent( (* funcExpr *)
                      false,
                      LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                        [ (* id *)
                          System;
                          String;
                          Format],
                        [ (* dotms *)
                          new Microsoft.FSharp.Compiler.Range.range();
                          new Microsoft.FSharp.Compiler.Range.range()]),
                      null (* altNameRefCell *),
                      new Microsoft.FSharp.Compiler.Range.range()),
                    SynExpr.Paren( (* argExpr *)
                      SynExpr.Tuple( (* expr *)
                        [ (* exprs *)
                          SynExpr.Const(
                            SynConst.String( (* constant *)
                              "ABC",
                              new Microsoft.FSharp.Compiler.Range.range()),
                            new Microsoft.FSharp.Compiler.Range.range());
                          SynExpr.Const(
                            SynConst.Int32( (* constant *)
                              123),
                            new Microsoft.FSharp.Compiler.Range.range());
                          SynExpr.Const(
                            SynConst.Int32( (* constant *)
                              456),
                            new Microsoft.FSharp.Compiler.Range.range());
                          SynExpr.Const(
                            SynConst.Int32( (* constant *)
                              789),
                            new Microsoft.FSharp.Compiler.Range.range())],
                        [ (* commaRanges *)
                          new Microsoft.FSharp.Compiler.Range.range();
                          new Microsoft.FSharp.Compiler.Range.range();
                          new Microsoft.FSharp.Compiler.Range.range()],
                        new Microsoft.FSharp.Compiler.Range.range()),
                      new Microsoft.FSharp.Compiler.Range.range(),
                      Option<range>.Some( (* rightParenRange *)
                        new Microsoft.FSharp.Compiler.Range.range()),
                      new Microsoft.FSharp.Compiler.Range.range()),
                    new Microsoft.FSharp.Compiler.Range.range()),
                  new Microsoft.FSharp.Compiler.Range.range(),
                  SequencePointInfoForBinding.SequencePointAtBinding( (* spBind *)
                    new Microsoft.FSharp.Compiler.Range.range()))],
              new Microsoft.FSharp.Compiler.Range.range());
            SynModuleDecl.Let(
              false,
              [ (* Item2 *)
                SynBinding.Binding(
                  null (* access *),
                  SynBindingKind.NormalBinding( (* bindingKind *)),
                  false,
                  false,
                  [ (* attributes *)],
                  PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                    new Microsoft.FSharp.Compiler.Range.pos(),
                    Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                  SynValData.SynValData( (* Item7 *)
                    null (* Item1 *),
                    SynValInfo.SynValInfo( (* Item2 *)
                      [ (* Item1 *)],
                      SynArgInfo.SynArgInfo( (* Item2 *)
                        [ (* attributes *)],
                        false,
                        null (* id *))),
                    null (* Item3 *)),
                  SynPat.Named( (* headPat *)
                    SynPat.Wild( (* Item1 *)
                      new Microsoft.FSharp.Compiler.Range.range()),
                    filtered (* id *),
                    false,
                    null (* accessiblity *),
                    new Microsoft.FSharp.Compiler.Range.range()),
                  null (* Item9 *),
                  SynExpr.LetOrUse( (* expr *)
                    false,
                    false,
                    [ (* bindings *)
                      SynBinding.Binding(
                        null (* access *),
                        SynBindingKind.NormalBinding( (* bindingKind *)),
                        false,
                        false,
                        [ (* attributes *)],
                        PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                          new Microsoft.FSharp.Compiler.Range.pos(),
                          Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                        SynValData.SynValData( (* Item7 *)
                          null (* Item1 *),
                          SynValInfo.SynValInfo( (* Item2 *)
                            [ (* Item1 *)],
                            SynArgInfo.SynArgInfo( (* Item2 *)
                              [ (* attributes *)],
                              false,
                              null (* id *))),
                          null (* Item3 *)),
                        SynPat.Named( (* headPat *)
                          SynPat.Wild( (* Item1 *)
                            new Microsoft.FSharp.Compiler.Range.range()),
                          arg0 (* id *),
                          false,
                          null (* accessiblity *),
                          new Microsoft.FSharp.Compiler.Range.range()),
                        null (* Item9 *),
                        SynExpr.Const( (* expr *)
                          SynConst.String( (* constant *)
                            "ABC",
                            new Microsoft.FSharp.Compiler.Range.range()),
                          new Microsoft.FSharp.Compiler.Range.range()),
                        new Microsoft.FSharp.Compiler.Range.range(),
                        SequencePointInfoForBinding.SequencePointAtBinding( (* spBind *)
                          new Microsoft.FSharp.Compiler.Range.range()))],
                    SynExpr.LetOrUse( (* exprBody *)
                      false,
                      false,
                      [ (* bindings *)
                        SynBinding.Binding(
                          null (* access *),
                          SynBindingKind.NormalBinding( (* bindingKind *)),
                          false,
                          false,
                          [ (* attributes *)],
                          PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                            new Microsoft.FSharp.Compiler.Range.pos(),
                            Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                          SynValData.SynValData( (* Item7 *)
                            null (* Item1 *),
                            SynValInfo.SynValInfo( (* Item2 *)
                              [ (* Item1 *)],
                              SynArgInfo.SynArgInfo( (* Item2 *)
                                [ (* attributes *)],
                                false,
                                null (* id *))),
                            null (* Item3 *)),
                          SynPat.Named( (* headPat *)
                            SynPat.Wild( (* Item1 *)
                              new Microsoft.FSharp.Compiler.Range.range()),
                            arg1 (* id *),
                            false,
                            null (* accessiblity *),
                            new Microsoft.FSharp.Compiler.Range.range()),
                          null (* Item9 *),
                          SynExpr.Const( (* expr *)
                            SynConst.Int32( (* constant *)
                              123),
                            new Microsoft.FSharp.Compiler.Range.range()),
                          new Microsoft.FSharp.Compiler.Range.range(),
                          SequencePointInfoForBinding.SequencePointAtBinding( (* spBind *)
                            new Microsoft.FSharp.Compiler.Range.range()))],
                      SynExpr.LetOrUse( (* exprBody *)
                        false,
                        false,
                        [ (* bindings *)
                          SynBinding.Binding(
                            null (* access *),
                            SynBindingKind.NormalBinding( (* bindingKind *)),
                            false,
                            false,
                            [ (* attributes *)],
                            PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                              new Microsoft.FSharp.Compiler.Range.pos(),
                              Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                            SynValData.SynValData( (* Item7 *)
                              null (* Item1 *),
                              SynValInfo.SynValInfo( (* Item2 *)
                                [ (* Item1 *)],
                                SynArgInfo.SynArgInfo( (* Item2 *)
                                  [ (* attributes *)],
                                  false,
                                  null (* id *))),
                              null (* Item3 *)),
                            SynPat.Named( (* headPat *)
                              SynPat.Wild( (* Item1 *)
                                new Microsoft.FSharp.Compiler.Range.range()),
                              arg2 (* id *),
                              false,
                              null (* accessiblity *),
                              new Microsoft.FSharp.Compiler.Range.range()),
                            null (* Item9 *),
                            SynExpr.Const( (* expr *)
                              SynConst.Int32( (* constant *)
                                456),
                              new Microsoft.FSharp.Compiler.Range.range()),
                            new Microsoft.FSharp.Compiler.Range.range(),
                            SequencePointInfoForBinding.SequencePointAtBinding( (* spBind *)
                              new Microsoft.FSharp.Compiler.Range.range()))],
                        SynExpr.LetOrUse( (* exprBody *)
                          false,
                          false,
                          [ (* bindings *)
                            SynBinding.Binding(
                              null (* access *),
                              SynBindingKind.NormalBinding( (* bindingKind *)),
                              false,
                              false,
                              [ (* attributes *)],
                              PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                                new Microsoft.FSharp.Compiler.Range.pos(),
                                Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                              SynValData.SynValData( (* Item7 *)
                                null (* Item1 *),
                                SynValInfo.SynValInfo( (* Item2 *)
                                  [ (* Item1 *)],
                                  SynArgInfo.SynArgInfo( (* Item2 *)
                                    [ (* attributes *)],
                                    false,
                                    null (* id *))),
                                null (* Item3 *)),
                              SynPat.Named( (* headPat *)
                                SynPat.Wild( (* Item1 *)
                                  new Microsoft.FSharp.Compiler.Range.range()),
                                arg3 (* id *),
                                false,
                                null (* accessiblity *),
                                new Microsoft.FSharp.Compiler.Range.range()),
                              null (* Item9 *),
                              SynExpr.Const( (* expr *)
                                SynConst.Int32( (* constant *)
                                  789),
                                new Microsoft.FSharp.Compiler.Range.range()),
                              new Microsoft.FSharp.Compiler.Range.range(),
                              SequencePointInfoForBinding.SequencePointAtBinding( (* spBind *)
                                new Microsoft.FSharp.Compiler.Range.range()))],
                          SynExpr.LetOrUse( (* exprBody *)
                            false,
                            false,
                            [ (* bindings *)
                              SynBinding.Binding(
                                null (* access *),
                                SynBindingKind.NormalBinding( (* bindingKind *)),
                                false,
                                false,
                                [ (* attributes *)],
                                PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                                  new Microsoft.FSharp.Compiler.Range.pos(),
                                  Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                                SynValData.SynValData( (* Item7 *)
                                  null (* Item1 *),
                                  SynValInfo.SynValInfo( (* Item2 *)
                                    [ (* Item1 *)],
                                    SynArgInfo.SynArgInfo( (* Item2 *)
                                      [ (* attributes *)],
                                      false,
                                      null (* id *))),
                                  null (* Item3 *)),
                                SynPat.Named( (* headPat *)
                                  SynPat.Wild( (* Item1 *)
                                    new Microsoft.FSharp.Compiler.Range.range()),
                                  context (* id *),
                                  false,
                                  null (* accessiblity *),
                                  new Microsoft.FSharp.Compiler.Range.range()),
                                null (* Item9 *),
                                SynExpr.App( (* expr *)
                                  ExprAtomicFlag.Atomic,
                                  false,
                                  SynExpr.LongIdent( (* funcExpr *)
                                    false,
                                    LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                                      [ (* id *)
                                        Aspect;
                                        Enter],
                                      [ (* dotms *)
                                        new Microsoft.FSharp.Compiler.Range.range()]),
                                    null (* altNameRefCell *),
                                    new Microsoft.FSharp.Compiler.Range.range()),
                                  SynExpr.Paren( (* argExpr *)
                                    SynExpr.Tuple( (* expr *)
                                      [ (* exprs *)
                                        SynExpr.Const(
                                          SynConst.String( (* constant *)
                                            "Sample.fs",
                                            new Microsoft.FSharp.Compiler.Range.range()),
                                          new Microsoft.FSharp.Compiler.Range.range());
                                        SynExpr.Const(
                                          SynConst.Int32( (* constant *)
                                            12),
                                          new Microsoft.FSharp.Compiler.Range.range());
                                        SynExpr.Const(
                                          SynConst.Int32( (* constant *)
                                            34),
                                          new Microsoft.FSharp.Compiler.Range.range());
                                        SynExpr.ArrayOrListOfSeqExpr(
                                          true,
                                          SynExpr.CompExpr( (* elements *)
                                            true,
                                            { (* isNotNakedRefCell *)
                                              true},
                                            SynExpr.Sequential( (* expr *)
                                              SequencePointInfoForSeq.SequencePointsAtSeq( (* spSeq *)),
                                              true,
                                              SynExpr.Ident( (* expr1 *)
                                                arg0 (* Item *)),
                                              SynExpr.Sequential( (* expr2 *)
                                                SequencePointInfoForSeq.SequencePointsAtSeq( (* spSeq *)),
                                                true,
                                                SynExpr.Ident( (* expr1 *)
                                                  arg1 (* Item *)),
                                                SynExpr.Sequential( (* expr2 *)
                                                  SequencePointInfoForSeq.SequencePointsAtSeq( (* spSeq *)),
                                                  true,
                                                  SynExpr.Ident( (* expr1 *)
                                                    arg2 (* Item *)),
                                                  SynExpr.Ident( (* expr2 *)
                                                    arg3 (* Item *)),
                                                  new Microsoft.FSharp.Compiler.Range.range()),
                                                new Microsoft.FSharp.Compiler.Range.range()),
                                              new Microsoft.FSharp.Compiler.Range.range()),
                                            new Microsoft.FSharp.Compiler.Range.range()),
                                          new Microsoft.FSharp.Compiler.Range.range())],
                                      [ (* commaRanges *)
                                        new Microsoft.FSharp.Compiler.Range.range();
                                        new Microsoft.FSharp.Compiler.Range.range();
                                        new Microsoft.FSharp.Compiler.Range.range()],
                                      new Microsoft.FSharp.Compiler.Range.range()),
                                    new Microsoft.FSharp.Compiler.Range.range(),
                                    Option<range>.Some( (* rightParenRange *)
                                      new Microsoft.FSharp.Compiler.Range.range()),
                                    new Microsoft.FSharp.Compiler.Range.range()),
                                  new Microsoft.FSharp.Compiler.Range.range()),
                                new Microsoft.FSharp.Compiler.Range.range(),
                                SequencePointInfoForBinding.SequencePointAtBinding( (* spBind *)
                                  new Microsoft.FSharp.Compiler.Range.range()))],
                            SynExpr.TryWith( (* exprBody *)
                              SynExpr.App( (* tryExpr *)
                                ExprAtomicFlag.Atomic,
                                false,
                                SynExpr.LongIdent( (* funcExpr *)
                                  false,
                                  LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                                    [ (* id *)
                                      context;
                                      Leave],
                                    [ (* dotms *)
                                      new Microsoft.FSharp.Compiler.Range.range()]),
                                  null (* altNameRefCell *),
                                  new Microsoft.FSharp.Compiler.Range.range()),
                                SynExpr.Paren( (* argExpr *)
                                  SynExpr.App( (* expr *)
                                    ExprAtomicFlag.Atomic,
                                    false,
                                    SynExpr.LongIdent( (* funcExpr *)
                                      false,
                                      LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                                        [ (* id *)
                                          System;
                                          String;
                                          Format],
                                        [ (* dotms *)
                                          new Microsoft.FSharp.Compiler.Range.range();
                                          new Microsoft.FSharp.Compiler.Range.range()]),
                                      null (* altNameRefCell *),
                                      new Microsoft.FSharp.Compiler.Range.range()),
                                    SynExpr.Paren( (* argExpr *)
                                      SynExpr.Tuple( (* expr *)
                                        [ (* exprs *)
                                          SynExpr.Const(
                                            SynConst.String( (* constant *)
                                              "ABC",
                                              new Microsoft.FSharp.Compiler.Range.range()),
                                            new Microsoft.FSharp.Compiler.Range.range());
                                          SynExpr.Const(
                                            SynConst.Int32( (* constant *)
                                              123),
                                            new Microsoft.FSharp.Compiler.Range.range());
                                          SynExpr.Const(
                                            SynConst.Int32( (* constant *)
                                              456),
                                            new Microsoft.FSharp.Compiler.Range.range());
                                          SynExpr.Const(
                                            SynConst.Int32( (* constant *)
                                              789),
                                            new Microsoft.FSharp.Compiler.Range.range())],
                                        [ (* commaRanges *)
                                          new Microsoft.FSharp.Compiler.Range.range();
                                          new Microsoft.FSharp.Compiler.Range.range();
                                          new Microsoft.FSharp.Compiler.Range.range()],
                                        new Microsoft.FSharp.Compiler.Range.range()),
                                      new Microsoft.FSharp.Compiler.Range.range(),
                                      Option<range>.Some( (* rightParenRange *)
                                        new Microsoft.FSharp.Compiler.Range.range()),
                                      new Microsoft.FSharp.Compiler.Range.range()),
                                    new Microsoft.FSharp.Compiler.Range.range()),
                                  new Microsoft.FSharp.Compiler.Range.range(),
                                  Option<range>.Some( (* rightParenRange *)
                                    new Microsoft.FSharp.Compiler.Range.range()),
                                  new Microsoft.FSharp.Compiler.Range.range()),
                                new Microsoft.FSharp.Compiler.Range.range()),
                              new Microsoft.FSharp.Compiler.Range.range(),
                              [ (* Item3 *)
                                SynMatchClause.Clause(
                                  SynPat.Named( (* Item1 *)
                                    SynPat.Wild( (* Item1 *)
                                      new Microsoft.FSharp.Compiler.Range.range()),
                                    ex (* id *),
                                    false,
                                    null (* accessiblity *),
                                    new Microsoft.FSharp.Compiler.Range.range()),
                                  null (* Item2 *),
                                  SynExpr.Sequential( (* Item3 *)
                                    SequencePointInfoForSeq.SequencePointsAtSeq( (* spSeq *)),
                                    true,
                                    SynExpr.App( (* expr1 *)
                                      ExprAtomicFlag.Atomic,
                                      false,
                                      SynExpr.LongIdent( (* funcExpr *)
                                        false,
                                        LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                                          [ (* id *)
                                            context;
                                            Caught],
                                          [ (* dotms *)
                                            new Microsoft.FSharp.Compiler.Range.range()]),
                                        null (* altNameRefCell *),
                                        new Microsoft.FSharp.Compiler.Range.range()),
                                      SynExpr.Paren( (* argExpr *)
                                        SynExpr.Ident( (* expr *)
                                          ex (* Item *)),
                                        new Microsoft.FSharp.Compiler.Range.range(),
                                        Option<range>.Some( (* rightParenRange *)
                                          new Microsoft.FSharp.Compiler.Range.range()),
                                        new Microsoft.FSharp.Compiler.Range.range()),
                                      new Microsoft.FSharp.Compiler.Range.range()),
                                    SynExpr.App( (* expr2 *)
                                      ExprAtomicFlag.Atomic,
                                      false,
                                      SynExpr.Ident( (* funcExpr *)
                                        reraise (* Item *)),
                                      SynExpr.Const( (* argExpr *)
                                        SynConst.Unit( (* constant *)),
                                        new Microsoft.FSharp.Compiler.Range.range()),
                                      new Microsoft.FSharp.Compiler.Range.range()),
                                    new Microsoft.FSharp.Compiler.Range.range()),
                                  new Microsoft.FSharp.Compiler.Range.range(),
                                  SequencePointInfoForTarget.SequencePointAtTarget( (* spTarget *)))],
                              new Microsoft.FSharp.Compiler.Range.range(),
                              new Microsoft.FSharp.Compiler.Range.range(),
                              SequencePointInfoForTry.SequencePointAtTry( (* spTry *)
                                new Microsoft.FSharp.Compiler.Range.range()),
                              SequencePointInfoForWith.SequencePointAtWith( (* spWith *)
                                new Microsoft.FSharp.Compiler.Range.range())),
                            new Microsoft.FSharp.Compiler.Range.range()),
                          new Microsoft.FSharp.Compiler.Range.range()),
                        new Microsoft.FSharp.Compiler.Range.range()),
                      new Microsoft.FSharp.Compiler.Range.range()),
                    new Microsoft.FSharp.Compiler.Range.range()),
                  new Microsoft.FSharp.Compiler.Range.range(),
                  SequencePointInfoForBinding.NoSequencePointAtLetBinding( (* spBind *)))],
              new Microsoft.FSharp.Compiler.Range.range())],
          PreXmlDoc.PreXmlDocEmpty( (* xmlDoc *)),
          [ (* attributes *)],
          null (* access *),
          new Microsoft.FSharp.Compiler.Range.range())],
      ( (* Item7 *)
        true,
        false)))
