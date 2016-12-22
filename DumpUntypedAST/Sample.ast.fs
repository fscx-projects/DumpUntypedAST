// AST dumped by DumpUntypedAST [Thu, 22 Dec 2016 06:01:14 GMT]

open System
open Microsoft.FSharp.Compiler
open Microsoft.FSharp.Compiler.Ast
open Microsoft.FSharp.Compiler.SourceCodeServices

// namespace FSharp.Expandable.Compiler
// 
// [<System.AttributeUsage(System.AttributeTargets.Method)>]
// type AspectTargetAttribute() =
//   inherit System.Attribute()
// 
// namespace Sample
// 
// open FSharp.Expandable.Compiler
// 
// module SampleModule =
// 
//     let output1 (a: int, b: string, c: double) =
//       System.Console.WriteLine("output1: {0}:{1}:{2}", a, b, c)
// 
//     let output2 (a: int) (b: string) (c: double) =
//       System.Console.WriteLine("output2: {0}:{1}:{2}", a, b, c)
// 
//     [<AspectTarget>]
//     let sample() =
//       output1 (123, "ABC", 456.789)
//       output2 123 "ABC" 456.789
// 

// ImplFile
//   (ParsedImplFileInput
//      ("D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs",false,
//       QualifiedNameOfFile Sample,[],[],
//       [SynModuleOrNamespace
//          ([FSharp; Expandable; Compiler],false,false,
//           [Types
//              ([TypeDefn
//                  (ComponentInfo
//                     ([{TypeName =
//                         LongIdentWithDots
//                           ([System; AttributeUsage],
//                            [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (3,8--3,9) IsSynthetic=false]);
//                        ArgExpr =
//                         Paren
//                           (LongIdent
//                              (false,
//                               LongIdentWithDots
//                                 ([System; AttributeTargets; Method],
//                                  [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (3,30--3,31) IsSynthetic=false;
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (3,47--3,48) IsSynthetic=false]),
//                               null,
//                               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (3,24--3,54) IsSynthetic=false),
//                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (3,23--3,24) IsSynthetic=false,
//                            Some
//                              D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (3,54--3,55) IsSynthetic=false,
//                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (3,23--3,55) IsSynthetic=false);
//                        Target = null;
//                        AppliesToGetterAndSetter = false;
//                        Range =
//                         D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (3,2--3,23) IsSynthetic=false;}],
//                      [],[],[AspectTargetAttribute],
//                      PreXmlDoc
//                        (Microsoft.FSharp.Compiler.Range+pos,
//                         Microsoft.FSharp.Compiler.Ast+XmlDocCollector),false,
//                      null,
//                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,5--4,26) IsSynthetic=false),
//                   ObjectModel
//                     (TyconUnspecified,
//                      [ImplicitCtor
//                         (null,[],[],null,
//                          D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,5--4,26) IsSynthetic=false);
//                       ImplicitInherit
//                         (LongIdent
//                            (LongIdentWithDots
//                               ([System; Attribute],
//                                [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,16--5,17) IsSynthetic=false])),
//                          Const
//                            (Unit,
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,26--5,28) IsSynthetic=false),
//                          null,
//                          D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,2--5,28) IsSynthetic=false)],
//                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,2--5,28) IsSynthetic=false),
//                   [],
//                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,5--5,28) IsSynthetic=false)],
//               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,0--5,28) IsSynthetic=false)],
//           PreXmlDoc
//             (Microsoft.FSharp.Compiler.Range+pos,
//              Microsoft.FSharp.Compiler.Ast+XmlDocCollector),[],null,
//           D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (3,0--7,0) IsSynthetic=false);
//        SynModuleOrNamespace
//          ([Sample],false,false,
//           [Open
//              (LongIdentWithDots
//                 ([FSharp; Expandable; Compiler],
//                  [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (9,11--9,12) IsSynthetic=false;
//                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (9,22--9,23) IsSynthetic=false]),
//               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (9,5--9,31) IsSynthetic=false);
//            NestedModule
//              (ComponentInfo
//                 ([],[],[],[SampleModule],
//                  PreXmlDoc
//                    (Microsoft.FSharp.Compiler.Range+pos,
//                     Microsoft.FSharp.Compiler.Ast+XmlDocCollector),false,null,
//                  D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (11,0--11,19) IsSynthetic=false),
//               false,
//               [Let
//                  (false,
//                   [Binding
//                      (null,NormalBinding,false,false,[],
//                       PreXmlDoc
//                         (Microsoft.FSharp.Compiler.Range+pos,
//                          Microsoft.FSharp.Compiler.Ast+XmlDocCollector),
//                       SynValData
//                         (null,
//                          SynValInfo
//                            ([[SynArgInfo ([],false,Some a);
//                               SynArgInfo ([],false,Some b);
//                               SynArgInfo ([],false,Some c)]],
//                             SynArgInfo ([],false,null)),null),
//                       LongIdent
//                         (LongIdentWithDots ([output1],[]),null,null,
//                          Pats
//                            [Paren
//                               (Tuple
//                                  ([Typed
//                                      (Named
//                                         (Wild
//                                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (13,17--13,18) IsSynthetic=false,
//                                          a,false,null,
//                                          D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (13,17--13,18) IsSynthetic=false),
//                                       LongIdent (LongIdentWithDots ([int],[])),
//                                       D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (13,17--13,23) IsSynthetic=false);
//                                    Typed
//                                      (Named
//                                         (Wild
//                                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (13,25--13,26) IsSynthetic=false,
//                                          b,false,null,
//                                          D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (13,25--13,26) IsSynthetic=false),
//                                       LongIdent
//                                         (LongIdentWithDots ([string],[])),
//                                       D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (13,25--13,34) IsSynthetic=false);
//                                    Typed
//                                      (Named
//                                         (Wild
//                                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (13,36--13,37) IsSynthetic=false,
//                                          c,false,null,
//                                          D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (13,36--13,37) IsSynthetic=false),
//                                       LongIdent
//                                         (LongIdentWithDots ([double],[])),
//                                       D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (13,36--13,45) IsSynthetic=false)],
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (13,17--13,45) IsSynthetic=false),
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (13,16--13,46) IsSynthetic=false)],
//                          null,
//                          D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (13,8--13,46) IsSynthetic=false),
//                       null,
//                       App
//                         (Atomic,false,
//                          LongIdent
//                            (false,
//                             LongIdentWithDots
//                               ([System; Console; WriteLine],
//                                [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (14,12--14,13) IsSynthetic=false;
//                                 D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (14,20--14,21) IsSynthetic=false]),
//                             null,
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (14,6--14,30) IsSynthetic=false),
//                          Paren
//                            (Tuple
//                               ([Const
//                                   (String
//                                      ("output1: {0}:{1}:{2}",
//                                       D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (14,31--14,53) IsSynthetic=false),
//                                    D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (14,31--14,53) IsSynthetic=false);
//                                 Ident a; Ident b; Ident c],
//                                [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (14,53--14,54) IsSynthetic=false;
//                                 D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (14,56--14,57) IsSynthetic=false;
//                                 D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (14,59--14,60) IsSynthetic=false],
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (14,31--14,62) IsSynthetic=false),
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (14,30--14,31) IsSynthetic=false,
//                             Some
//                               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (14,62--14,63) IsSynthetic=false,
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (14,30--14,63) IsSynthetic=false),
//                          D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (14,6--14,63) IsSynthetic=false),
//                       D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (13,8--13,46) IsSynthetic=false,
//                       SequencePointAtBinding
//                         D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (13,4--14,63) IsSynthetic=false)],
//                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (13,4--14,63) IsSynthetic=false);
//                Let
//                  (false,
//                   [Binding
//                      (null,NormalBinding,false,false,[],
//                       PreXmlDoc
//                         (Microsoft.FSharp.Compiler.Range+pos,
//                          Microsoft.FSharp.Compiler.Ast+XmlDocCollector),
//                       SynValData
//                         (null,
//                          SynValInfo
//                            ([[SynArgInfo ([],false,Some a)];
//                              [SynArgInfo ([],false,Some b)];
//                              [SynArgInfo ([],false,Some c)]],
//                             SynArgInfo ([],false,null)),null),
//                       LongIdent
//                         (LongIdentWithDots ([output2],[]),null,null,
//                          Pats
//                            [Paren
//                               (Typed
//                                  (Named
//                                     (Wild
//                                        D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,17--16,18) IsSynthetic=false,
//                                      a,false,null,
//                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,17--16,18) IsSynthetic=false),
//                                   LongIdent (LongIdentWithDots ([int],[])),
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,17--16,23) IsSynthetic=false),
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,16--16,24) IsSynthetic=false);
//                             Paren
//                               (Typed
//                                  (Named
//                                     (Wild
//                                        D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,26--16,27) IsSynthetic=false,
//                                      b,false,null,
//                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,26--16,27) IsSynthetic=false),
//                                   LongIdent (LongIdentWithDots ([string],[])),
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,26--16,35) IsSynthetic=false),
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,25--16,36) IsSynthetic=false);
//                             Paren
//                               (Typed
//                                  (Named
//                                     (Wild
//                                        D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,38--16,39) IsSynthetic=false,
//                                      c,false,null,
//                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,38--16,39) IsSynthetic=false),
//                                   LongIdent (LongIdentWithDots ([double],[])),
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,38--16,47) IsSynthetic=false),
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,37--16,48) IsSynthetic=false)],
//                          null,
//                          D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,8--16,48) IsSynthetic=false),
//                       null,
//                       App
//                         (Atomic,false,
//                          LongIdent
//                            (false,
//                             LongIdentWithDots
//                               ([System; Console; WriteLine],
//                                [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (17,12--17,13) IsSynthetic=false;
//                                 D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (17,20--17,21) IsSynthetic=false]),
//                             null,
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (17,6--17,30) IsSynthetic=false),
//                          Paren
//                            (Tuple
//                               ([Const
//                                   (String
//                                      ("output2: {0}:{1}:{2}",
//                                       D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (17,31--17,53) IsSynthetic=false),
//                                    D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (17,31--17,53) IsSynthetic=false);
//                                 Ident a; Ident b; Ident c],
//                                [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (17,53--17,54) IsSynthetic=false;
//                                 D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (17,56--17,57) IsSynthetic=false;
//                                 D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (17,59--17,60) IsSynthetic=false],
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (17,31--17,62) IsSynthetic=false),
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (17,30--17,31) IsSynthetic=false,
//                             Some
//                               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (17,62--17,63) IsSynthetic=false,
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (17,30--17,63) IsSynthetic=false),
//                          D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (17,6--17,63) IsSynthetic=false),
//                       D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,8--16,48) IsSynthetic=false,
//                       SequencePointAtBinding
//                         D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,4--17,63) IsSynthetic=false)],
//                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (16,4--17,63) IsSynthetic=false);
//                Let
//                  (false,
//                   [Binding
//                      (null,NormalBinding,false,false,
//                       [{TypeName = LongIdentWithDots ([AspectTarget],[]);
//                         ArgExpr =
//                          Const
//                            (Unit,
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (19,6--19,18) IsSynthetic=false);
//                         Target = null;
//                         AppliesToGetterAndSetter = false;
//                         Range =
//                          D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (19,6--19,18) IsSynthetic=false;}],
//                       PreXmlDoc
//                         (Microsoft.FSharp.Compiler.Range+pos,
//                          Microsoft.FSharp.Compiler.Ast+XmlDocCollector),
//                       SynValData
//                         (null,SynValInfo ([[]],SynArgInfo ([],false,null)),null),
//                       LongIdent
//                         (LongIdentWithDots ([sample],[]),null,null,
//                          Pats
//                            [Paren
//                               (Const
//                                  (Unit,
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (20,14--20,16) IsSynthetic=false),
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (20,14--20,16) IsSynthetic=false)],
//                          null,
//                          D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (20,8--20,16) IsSynthetic=false),
//                       null,
//                       Sequential
//                         (SequencePointsAtSeq,true,
//                          App
//                            (NonAtomic,false,Ident output1,
//                             Paren
//                               (Tuple
//                                  ([Const
//                                      (Int32 123,
//                                       D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (21,15--21,18) IsSynthetic=false);
//                                    Const
//                                      (String
//                                         ("ABC",
//                                          D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (21,20--21,25) IsSynthetic=false),
//                                       D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (21,20--21,25) IsSynthetic=false);
//                                    Const
//                                      (Double 456.789,
//                                       D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (21,27--21,34) IsSynthetic=false)],
//                                   [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (21,18--21,19) IsSynthetic=false;
//                                    D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (21,25--21,26) IsSynthetic=false],
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (21,15--21,34) IsSynthetic=false),
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (21,14--21,15) IsSynthetic=false,
//                                Some
//                                  D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (21,34--21,35) IsSynthetic=false,
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (21,14--21,35) IsSynthetic=false),
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (21,6--21,35) IsSynthetic=false),
//                          App
//                            (NonAtomic,false,
//                             App
//                               (NonAtomic,false,
//                                App
//                                  (NonAtomic,false,Ident output2,
//                                   Const
//                                     (Int32 123,
//                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (22,14--22,17) IsSynthetic=false),
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (22,6--22,17) IsSynthetic=false),
//                                Const
//                                  (String
//                                     ("ABC",
//                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (22,18--22,23) IsSynthetic=false),
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (22,18--22,23) IsSynthetic=false),
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (22,6--22,23) IsSynthetic=false),
//                             Const
//                               (Double 456.789,
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (22,24--22,31) IsSynthetic=false),
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (22,6--22,31) IsSynthetic=false),
//                          D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (21,6--22,31) IsSynthetic=false),
//                       D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (20,8--20,16) IsSynthetic=false,
//                       NoSequencePointAtLetBinding)],
//                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (20,4--22,31) IsSynthetic=false)],
//               false,
//               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (11,0--22,31) IsSynthetic=false)],
//           PreXmlDoc
//             (Microsoft.FSharp.Compiler.Range+pos,
//              Microsoft.FSharp.Compiler.Ast+XmlDocCollector),[],null,
//           D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (9,0--23,0) IsSynthetic=false)],
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
            FSharp (* [0] *);
            Expandable (* [1] *);
            Compiler (* [2] *)],
          false (* isRec *),
          false (* isModule *),
          [ (* decls *)
            Ast.SynModuleDecl.Types( (* [0] *)
              [ (* Item1 *)
                Ast.SynTypeDefn.TypeDefn( (* [0] *)
                  Ast.SynComponentInfo.ComponentInfo( (* Item1 *)
                    [ (* attributes *)
                      { (* [0] *)
                        Ast.LongIdentWithDots.LongIdentWithDots( (* TypeName *)
                          [ (* id *)
                            System (* [0] *);
                            AttributeUsage (* [1] *)],
                          [ (* dotms *)]);
                        Ast.SynExpr.Paren( (* ArgExpr *)
                          Ast.SynExpr.LongIdent( (* expr *)
                            false (* isOptional *),
                            Ast.LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                              [ (* id *)
                                System (* [0] *);
                                AttributeTargets (* [1] *);
                                Method (* [2] *)],
                              [ (* dotms *)]),
                            null (* altNameRefCell *)),
                          range>.Some( (* rightParenRange *)));
                        null (* Target *);
                        false (* AppliesToGetterAndSetter *)}],
                    [ (* typeParams *)],
                    [ (* constraints *)],
                    [ (* Item4 *)
                      AspectTargetAttribute (* [0] *)],
                    Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                      Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                    false (* preferPostfix *),
                    null (* accessiblity *)),
                  Ast.SynTypeDefnRepr.ObjectModel( (* Item2 *)
                    Ast.SynTypeDefnKind.TyconUnspecified( (* Item1 *)),
                    [ (* members *)
                      Ast.SynMemberDefn.ImplicitCtor( (* [0] *)
                        null (* accessiblity *),
                        [ (* attributes *)],
                        [ (* ctorArgs *)],
                        null (* selfIdentifier *));
                      Ast.SynMemberDefn.ImplicitInherit( (* [1] *)
                        Ast.SynType.LongIdent( (* inheritType *)
                          Ast.LongIdentWithDots.LongIdentWithDots( (* Item *)
                            [ (* id *)
                              System (* [0] *);
                              Attribute (* [1] *)],
                            [ (* dotms *)])),
                        Ast.SynExpr.Const( (* inheritArgs *)
                          Ast.SynConst.Unit( (* constant *))),
                        null (* inheritAlias *))]),
                  [ (* members *)])])],
          Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
            Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
          [ (* attributes *)],
          null (* access *));
        Ast.SynModuleOrNamespace.SynModuleOrNamespace( (* [1] *)
          [ (* id *)
            Sample (* [0] *)],
          false (* isRec *),
          false (* isModule *),
          [ (* decls *)
            Ast.SynModuleDecl.Open( (* [0] *)
              Ast.LongIdentWithDots.LongIdentWithDots( (* Item1 *)
                [ (* id *)
                  FSharp (* [0] *);
                  Expandable (* [1] *);
                  Compiler (* [2] *)],
                [ (* dotms *)]));
            Ast.SynModuleDecl.NestedModule( (* [1] *)
              Ast.SynComponentInfo.ComponentInfo( (* Item1 *)
                [ (* attributes *)],
                [ (* typeParams *)],
                [ (* constraints *)],
                [ (* Item4 *)
                  SampleModule (* [0] *)],
                Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                  Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                false (* preferPostfix *),
                null (* accessiblity *)),
              false (* isRec *),
              [ (* Item3 *)
                Ast.SynModuleDecl.Let( (* [0] *)
                  false (* Item1 *),
                  [ (* Item2 *)
                    Ast.SynBinding.Binding( (* [0] *)
                      null (* access *),
                      Ast.SynBindingKind.NormalBinding( (* bindingKind *)),
                      false (* mustInline *),
                      false (* isMutable *),
                      [ (* attributes *)],
                      Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                        Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                      Ast.SynValData.SynValData( (* Item7 *)
                        null (* Item1 *),
                        Ast.SynValInfo.SynValInfo( (* Item2 *)
                          [ (* Item1 *)
                            [ (* [0] *)
                              Ast.SynArgInfo.SynArgInfo( (* [0] *)
                                [ (* attributes *)],
                                false (* optional *),
                                Ident>.Some( (* id *)
                                  a (* Value *)));
                              Ast.SynArgInfo.SynArgInfo( (* [1] *)
                                [ (* attributes *)],
                                false (* optional *),
                                Ident>.Some( (* id *)
                                  b (* Value *)));
                              Ast.SynArgInfo.SynArgInfo( (* [2] *)
                                [ (* attributes *)],
                                false (* optional *),
                                Ident>.Some( (* id *)
                                  c (* Value *)))]],
                          Ast.SynArgInfo.SynArgInfo( (* Item2 *)
                            [ (* attributes *)],
                            false (* optional *),
                            null (* id *))),
                        null (* Item3 *)),
                      Ast.SynPat.LongIdent( (* headPat *)
                        Ast.LongIdentWithDots.LongIdentWithDots( (* dotId *)
                          [ (* id *)
                            output1 (* [0] *)],
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
                                      Ast.SynPat.Wild( (* Item1 *)),
                                      a (* id *),
                                      false (* isThisVar *),
                                      null (* accessiblity *)),
                                    Ast.SynType.LongIdent( (* typeName *)
                                      Ast.LongIdentWithDots.LongIdentWithDots( (* Item *)
                                        [ (* id *)
                                          int (* [0] *)],
                                        [ (* dotms *)])));
                                  Ast.SynPat.Typed( (* [1] *)
                                    Ast.SynPat.Named( (* Item1 *)
                                      Ast.SynPat.Wild( (* Item1 *)),
                                      b (* id *),
                                      false (* isThisVar *),
                                      null (* accessiblity *)),
                                    Ast.SynType.LongIdent( (* typeName *)
                                      Ast.LongIdentWithDots.LongIdentWithDots( (* Item *)
                                        [ (* id *)
                                          string (* [0] *)],
                                        [ (* dotms *)])));
                                  Ast.SynPat.Typed( (* [2] *)
                                    Ast.SynPat.Named( (* Item1 *)
                                      Ast.SynPat.Wild( (* Item1 *)),
                                      c (* id *),
                                      false (* isThisVar *),
                                      null (* accessiblity *)),
                                    Ast.SynType.LongIdent( (* typeName *)
                                      Ast.LongIdentWithDots.LongIdentWithDots( (* Item *)
                                        [ (* id *)
                                          double (* [0] *)],
                                        [ (* dotms *)])))]))]),
                        null (* Item5 *)),
                      null (* Item9 *),
                      Ast.SynExpr.App( (* expr *)
                        ExprAtomicFlag.Atomic (* exprAtomicFlag *),
                        false (* isInfix *),
                        Ast.SynExpr.LongIdent( (* funcExpr *)
                          false (* isOptional *),
                          Ast.LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                            [ (* id *)
                              System (* [0] *);
                              Console (* [1] *);
                              WriteLine (* [2] *)],
                            [ (* dotms *)]),
                          null (* altNameRefCell *)),
                        Ast.SynExpr.Paren( (* argExpr *)
                          Ast.SynExpr.Tuple( (* expr *)
                            [ (* exprs *)
                              Ast.SynExpr.Const( (* [0] *)
                                Ast.SynConst.String( (* constant *)
                                  "output1: {0}:{1}:{2}" (* text *)));
                              Ast.SynExpr.Ident( (* [1] *)
                                a (* Item *));
                              Ast.SynExpr.Ident( (* [2] *)
                                b (* Item *));
                              Ast.SynExpr.Ident( (* [3] *)
                                c (* Item *))],
                            [ (* commaRanges *)]),
                          range>.Some( (* rightParenRange *)))),
                      Ast.SequencePointInfoForBinding.SequencePointAtBinding( (* spBind *)))]);
                Ast.SynModuleDecl.Let( (* [1] *)
                  false (* Item1 *),
                  [ (* Item2 *)
                    Ast.SynBinding.Binding( (* [0] *)
                      null (* access *),
                      Ast.SynBindingKind.NormalBinding( (* bindingKind *)),
                      false (* mustInline *),
                      false (* isMutable *),
                      [ (* attributes *)],
                      Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                        Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                      Ast.SynValData.SynValData( (* Item7 *)
                        null (* Item1 *),
                        Ast.SynValInfo.SynValInfo( (* Item2 *)
                          [ (* Item1 *)
                            [ (* [0] *)
                              Ast.SynArgInfo.SynArgInfo( (* [0] *)
                                [ (* attributes *)],
                                false (* optional *),
                                Ident>.Some( (* id *)
                                  a (* Value *)))];
                            [ (* [1] *)
                              Ast.SynArgInfo.SynArgInfo( (* [0] *)
                                [ (* attributes *)],
                                false (* optional *),
                                Ident>.Some( (* id *)
                                  b (* Value *)))];
                            [ (* [2] *)
                              Ast.SynArgInfo.SynArgInfo( (* [0] *)
                                [ (* attributes *)],
                                false (* optional *),
                                Ident>.Some( (* id *)
                                  c (* Value *)))]],
                          Ast.SynArgInfo.SynArgInfo( (* Item2 *)
                            [ (* attributes *)],
                            false (* optional *),
                            null (* id *))),
                        null (* Item3 *)),
                      Ast.SynPat.LongIdent( (* headPat *)
                        Ast.LongIdentWithDots.LongIdentWithDots( (* dotId *)
                          [ (* id *)
                            output2 (* [0] *)],
                          [ (* dotms *)]),
                        null (* Item2 *),
                        null (* Item3 *),
                        Ast.SynConstructorArgs.Pats( (* Item4 *)
                          [ (* Item *)
                            Ast.SynPat.Paren( (* [0] *)
                              Ast.SynPat.Typed( (* Item1 *)
                                Ast.SynPat.Named( (* Item1 *)
                                  Ast.SynPat.Wild( (* Item1 *)),
                                  a (* id *),
                                  false (* isThisVar *),
                                  null (* accessiblity *)),
                                Ast.SynType.LongIdent( (* typeName *)
                                  Ast.LongIdentWithDots.LongIdentWithDots( (* Item *)
                                    [ (* id *)
                                      int (* [0] *)],
                                    [ (* dotms *)]))));
                            Ast.SynPat.Paren( (* [1] *)
                              Ast.SynPat.Typed( (* Item1 *)
                                Ast.SynPat.Named( (* Item1 *)
                                  Ast.SynPat.Wild( (* Item1 *)),
                                  b (* id *),
                                  false (* isThisVar *),
                                  null (* accessiblity *)),
                                Ast.SynType.LongIdent( (* typeName *)
                                  Ast.LongIdentWithDots.LongIdentWithDots( (* Item *)
                                    [ (* id *)
                                      string (* [0] *)],
                                    [ (* dotms *)]))));
                            Ast.SynPat.Paren( (* [2] *)
                              Ast.SynPat.Typed( (* Item1 *)
                                Ast.SynPat.Named( (* Item1 *)
                                  Ast.SynPat.Wild( (* Item1 *)),
                                  c (* id *),
                                  false (* isThisVar *),
                                  null (* accessiblity *)),
                                Ast.SynType.LongIdent( (* typeName *)
                                  Ast.LongIdentWithDots.LongIdentWithDots( (* Item *)
                                    [ (* id *)
                                      double (* [0] *)],
                                    [ (* dotms *)]))))]),
                        null (* Item5 *)),
                      null (* Item9 *),
                      Ast.SynExpr.App( (* expr *)
                        ExprAtomicFlag.Atomic (* exprAtomicFlag *),
                        false (* isInfix *),
                        Ast.SynExpr.LongIdent( (* funcExpr *)
                          false (* isOptional *),
                          Ast.LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                            [ (* id *)
                              System (* [0] *);
                              Console (* [1] *);
                              WriteLine (* [2] *)],
                            [ (* dotms *)]),
                          null (* altNameRefCell *)),
                        Ast.SynExpr.Paren( (* argExpr *)
                          Ast.SynExpr.Tuple( (* expr *)
                            [ (* exprs *)
                              Ast.SynExpr.Const( (* [0] *)
                                Ast.SynConst.String( (* constant *)
                                  "output2: {0}:{1}:{2}" (* text *)));
                              Ast.SynExpr.Ident( (* [1] *)
                                a (* Item *));
                              Ast.SynExpr.Ident( (* [2] *)
                                b (* Item *));
                              Ast.SynExpr.Ident( (* [3] *)
                                c (* Item *))],
                            [ (* commaRanges *)]),
                          range>.Some( (* rightParenRange *)))),
                      Ast.SequencePointInfoForBinding.SequencePointAtBinding( (* spBind *)))]);
                Ast.SynModuleDecl.Let( (* [2] *)
                  false (* Item1 *),
                  [ (* Item2 *)
                    Ast.SynBinding.Binding( (* [0] *)
                      null (* access *),
                      Ast.SynBindingKind.NormalBinding( (* bindingKind *)),
                      false (* mustInline *),
                      false (* isMutable *),
                      [ (* attributes *)
                        { (* [0] *)
                          Ast.LongIdentWithDots.LongIdentWithDots( (* TypeName *)
                            [ (* id *)
                              AspectTarget (* [0] *)],
                            [ (* dotms *)]);
                          Ast.SynExpr.Const( (* ArgExpr *)
                            Ast.SynConst.Unit( (* constant *)));
                          null (* Target *);
                          false (* AppliesToGetterAndSetter *)}],
                      Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                        Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                      Ast.SynValData.SynValData( (* Item7 *)
                        null (* Item1 *),
                        Ast.SynValInfo.SynValInfo( (* Item2 *)
                          [ (* Item1 *)
                            [ (* [0] *)]],
                          Ast.SynArgInfo.SynArgInfo( (* Item2 *)
                            [ (* attributes *)],
                            false (* optional *),
                            null (* id *))),
                        null (* Item3 *)),
                      Ast.SynPat.LongIdent( (* headPat *)
                        Ast.LongIdentWithDots.LongIdentWithDots( (* dotId *)
                          [ (* id *)
                            sample (* [0] *)],
                          [ (* dotms *)]),
                        null (* Item2 *),
                        null (* Item3 *),
                        Ast.SynConstructorArgs.Pats( (* Item4 *)
                          [ (* Item *)
                            Ast.SynPat.Paren( (* [0] *)
                              Ast.SynPat.Const( (* Item1 *)
                                Ast.SynConst.Unit( (* constant *))))]),
                        null (* Item5 *)),
                      null (* Item9 *),
                      Ast.SynExpr.Sequential( (* expr *)
                        Ast.SequencePointInfoForSeq.SequencePointsAtSeq( (* spSeq *)),
                        true (* isTrueSeq *),
                        Ast.SynExpr.App( (* expr1 *)
                          ExprAtomicFlag.NonAtomic (* exprAtomicFlag *),
                          false (* isInfix *),
                          Ast.SynExpr.Ident( (* funcExpr *)
                            output1 (* Item *)),
                          Ast.SynExpr.Paren( (* argExpr *)
                            Ast.SynExpr.Tuple( (* expr *)
                              [ (* exprs *)
                                Ast.SynExpr.Const( (* [0] *)
                                  Ast.SynConst.Int32( (* constant *)
                                    123 (* Item *)));
                                Ast.SynExpr.Const( (* [1] *)
                                  Ast.SynConst.String( (* constant *)
                                    "ABC" (* text *)));
                                Ast.SynExpr.Const( (* [2] *)
                                  Ast.SynConst.Double( (* constant *)
                                    456.789 (* Item *)))],
                              [ (* commaRanges *)]),
                            range>.Some( (* rightParenRange *)))),
                        Ast.SynExpr.App( (* expr2 *)
                          ExprAtomicFlag.NonAtomic (* exprAtomicFlag *),
                          false (* isInfix *),
                          Ast.SynExpr.App( (* funcExpr *)
                            ExprAtomicFlag.NonAtomic (* exprAtomicFlag *),
                            false (* isInfix *),
                            Ast.SynExpr.App( (* funcExpr *)
                              ExprAtomicFlag.NonAtomic (* exprAtomicFlag *),
                              false (* isInfix *),
                              Ast.SynExpr.Ident( (* funcExpr *)
                                output2 (* Item *)),
                              Ast.SynExpr.Const( (* argExpr *)
                                Ast.SynConst.Int32( (* constant *)
                                  123 (* Item *)))),
                            Ast.SynExpr.Const( (* argExpr *)
                              Ast.SynConst.String( (* constant *)
                                "ABC" (* text *)))),
                          Ast.SynExpr.Const( (* argExpr *)
                            Ast.SynConst.Double( (* constant *)
                              456.789 (* Item *))))),
                      Ast.SequencePointInfoForBinding.NoSequencePointAtLetBinding( (* spBind *)))])],
              false (* Item4 *))],
          Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
            Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
          [ (* attributes *)],
          null (* access *))],
      ( (* Item7 *)
        System.Boolean (* [0] *),
        System.Boolean (* [1] *))))
