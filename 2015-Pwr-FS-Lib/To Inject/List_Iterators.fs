namespace Pwr.BT.Collections.List
    module Iter =
    
    let rec rev aList =
        let rec rIHelp(aListH,acc) =
            match aListH with
            |[] -> acc
            |_ -> rIHelp(List.tail aListH,List.head aListH::acc)
        in rIHelp(aList,[])