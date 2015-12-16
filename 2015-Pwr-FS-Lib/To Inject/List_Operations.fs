namespace Pwr.BT.Collections.List
    module Oper =

    let rec flattenM aList1 = 
      match aList1 with
      |[] -> []
      |h1::t1-> h1@flattenM t1

    let isEmpty aTape =
        match aTape with
        |[] -> true
        |_ -> false

//    let rec subtract aList1 aList2 =
//        let rec helpS(hList1,hList2,hAcc) =
//            match hList2 with
//            |[] -> hAcc
//            |_->
//                if List.head hList1 = List.head hList2 then helpS(List.tail hList1,hList2,hAcc)
//                else helpS(List.)


//    let rec appendTR aList1 aList2 = 
//        let rec help(tape1,tape2,acc) = 
//          match tape1,tape2 with
//          |h1::t1,h2::t2 -> help(t1,tape2,h1::acc)
//          |[],h2::t2  -> help([],t2,h2::acc)
//          |[],[] -> rev acc
//          |_-> []
//        in help(aList1,aList2,[])