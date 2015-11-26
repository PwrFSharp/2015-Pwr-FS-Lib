namespace Pwr.BT.Collections.Stack
    module Oper =
    open Pwr.BT.Collections.List.Iter

    let pushSR(aStack,aElement) =
        rev(aElement::(rev aStack))

    let popSAR aStack =
        match aStack with
        |[] -> []
        |_ -> rev (List.tail (rev aStack))

    let backNR aStack =
        match aStack with
        |[] -> failwith "empty"
        |_ -> List.head (rev aStack)

//    let backNR aStack =
//        match aStack with
//        |[] -> failwith "empty"
//        |_ -> List.head (rev aStack)

    let rec undressToLast aStack =
        let rec helpUTL (hStack,hAcc) =
            match hStack with
            |[h] -> rev hAcc
            |_ -> helpUTL(popSAR hStack,(backNR hStack)::hAcc)
        in helpUTL(aStack,[])
    
    let rec RPN aList1 = 0.0

//    let listToStacku