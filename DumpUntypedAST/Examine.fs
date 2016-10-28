

let original = 
  System.String.Format("ABC", 123, 456, 789)


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
                  ABC,
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


ynModuleDecl.Let(
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
               ABC,
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
                               Sample.fs,
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
                                 ABC,
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
