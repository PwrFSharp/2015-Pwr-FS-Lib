namespace Pwr.BT.Collections.Own.ListEager
    module Functionals =
    open Pwr.BT.Collections.Own.ListEager.Atomic

    let eFilterContains el tapeListE = eFilter (eContains el) tapeListE

    let rec powiel tapeListE =
        let rec hPowiel acc =
            function
            |EmptyE -> eRev (eFoldLeftForFlat (@) EmptyE acc)
            |BodyE( h, t ) -> hPowiel (BodyE( eDuplicate h h, acc )) t
        in hPowiel EmptyE tapeListE

    let eFlatten tapeListE = (eFoldLeftForFlat (@) EmptyE tapeListE)