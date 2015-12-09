namespace Pwr.BT.Collections.Own.ListEager
    module eNumericOperations =
    open Atomic
    open Pwr.BT.Collections.Tuple.Operations

    let rec pow baseVal exponentVal =
        let rec hPow acc hExp =
            if hExp > 0 then hPow (baseVal*acc) (hExp-1)
            else acc
        in hPow 1 exponentVal

    let (|~@) f g x = f (g x)

    let rec eBinToDec tapeListE =
        let baseVal = 2 in
        let valuedTape = eStickListWithIdxDesc tapeListE in
            let rec helpBinToDec acc =
                function 
                |EmptyE -> acc
                |BodyE( h, t ) -> helpBinToDec ((fst2 h)* (pow baseVal (snd2 h))+ acc) t
            in helpBinToDec 0 valuedTape