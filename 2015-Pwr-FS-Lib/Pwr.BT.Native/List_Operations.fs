namespace Pwr.BT.Collections.List
    module Oper =
    open Iter

    let rec flattenM aList1 = 
      match aList1 with
      |[] -> []
      |h1::t1-> h1@flattenM t1

    let isEmpty aTape =
        match aTape with
        |[] -> true
        |_ -> false

    let rec foldRight f l acc = 
        match l with
        |h::t -> f h (foldRight f t acc)
        |[]   -> acc

    let rec foldLeft f acc l =
        match l with 
        |h::t -> foldLeft f (f acc h) t 
        |[]   -> acc

    let rec foldLeftTwo f acc (l1,l2) =
        match (l1,l2) with 
        |(h1::t1,h2::t2) -> foldLeftTwo f (f acc (f h1 h2)) (t1,t2)
        |([],[])  -> acc
        |_ -> acc

//    let rec foldLeftTwoInList f acc (l1:'a list,l2:'a list) =
//        match (l1,l2) with 
//        |(h1::t1,h2::t2) -> foldLeftTwo f (acc @ [f h1 h2] ) (t1,t2)
//        |([],[])  -> acc
//        |_ -> acc

    let rec foldLeftTwoInList f acc (l1,l2) =
        match (l1,l2) with 
        |(h1::t1,h2::t2) -> foldLeftTwoInList f (acc @ [f h1 h2] ) (t1,t2)
        |([],[])  -> acc
        |_ -> acc

    let rec dlugoscTR aLista = 
      let rec dlugoscTailed (aLista,acc) = 
        if aLista = [] then acc
        else dlugoscTailed (List.tail aLista,acc+1)
      in dlugoscTailed (aLista,0)
       
    let rec take(n,aList)= 
        match (n,aList) with
        |(0,_)->[]
        |(_,[])->[]
        |(n,_)->(List.head aList) :: take(n-1,List.tail aList)

    let rec dzialanie gL1 gL2 f=
        let rec helpD(gL1Help,gL2Help,acc) =
            match(gL1Help,gL2Help) with
////                foldLeft f 
//            |(_,[]) ->
            |([],[]) -> acc
            |([],_) -> acc @ gL2Help
            |(_,_) ->acc @ foldLeftTwoInList f acc (gL1Help,gL2Help)
        in helpD(gL1,gL2,[])

    let rec dzialanie2 gL1 gL2 f=
        let len1 = dlugoscTR gL1 in
        let len2 = dlugoscTR gL2 in
        let isBigger = len1 > len2 in
            let rec helpD(gL1Help,gL2Help,acc) =
                if len1=len2 then acc @ foldLeftTwoInList f acc (gL1Help,gL2Help)
                else if isBigger then foldLeftTwoInList f acc (gL1Help,gL2Help) @ take(len1-len2,rev gL1Help)
                else foldLeftTwoInList f acc (gL1Help,gL2Help) @ take(len2-len1,rev gL2Help)
        in helpD(gL1,gL2,[])

//    let rec toLazyList = function
//    [] -> LNil
//    | h::t -> LCons(h, function () -> toLazyList t);

//    let rec subtract aList1 aList2 =
//        let rec helpS(hList1,hList2,hAcc) =
//            match hList2 with
//            |[] -> hAcc
//            |_->
//                if List.head hList1 = List.head hList2 then helpS(List.tail hList1,hList2,hAcc)
//                else helpS(List.)

    let rec (|@) aList1 aList2 = 
        let rec help(tape1,tape2,acc) = 
          match tape1,tape2 with
          |h1::t1,h2::t2 -> help(t1,tape2,h1::acc)
          |[],h2::t2  -> help([],t2,h2::acc)
          |[],[] -> rev acc
          |_-> []
        in help(aList1,aList2,[])