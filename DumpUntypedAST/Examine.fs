

let original = 
  System.String.Format("ABC", 123, 456, 789)


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
