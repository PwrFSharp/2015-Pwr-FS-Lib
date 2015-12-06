namespace Pwr.BT.Collections.Stack
    module OperRef =
    open Pwr.BT.Collections.List
    open Pwr.BT.Types
    open Pwr.BT.Collections.Stack
    open Pwr.BT.Collections.List.Iter
    open Pwr.BT.Collections
    open Pwr.BT.Collections.Own

    let pushRef aStack aElement =
        aStack:=rev(aElement::(rev !aStack))

    let popRef aStack =
        match !aStack with
        |[] -> aStack:=[]
        |_ -> aStack:= (rev (List.tail (rev !aStack)))

//    let popLRefFun laStack = function 
//        |LNil -> laStack:= function () -> []
//        |LCons(_) -> laStack:= function () -> rev (List.tail (revF laStack()))


//let rec count (aStack:'a bt list ref)
    let rec count aStack =
        let rec helpC(aList,acc) = 
            match aList with
            |[] -> acc
            |_ -> helpC(List.tail aList,1+acc)
        in helpC(!aStack,0)

    let backTreeRef aStack =
        match !aStack with
        |[] -> Empty
        |_ -> List.head (rev !aStack)

    let backBoolRef aStack =
        match !aStack with
        |[] -> true
        |_ -> List.head (rev !aStack)


    let popAndBack aStack =
        let copy = !aStack;
        if not (Oper.isEmpty !aStack) then
           aStack:=List.tail(rev !aStack);
        match !aStack with
        |[] -> Empty
        |_ -> List.head (rev copy)

    let add x y = x+y

    let multiply n func list =
            let f x =
            func n x in
            List.map f list

//        let copy = !aStack in

//            List.head (rev !aStack)
//
//    let backTreeRef aStack =
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