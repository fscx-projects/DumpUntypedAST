// AST dumped by DumpUntypedAST [Wed, 21 Dec 2016 01:16:12 GMT]

open System
open Microsoft.FSharp.Compiler
open Microsoft.FSharp.Compiler.Ast
open Microsoft.FSharp.Compiler.SourceCodeServices

// let output1 (a: int, b: string, c: double) =
//   System.Console.WriteLine("output1: {0}:{1}:{2}", a, b, c)
// 
// let output2 (a: int) (b: string) (c: double) =
//   System.Console.WriteLine("output2: {0}:{1}:{2}", a, b, c)
// 
// let sample() =
//   output1 (123, "ABC", 456.789)
//   output2 123 "ABC" 456.789
// 

// ImplFile
//   (ParsedImplFileInput
//      ("D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs",false,
//       QualifiedNameOfFile Sample,[],[],
//       [SynModuleOrNamespace
//          ([Sample],false,true,
//           [Let
//              (false,
//               [Binding
//                  (null,NormalBinding,false,false,[],
//                   PreXmlDoc
//                     (Microsoft.FSharp.Compiler.Range+pos,
//                      Microsoft.FSharp.Compiler.Ast+XmlDocCollector),
//                   SynValData
//                     (null,
//                      SynValInfo
//                        ([[SynArgInfo ([],false,Some a);
//                           SynArgInfo ([],false,Some b);
//                           SynArgInfo ([],false,Some c)]],
//                         SynArgInfo ([],false,null)),null),
//                   LongIdent
//                     (LongIdentWithDots ([output1],[]),null,null,
//                      Pats
//                        [Paren
//                           (Tuple
//                              ([Typed
//                                  (Named
//                                     (Wild
//                                        D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (1,13--1,14) IsSynthetic=false,
//                                      a,false,null,
//                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (1,13--1,14) IsSynthetic=false),
//                                   LongIdent (LongIdentWithDots ([int],[])),
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (1,13--1,19) IsSynthetic=false);
//                                Typed
//                                  (Named
//                                     (Wild
//                                        D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (1,21--1,22) IsSynthetic=false,
//                                      b,false,null,
//                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (1,21--1,22) IsSynthetic=false),
//                                   LongIdent (LongIdentWithDots ([string],[])),
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (1,21--1,30) IsSynthetic=false);
//                                Typed
//                                  (Named
//                                     (Wild
//                                        D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (1,32--1,33) IsSynthetic=false,
//                                      c,false,null,
//                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (1,32--1,33) IsSynthetic=false),
//                                   LongIdent (LongIdentWithDots ([double],[])),
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (1,32--1,41) IsSynthetic=false)],
//                               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (1,13--1,41) IsSynthetic=false),
//                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (1,12--1,42) IsSynthetic=false)],
//                      null,
//                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (1,4--1,42) IsSynthetic=false),
//                   null,
//                   App
//                     (Atomic,false,
//                      LongIdent
//                        (false,
//                         LongIdentWithDots
//                           ([System; Console; WriteLine],
//                            [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (2,8--2,9) IsSynthetic=false;
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (2,16--2,17) IsSynthetic=false]),
//                         null,
//                         D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (2,2--2,26) IsSynthetic=false),
//                      Paren
//                        (Tuple
//                           ([Const
//                               (String
//                                  ("output1: {0}:{1}:{2}",
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (2,27--2,49) IsSynthetic=false),
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (2,27--2,49) IsSynthetic=false);
//                             Ident a; Ident b; Ident c],
//                            [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (2,49--2,50) IsSynthetic=false;
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (2,52--2,53) IsSynthetic=false;
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (2,55--2,56) IsSynthetic=false],
//                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (2,27--2,58) IsSynthetic=false),
//                         D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (2,26--2,27) IsSynthetic=false,
//                         Some
//                           D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (2,58--2,59) IsSynthetic=false,
//                         D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (2,26--2,59) IsSynthetic=false),
//                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (2,2--2,59) IsSynthetic=false),
//                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (1,4--1,42) IsSynthetic=false,
//                   SequencePointAtBinding
//                     D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (1,0--2,59) IsSynthetic=false)],
//               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (1,0--2,59) IsSynthetic=false);
//            Let
//              (false,
//               [Binding
//                  (null,NormalBinding,false,false,[],
//                   PreXmlDoc
//                     (Microsoft.FSharp.Compiler.Range+pos,
//                      Microsoft.FSharp.Compiler.Ast+XmlDocCollector),
//                   SynValData
//                     (null,
//                      SynValInfo
//                        ([[SynArgInfo ([],false,Some a)];
//                          [SynArgInfo ([],false,Some b)];
//                          [SynArgInfo ([],false,Some c)]],
//                         SynArgInfo ([],false,null)),null),
//                   LongIdent
//                     (LongIdentWithDots ([output2],[]),null,null,
//                      Pats
//                        [Paren
//                           (Typed
//                              (Named
//                                 (Wild
//                                    D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,13--4,14) IsSynthetic=false,
//                                  a,false,null,
//                                  D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,13--4,14) IsSynthetic=false),
//                               LongIdent (LongIdentWithDots ([int],[])),
//                               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,13--4,19) IsSynthetic=false),
//                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,12--4,20) IsSynthetic=false);
//                         Paren
//                           (Typed
//                              (Named
//                                 (Wild
//                                    D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,22--4,23) IsSynthetic=false,
//                                  b,false,null,
//                                  D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,22--4,23) IsSynthetic=false),
//                               LongIdent (LongIdentWithDots ([string],[])),
//                               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,22--4,31) IsSynthetic=false),
//                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,21--4,32) IsSynthetic=false);
//                         Paren
//                           (Typed
//                              (Named
//                                 (Wild
//                                    D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,34--4,35) IsSynthetic=false,
//                                  c,false,null,
//                                  D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,34--4,35) IsSynthetic=false),
//                               LongIdent (LongIdentWithDots ([double],[])),
//                               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,34--4,43) IsSynthetic=false),
//                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,33--4,44) IsSynthetic=false)],
//                      null,
//                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,4--4,44) IsSynthetic=false),
//                   null,
//                   App
//                     (Atomic,false,
//                      LongIdent
//                        (false,
//                         LongIdentWithDots
//                           ([System; Console; WriteLine],
//                            [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,8--5,9) IsSynthetic=false;
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,16--5,17) IsSynthetic=false]),
//                         null,
//                         D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,2--5,26) IsSynthetic=false),
//                      Paren
//                        (Tuple
//                           ([Const
//                               (String
//                                  ("output2: {0}:{1}:{2}",
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,27--5,49) IsSynthetic=false),
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,27--5,49) IsSynthetic=false);
//                             Ident a; Ident b; Ident c],
//                            [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,49--5,50) IsSynthetic=false;
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,52--5,53) IsSynthetic=false;
//                             D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,55--5,56) IsSynthetic=false],
//                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,27--5,58) IsSynthetic=false),
//                         D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,26--5,27) IsSynthetic=false,
//                         Some
//                           D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,58--5,59) IsSynthetic=false,
//                         D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,26--5,59) IsSynthetic=false),
//                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (5,2--5,59) IsSynthetic=false),
//                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,4--4,44) IsSynthetic=false,
//                   SequencePointAtBinding
//                     D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,0--5,59) IsSynthetic=false)],
//               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (4,0--5,59) IsSynthetic=false);
//            Let
//              (false,
//               [Binding
//                  (null,NormalBinding,false,false,[],
//                   PreXmlDoc
//                     (Microsoft.FSharp.Compiler.Range+pos,
//                      Microsoft.FSharp.Compiler.Ast+XmlDocCollector),
//                   SynValData
//                     (null,SynValInfo ([[]],SynArgInfo ([],false,null)),null),
//                   LongIdent
//                     (LongIdentWithDots ([sample],[]),null,null,
//                      Pats
//                        [Paren
//                           (Const
//                              (Unit,
//                               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (7,10--7,12) IsSynthetic=false),
//                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (7,10--7,12) IsSynthetic=false)],
//                      null,
//                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (7,4--7,12) IsSynthetic=false),
//                   null,
//                   Sequential
//                     (SequencePointsAtSeq,true,
//                      App
//                        (NonAtomic,false,Ident output1,
//                         Paren
//                           (Tuple
//                              ([Const
//                                  (Int32 123,
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (8,11--8,14) IsSynthetic=false);
//                                Const
//                                  (String
//                                     ("ABC",
//                                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (8,16--8,21) IsSynthetic=false),
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (8,16--8,21) IsSynthetic=false);
//                                Const
//                                  (Double 456.789,
//                                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (8,23--8,30) IsSynthetic=false)],
//                               [D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (8,14--8,15) IsSynthetic=false;
//                                D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (8,21--8,22) IsSynthetic=false],
//                               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (8,11--8,30) IsSynthetic=false),
//                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (8,10--8,11) IsSynthetic=false,
//                            Some
//                              D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (8,30--8,31) IsSynthetic=false,
//                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (8,10--8,31) IsSynthetic=false),
//                         D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (8,2--8,31) IsSynthetic=false),
//                      App
//                        (NonAtomic,false,
//                         App
//                           (NonAtomic,false,
//                            App
//                              (NonAtomic,false,Ident output2,
//                               Const
//                                 (Int32 123,
//                                  D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (9,10--9,13) IsSynthetic=false),
//                               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (9,2--9,13) IsSynthetic=false),
//                            Const
//                              (String
//                                 ("ABC",
//                                  D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (9,14--9,19) IsSynthetic=false),
//                               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (9,14--9,19) IsSynthetic=false),
//                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (9,2--9,19) IsSynthetic=false),
//                         Const
//                           (Double 456.789,
//                            D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (9,20--9,27) IsSynthetic=false),
//                         D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (9,2--9,27) IsSynthetic=false),
//                      D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (8,2--9,27) IsSynthetic=false),
//                   D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (7,4--7,12) IsSynthetic=false,
//                   NoSequencePointAtLetBinding)],
//               D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (7,0--9,27) IsSynthetic=false)],
//           PreXmlDocEmpty,[],null,
//           D:\PROJECT\DumpUntypedAST\DumpUntypedAST\bin\Debug\Sample.fs (1,0--10,0) IsSynthetic=false)],
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
                    new Range.pos() (* Item1 *),
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
                                  Ast.SynPat.Wild( (* Item1 *)
                                    new Range.range() (* range *)),
                                  a (* id *),
                                  false (* isThisVar *),
                                  null (* accessiblity *),
                                  new Range.range() (* range *)),
                                Ast.SynType.LongIdent( (* typeName *)
                                  Ast.LongIdentWithDots.LongIdentWithDots( (* Item *)
                                    [ (* id *)
                                      int (* [0] *)],
                                    [ (* dotms *)])),
                                new Range.range() (* range *));
                              Ast.SynPat.Typed( (* [1] *)
                                Ast.SynPat.Named( (* Item1 *)
                                  Ast.SynPat.Wild( (* Item1 *)
                                    new Range.range() (* range *)),
                                  b (* id *),
                                  false (* isThisVar *),
                                  null (* accessiblity *),
                                  new Range.range() (* range *)),
                                Ast.SynType.LongIdent( (* typeName *)
                                  Ast.LongIdentWithDots.LongIdentWithDots( (* Item *)
                                    [ (* id *)
                                      string (* [0] *)],
                                    [ (* dotms *)])),
                                new Range.range() (* range *));
                              Ast.SynPat.Typed( (* [2] *)
                                Ast.SynPat.Named( (* Item1 *)
                                  Ast.SynPat.Wild( (* Item1 *)
                                    new Range.range() (* range *)),
                                  c (* id *),
                                  false (* isThisVar *),
                                  null (* accessiblity *),
                                  new Range.range() (* range *)),
                                Ast.SynType.LongIdent( (* typeName *)
                                  Ast.LongIdentWithDots.LongIdentWithDots( (* Item *)
                                    [ (* id *)
                                      double (* [0] *)],
                                    [ (* dotms *)])),
                                new Range.range() (* range *))],
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
                          System (* [0] *);
                          Console (* [1] *);
                          WriteLine (* [2] *)],
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
                              "output1: {0}:{1}:{2}" (* text *),
                              new Range.range() (* range *)),
                            new Range.range() (* range *));
                          Ast.SynExpr.Ident( (* [1] *)
                            a (* Item *));
                          Ast.SynExpr.Ident( (* [2] *)
                            b (* Item *));
                          Ast.SynExpr.Ident( (* [3] *)
                            c (* Item *))],
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
                    new Range.pos() (* Item1 *),
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
                              Ast.SynPat.Wild( (* Item1 *)
                                new Range.range() (* range *)),
                              a (* id *),
                              false (* isThisVar *),
                              null (* accessiblity *),
                              new Range.range() (* range *)),
                            Ast.SynType.LongIdent( (* typeName *)
                              Ast.LongIdentWithDots.LongIdentWithDots( (* Item *)
                                [ (* id *)
                                  int (* [0] *)],
                                [ (* dotms *)])),
                            new Range.range() (* range *)),
                          new Range.range() (* range *));
                        Ast.SynPat.Paren( (* [1] *)
                          Ast.SynPat.Typed( (* Item1 *)
                            Ast.SynPat.Named( (* Item1 *)
                              Ast.SynPat.Wild( (* Item1 *)
                                new Range.range() (* range *)),
                              b (* id *),
                              false (* isThisVar *),
                              null (* accessiblity *),
                              new Range.range() (* range *)),
                            Ast.SynType.LongIdent( (* typeName *)
                              Ast.LongIdentWithDots.LongIdentWithDots( (* Item *)
                                [ (* id *)
                                  string (* [0] *)],
                                [ (* dotms *)])),
                            new Range.range() (* range *)),
                          new Range.range() (* range *));
                        Ast.SynPat.Paren( (* [2] *)
                          Ast.SynPat.Typed( (* Item1 *)
                            Ast.SynPat.Named( (* Item1 *)
                              Ast.SynPat.Wild( (* Item1 *)
                                new Range.range() (* range *)),
                              c (* id *),
                              false (* isThisVar *),
                              null (* accessiblity *),
                              new Range.range() (* range *)),
                            Ast.SynType.LongIdent( (* typeName *)
                              Ast.LongIdentWithDots.LongIdentWithDots( (* Item *)
                                [ (* id *)
                                  double (* [0] *)],
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
                          System (* [0] *);
                          Console (* [1] *);
                          WriteLine (* [2] *)],
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
                              "output2: {0}:{1}:{2}" (* text *),
                              new Range.range() (* range *)),
                            new Range.range() (* range *));
                          Ast.SynExpr.Ident( (* [1] *)
                            a (* Item *));
                          Ast.SynExpr.Ident( (* [2] *)
                            b (* Item *));
                          Ast.SynExpr.Ident( (* [3] *)
                            c (* Item *))],
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
            Ast.SynModuleDecl.Let( (* [2] *)
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
                            Ast.SynConst.Unit( (* constant *)),
                            new Range.range() (* range *)),
                          new Range.range() (* range *))]),
                    null (* Item5 *),
                    new Range.range() (* range *)),
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
                                123 (* Item *)),
                              new Range.range() (* range *));
                            Ast.SynExpr.Const( (* [1] *)
                              Ast.SynConst.String( (* constant *)
                                "ABC" (* text *),
                                new Range.range() (* range *)),
                              new Range.range() (* range *));
                            Ast.SynExpr.Const( (* [2] *)
                              Ast.SynConst.Double( (* constant *)
                                456.789 (* Item *)),
                              new Range.range() (* range *))],
                          [ (* commaRanges *)
                            new Range.range() (* [0] *);
                            new Range.range() (* [1] *)],
                          new Range.range() (* range *)),
                        new Range.range() (* leftParenRange *),
                        range>.Some( (* rightParenRange *)
                          new Range.range() (* Value *)),
                        new Range.range() (* range *)),
                      new Range.range() (* range *)),
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
                              123 (* Item *)),
                            new Range.range() (* range *)),
                          new Range.range() (* range *)),
                        Ast.SynExpr.Const( (* argExpr *)
                          Ast.SynConst.String( (* constant *)
                            "ABC" (* text *),
                            new Range.range() (* range *)),
                          new Range.range() (* range *)),
                        new Range.range() (* range *)),
                      Ast.SynExpr.Const( (* argExpr *)
                        Ast.SynConst.Double( (* constant *)
                          456.789 (* Item *)),
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
