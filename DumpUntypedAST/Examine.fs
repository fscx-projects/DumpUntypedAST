

let original = 
  System.String.Format("ABC", 123, 456, 789)


Ast.SynModuleDecl.Let(
  false,
  [ (* Item2 *)
    Ast.SynBinding.Binding(
      null (* access *),
      Ast.SynBindingKind.NormalBinding( (* bindingKind *)),
      false,
      false,
      [ (* attributes *)],
      Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
        new Range.pos(),
        Microsoft.FSharp.Compiler).Ast+XmlDocCollector (* Item2 *)),
      Ast.SynValData.SynValData( (* Item7 *)
        null (* Item1 *),
        Ast.SynValInfo.SynValInfo( (* Item2 *)
          [ (* Item1 *)],
          Ast.SynArgInfo.SynArgInfo( (* Item2 *)
            [ (* attributes *)],
            false,
            null (* id *))),
        null (* Item3 *)),
      Ast.SynPat.Named( (* headPat *)
        Ast.SynPat.Wild( (* Item1 *)
          new Range.range()),
        original (* id *),
        false,
        null (* accessiblity *),
        new Range.range()),
      null (* Item9 *),
      Ast.SynExpr.App( (* expr *)
        ExprAtomicFlag.Atomic,
        false,
        Ast.SynExpr.LongIdent( (* funcExpr *)
          false,
          Ast.LongIdentWithDots.LongIdentWithDots( (* longIdent *)
            [ (* id *)
              System;
              String;
              Format],
            [ (* dotms *)
              new Range.range();
              new Range.range()]),
          null (* altNameRefCell *),
          new Range.range()),
        Ast.SynExpr.Paren( (* argExpr *)
          Ast.SynExpr.Tuple( (* expr *)
            [ (* exprs *)
              Ast.SynExpr.Const(
                Ast.SynConst.String( (* constant *)
                  "ABC",
                  new Range.range()),
                new Range.range());
              Ast.SynExpr.Const(
                Ast.SynConst.Int32( (* constant *)
                  123),
                new Range.range());
              Ast.SynExpr.Const(
                Ast.SynConst.Int32( (* constant *)
                  456),
                new Range.range());
              Ast.SynExpr.Const(
                Ast.SynConst.Int32( (* constant *)
                  789),
                new Range.range())],
            [ (* commaRanges *)
              new Range.range();
              new Range.range();
              new Range.range()],
            new Range.range()),
          new Range.range(),
          Option<Range.range>.Some( (* rightParenRange *)
            new Range.range()),
          new Range.range()),
        new Range.range()),
      new Range.range(),
      Ast.SequencePointInfoForBinding.SequencePointAtBinding( (* spBind *)
        new Range.range()))],
  new Range.range());


/////////////////////////////////////////////////////////////////////////////////////////


let filtered =
  let arg0 = "ABC"
  let arg1 = 123
  let arg2 = 456
  let arg3 = 789
  let context = Aspect.Enter("Sample.fs", 12, 34, [|arg0;arg1;arg2;arg3|])
  try
    context.Leave(System.String.Format("ABC", 123, 456, 789))
  with
  | ex ->
    context.Caught(ex)
    reraise()


