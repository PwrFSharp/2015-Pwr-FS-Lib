namespace Pwr.BT.Collections.Own.ListLazy
    module Functionals =
    open Pwr.BT.Collections.Own.ListLazy.Atomic

    let eFilterContains el tapeListL = lFilter (lContains el) tapeListL

    let rec lPowiel tapeListL =
        let rec hPowiel acc =
            function
            |EmptyL -> lRev (lFoldLeftForFlat (@) EmptyL acc)
            |BodyL( h, t ) -> hPowiel (BodyL( lDuplicate h h, fun() ->acc )) (t())
        in hPowiel EmptyL tapeListL
//
    let rec lPowiel2 tapeListL = lFoldLeftForFlat (@) EmptyL tapeListL

    let rec lPowielPart tapeListL =
        match tapeListL with
            |EmptyL -> EmptyL
            |BodyL( h, t ) -> BodyL( lDuplicate h h, fun() ->lPowielPart (t()))



    let lFlatten tapeListE = (lFoldLeftForFlat (@) EmptyL tapeListE)