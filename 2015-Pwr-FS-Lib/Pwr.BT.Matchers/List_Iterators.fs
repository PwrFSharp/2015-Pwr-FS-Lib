    namespace Pwr.BT.Collections.List
    module Iter =
    open Oper
    open Pwr.BT.Collections.List.Lazy.Oper

    let rec rev aList =
        let rec rIHelp(aListH,acc) =
            match aListH with
            |[] -> acc
            |_ -> rIHelp(List.tail aListH,List.head aListH::acc)
        in rIHelp(aList,[])

    let rec revL aList =
        let rec rIHelp(aListH,acc) =
            match aListH with
            |[] -> toLazyList acc
            |_ -> rIHelp(List.tail aListH,List.head aListH::acc)
        in rIHelp(aList,[])