Ast.SynModuleDecl.Let(
  false,
  [ (* Item2 *)
    Ast.SynBinding.Binding(
      null (* access *),
      Ast.SynBindingKind.NormalBinding( (* bindingKind *)),
      false,
      false,
      [ (* attributes *)],
      Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
        new Range.pos(),
        Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
      Ast.SynValData.SynValData( (* Item7 *)
        null (* Item1 *),
        Ast.SynValInfo.SynValInfo( (* Item2 *)
          [ (* Item1 *)],
          Ast.SynArgInfo.SynArgInfo( (* Item2 *)
            [ (* attributes *)],
            false,
            null (* id *))),
        null (* Item3 *)),
      Ast.SynPat.Named( (* headPat *)
        Ast.SynPat.Wild( (* Item1 *)
          new Range.range()),
        filtered (* id *),
        false,
        null (* accessiblity *),
        new Range.range()),
      null (* Item9 *),
      Ast.SynExpr.LetOrUse( (* expr *)
        false,
        false,
        [ (* bindings *)
          Ast.SynBinding.Binding(
            null (* access *),
            Ast.SynBindingKind.NormalBinding( (* bindingKind *)),
            false,
            false,
            [ (* attributes *)],
            Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
              new Range.pos(),
              Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
            Ast.SynValData.SynValData( (* Item7 *)
              null (* Item1 *),
              Ast.SynValInfo.SynValInfo( (* Item2 *)
                [ (* Item1 *)],
                Ast.SynArgInfo.SynArgInfo( (* Item2 *)
                  [ (* attributes *)],
                  false,
                  null (* id *))),
              null (* Item3 *)),
            Ast.SynPat.Named( (* headPat *)
              Ast.SynPat.Wild( (* Item1 *)
                new Range.range()),
              arg0 (* id *),
              false,
              null (* accessiblity *),
              new Range.range()),
            null (* Item9 *),
            Ast.SynExpr.Const( (* expr *)
              Ast.SynConst.String( (* constant *)
                "ABC",
                new Range.range()),
              new Range.range()),
            new Range.range(),
            Ast.SequencePointInfoForBinding.SequencePointAtBinding( (* spBind *)
              new Range.range()))],
        Ast.SynExpr.LetOrUse( (* exprBody *)
          false,
          false,
          [ (* bindings *)
            Ast.SynBinding.Binding(
              null (* access *),
              Ast.SynBindingKind.NormalBinding( (* bindingKind *)),
              false,
              false,
              [ (* attributes *)],
              Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                new Range.pos(),
                Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
              Ast.SynValData.SynValData( (* Item7 *)
                null (* Item1 *),
                Ast.SynValInfo.SynValInfo( (* Item2 *)
                  [ (* Item1 *)],
                  Ast.SynArgInfo.SynArgInfo( (* Item2 *)
                    [ (* attributes *)],
                    false,
                    null (* id *))),
                null (* Item3 *)),
              Ast.SynPat.Named( (* headPat *)
                Ast.SynPat.Wild( (* Item1 *)
                  new Range.range()),
                arg1 (* id *),
                false,
                null (* accessiblity *),
                new Range.range()),
              null (* Item9 *),
              Ast.SynExpr.Const( (* expr *)
                Ast.SynConst.Int32( (* constant *)
                  123),
                new Range.range()),
              new Range.range(),
              Ast.SequencePointInfoForBinding.SequencePointAtBinding( (* spBind *)
                new Range.range()))],
          Ast.SynExpr.LetOrUse( (* exprBody *)
            false,
            false,
            [ (* bindings *)
              Ast.SynBinding.Binding(
                null (* access *),
                Ast.SynBindingKind.NormalBinding( (* bindingKind *)),
                false,
                false,
                [ (* attributes *)],
                Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                  new Range.pos(),
                  Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                Ast.SynValData.SynValData( (* Item7 *)
                  null (* Item1 *),
                  Ast.SynValInfo.SynValInfo( (* Item2 *)
                    [ (* Item1 *)],
                    Ast.SynArgInfo.SynArgInfo( (* Item2 *)
                      [ (* attributes *)],
                      false,
                      null (* id *))),
                  null (* Item3 *)),
                Ast.SynPat.Named( (* headPat *)
                  Ast.SynPat.Wild( (* Item1 *)
                    new Range.range()),
                  arg2 (* id *),
                  false,
                  null (* accessiblity *),
                  new Range.range()),
                null (* Item9 *),
                Ast.SynExpr.Const( (* expr *)
                  Ast.SynConst.Int32( (* constant *)
                    456),
                  new Range.range()),
                new Range.range(),
                Ast.SequencePointInfoForBinding.SequencePointAtBinding( (* spBind *)
                  new Range.range()))],
            Ast.SynExpr.LetOrUse( (* exprBody *)
              false,
              false,
              [ (* bindings *)
                Ast.SynBinding.Binding(
                  null (* access *),
                  Ast.SynBindingKind.NormalBinding( (* bindingKind *)),
                  false,
                  false,
                  [ (* attributes *)],
                  Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                    new Range.pos(),
                    Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                  Ast.SynValData.SynValData( (* Item7 *)
                    null (* Item1 *),
                    Ast.SynValInfo.SynValInfo( (* Item2 *)
                      [ (* Item1 *)],
                      Ast.SynArgInfo.SynArgInfo( (* Item2 *)
                        [ (* attributes *)],
                        false,
                        null (* id *))),
                    null (* Item3 *)),
                  Ast.SynPat.Named( (* headPat *)
                    Ast.SynPat.Wild( (* Item1 *)
                      new Range.range()),
                    arg3 (* id *),
                    false,
                    null (* accessiblity *),
                    new Range.range()),
                  null (* Item9 *),
                  Ast.SynExpr.Const( (* expr *)
                    Ast.SynConst.Int32( (* constant *)
                      789),
                    new Range.range()),
                  new Range.range(),
                  Ast.SequencePointInfoForBinding.SequencePointAtBinding( (* spBind *)
                    new Range.range()))],
              Ast.SynExpr.LetOrUse( (* exprBody *)
                false,
                false,
                [ (* bindings *)
                  Ast.SynBinding.Binding(
                    null (* access *),
                    Ast.SynBindingKind.NormalBinding( (* bindingKind *)),
                    false,
                    false,
                    [ (* attributes *)],
                    Ast.PreXmlDoc.PreXmlDoc( (* xmlDoc *)
                      new Range.pos(),
                      Microsoft.FSharp.Compiler.Ast+XmlDocCollector (* Item2 *)),
                    Ast.SynValData.SynValData( (* Item7 *)
                      null (* Item1 *),
                      Ast.SynValInfo.SynValInfo( (* Item2 *)
                        [ (* Item1 *)],
                        Ast.SynArgInfo.SynArgInfo( (* Item2 *)
                          [ (* attributes *)],
                          false,
                          null (* id *))),
                      null (* Item3 *)),
                    Ast.SynPat.Named( (* headPat *)
                      Ast.SynPat.Wild( (* Item1 *)
                        new Range.range()),
                      context (* id *),
                      false,
                      null (* accessiblity *),
                      new Range.range()),
                    null (* Item9 *),
                    Ast.SynExpr.App( (* expr *)
                      ExprAtomicFlag.Atomic,
                      false,
                      Ast.SynExpr.LongIdent( (* funcExpr *)
                        false,
                        Ast.LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                          [ (* id *)
                            Aspect;
                            Enter],
                          [ (* dotms *)
                            new Range.range()]),
                        null (* altNameRefCell *),
                        new Range.range()),
                      Ast.SynExpr.Paren( (* argExpr *)
                        Ast.SynExpr.Tuple( (* expr *)
                          [ (* exprs *)
                            Ast.SynExpr.Const(
                              Ast.SynConst.String( (* constant *)
                                "Sample.fs",
                                new Range.range()),
                              new Range.range());
                            Ast.SynExpr.Const(
                              Ast.SynConst.Int32( (* constant *)
                                12),
                              new Range.range());
                            Ast.SynExpr.Const(
                              Ast.SynConst.Int32( (* constant *)
                                34),
                              new Range.range());
                            Ast.SynExpr.ArrayOrListOfSeqExpr(
                              true,
                              Ast.SynExpr.CompExpr( (* elements *)
                                true,
                                { (* isNotNakedRefCell *)
                                  true},
                                Ast.SynExpr.Sequential( (* expr *)
                                  Ast.SequencePointInfoForSeq.SequencePointsAtSeq( (* spSeq *)),
                                  true,
                                  Ast.SynExpr.Ident( (* expr1 *)
                                    arg0 (* Item *)),
                                  Ast.SynExpr.Sequential( (* expr2 *)
                                    Ast.SequencePointInfoForSeq.SequencePointsAtSeq( (* spSeq *)),
                                    true,
                                    Ast.SynExpr.Ident( (* expr1 *)
                                      arg1 (* Item *)),
                                    Ast.SynExpr.Sequential( (* expr2 *)
                                      Ast.SequencePointInfoForSeq.SequencePointsAtSeq( (* spSeq *)),
                                      true,
                                      Ast.SynExpr.Ident( (* expr1 *)
                                        arg2 (* Item *)),
                                      Ast.SynExpr.Ident( (* expr2 *)
                                        arg3 (* Item *)),
                                      new Range.range()),
                                    new Range.range()),
                                  new Range.range()),
                                new Range.range()),
                              new Range.range())],
                          [ (* commaRanges *)
                            new Range.range();
                            new Range.range();
                            new Range.range()],
                          new Range.range()),
                        new Range.range(),
                        range>.Some( (* rightParenRange *)
                          new Range.range()),
                        new Range.range()),
                      new Range.range()),
                    new Range.range(),
                    Ast.SequencePointInfoForBinding.SequencePointAtBinding( (* spBind *)
                      new Range.range()))],
                Ast.SynExpr.TryWith( (* exprBody *)
                  Ast.SynExpr.App( (* tryExpr *)
                    ExprAtomicFlag.Atomic,
                    false,
                    Ast.SynExpr.LongIdent( (* funcExpr *)
                      false,
                      Ast.LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                        [ (* id *)
                          context;
                          Leave],
                        [ (* dotms *)
                          new Range.range()]),
                      null (* altNameRefCell *),
                      new Range.range()),
                    Ast.SynExpr.Paren( (* argExpr *)
                      Ast.SynExpr.App( (* expr *)
                        ExprAtomicFlag.Atomic,
                        false,
                        Ast.SynExpr.LongIdent( (* funcExpr *)
                          false,
                          Ast.LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                            [ (* id *)
                              System;
                              String;
                              Format],
                            [ (* dotms *)
                              new Range.range();
                              new Range.range()]),
                          null (* altNameRefCell *),
                          new Range.range()),
                        Ast.SynExpr.Paren( (* argExpr *)
                          Ast.SynExpr.Tuple( (* expr *)
                            [ (* exprs *)
                              Ast.SynExpr.Ident(
                                arg0 (* Item *));
                              Ast.SynExpr.Ident(
                                arg1 (* Item *));
                              Ast.SynExpr.Ident(
                                arg2 (* Item *));
                              Ast.SynExpr.Ident(
                                arg3 (* Item *))],
                            [ (* commaRanges *)
                              new Range.range();
                              new Range.range();
                              new Range.range()],
                            new Range.range()),
                          new Range.range(),
                          range>.Some( (* rightParenRange *)
                            new Range.range()),
                          new Range.range()),
                        new Range.range()),
                      new Range.range(),
                      range>.Some( (* rightParenRange *)
                        new Range.range()),
                      new Range.range()),
                    new Range.range()),
                  new Range.range(),
                  [ (* Item3 *)
                    Ast.SynMatchClause.Clause(
                      Ast.SynPat.Named( (* Item1 *)
                        Ast.SynPat.Wild( (* Item1 *)
                          new Range.range()),
                        ex (* id *),
                        false,
                        null (* accessiblity *),
                        new Range.range()),
                      null (* Item2 *),
                      Ast.SynExpr.Sequential( (* Item3 *)
                        Ast.SequencePointInfoForSeq.SequencePointsAtSeq( (* spSeq *)),
                        true,
                        Ast.SynExpr.App( (* expr1 *)
                          ExprAtomicFlag.Atomic,
                          false,
                          Ast.SynExpr.LongIdent( (* funcExpr *)
                            false,
                            Ast.LongIdentWithDots.LongIdentWithDots( (* longIdent *)
                              [ (* id *)
                                context;
                                Caught],
                              [ (* dotms *)
                                new Range.range()]),
                            null (* altNameRefCell *),
                            new Range.range()),
                          Ast.SynExpr.Paren( (* argExpr *)
                            Ast.SynExpr.Ident( (* expr *)
                              ex (* Item *)),
                            new Range.range(),
                            range>.Some( (* rightParenRange *)
                              new Range.range()),
                            new Range.range()),
                          new Range.range()),
                        Ast.SynExpr.App( (* expr2 *)
                          ExprAtomicFlag.Atomic,
                          false,
                          Ast.SynExpr.Ident( (* funcExpr *)
                            reraise (* Item *)),
                          Ast.SynExpr.Const( (* argExpr *)
                            Ast.SynConst.Unit( (* constant *)),
                            new Range.range()),
                          new Range.range()),
                        new Range.range()),
                      new Range.range(),
                      Ast.SequencePointInfoForTarget.SequencePointAtTarget( (* spTarget *)))],
                  new Range.range(),
                  new Range.range(),
                  Ast.SequencePointInfoForTry.SequencePointAtTry( (* spTry *)
                    new Range.range()),
                  Ast.SequencePointInfoForWith.SequencePointAtWith( (* spWith *)
                    new Range.range())),
                new Range.range()),
              new Range.range()),
            new Range.range()),
          new Range.range()),
        new Range.range()),
      new Range.range(),
      Ast.SequencePointInfoForBinding.NoSequencePointAtLetBinding( (* spBind *)))],
  new Range.range())],
