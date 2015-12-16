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
         
    let rec insert tapeListE el = 
        if tapeListE = EmptyE then BodyE( el, EmptyE )
        else
            let rec hInsert acc =
                function
                |EmptyE -> eRev acc
                |BodyE( h, EmptyE ) ->
                    if h <= el then hInsert ( BodyE( el, BodyE( h, acc ) ) ) EmptyE
                    else hInsert ( BodyE( h, BodyE( el, acc ) ) ) EmptyE
                |BodyE( h, t ) ->
                    if h <= el then hInsert ( BodyE( h, acc ) ) t
                    else hInsert ((eRev t) @ (BodyE( h, BodyE( el, acc )))) EmptyE
            in hInsert EmptyE tapeListE