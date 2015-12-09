﻿namespace Pwr.BT.Collections.Own.ListLazy
    module Functionals =
    open Pwr.BT.Collections.Own.ListLazy.Atomic

    let eFilterContains el tapeListL = lFilter (lContains el) tapeListL

    let rec lPowiel tapeListL =
        let rec hPowiel acc =
            function
            |EmptyL -> lRev (lFoldLeftForFlat (@) EmptyL acc)
            |BodyL( h, t ) -> hPowiel (BodyL( lDuplicate h h, fun() ->acc )) (t())
        in hPowiel EmptyL tapeListL

    let eFlatten tapeListE = (lFoldLeftForFlat (@) EmptyL tapeListE)