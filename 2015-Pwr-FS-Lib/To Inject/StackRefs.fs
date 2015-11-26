namespace Pwr.BT.Collections.Stack
    module OperRef =
    open Pwr.BT.Collections.List
    open Pwr.BT.Types
    open Pwr.BT.Collections.Stack
    open Pwr.BT.Collections.List.Iter

    let pushSRef(aStack,aElement) =
        aStack:=rev(aElement::(rev !aStack))

    let popRef aStack =
        match !aStack with
        |[] -> aStack:=[]
        |_ -> aStack:= (rev (List.tail (rev !aStack)))
//        |_ -> aStack:= (List.tail (rev !aStack))

    let popRefTree (aStack:'a bt list ref) =
        match !aStack with
        |[] -> aStack:=[]
        |_ -> aStack:= (rev (List.tail (rev !aStack)))
//        |_ -> aStack:= (List.tail (rev !aStack))

    let rec count (aStack:'a bt list ref) =
        let rec helpC(aList,acc) = 
            match aList with
            |[] -> acc
            |_ -> helpC(List.tail aList,1+acc)
        in helpC(!aStack,0)

    let backNRRefTree (aStack:'a bt list ref) =
        match !aStack with
        |[] -> Empty
        |_ -> List.head (rev !aStack)

    let popAndBack (aStack:'a bt list ref) =
        let copy = !aStack;
        if not (Oper.isEmpty !aStack) then
           aStack:=List.tail(rev !aStack);
        match !aStack with
        |[] -> Empty
        |_ -> List.head (rev copy)

//        let copy = !aStack in

//            List.head (rev !aStack)
//
//    let backNRRefTree aStack =
//        match aStack with
//        |[] -> Empty
//        |_ -> List.head (rev aStack)

//    let rec undressToLastRef aStack =
//        let rec helpUTL (hStack,hAcc) =
//            match hStack with
//            |[h] -> rev hAcc
//            |_ -> helpUTL(popSAR hStack,(backNR hStack)::hAcc)
//        in helpUTL(aStack,[])
    
    let rec RPN aList1 = 0.0

//    let listToStacku