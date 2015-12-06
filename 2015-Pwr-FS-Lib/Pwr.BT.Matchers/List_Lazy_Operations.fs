namespace Pwr.BT.Collections.List.Lazy
    module Oper =
    open Pwr.BT.Types

    let rec toLazyList = function
        [] -> LKoniec
        | h::t -> LElement(h, function () -> toLazyList t)

    let rec ltake = function
        |(0,_)->[]
        |(_,LKoniec)->[]
        |(n,LElement(x,xf))->x::ltake(n-1,xf())

    let rec lhd = function
        |LKoniec -> failwith "lhd"
        |LElement(h,_) -> h

    let rec lhead lista= List.head (ltake(1,lista))

    let ltl = function
        |LKoniec -> failwith "lhd"
        |LElement(_,t) -> t()

    let rec lEquals aL1 aL2 = 
            match(lhd aL1,lhd aL2) with
            |(h1,h2) -> (h1 = h2) && (lEquals (ltl aL1) (ltl aL2))
//
    let rec foldLeft f acc l =
        match l with 
        |h::t -> foldLeft f (f acc h) t
        |[]   -> acc


    let rec foldLeftTwo f acc (l1,l2) =
        match (l1,l2) with 
        |(h1::t1,h2::t2) -> foldLeftTwo f (f acc (f h1 h2)) (t1,t2)
        |([],[])  -> acc
        |_ -> acc

    let rec toEagerList = function
        |LKoniec -> []
        |LElement(x,xf) -> x::toEagerList(xf())

    let rec lfold_left f acc l = 
        match toEagerList l with
        |h::t-> foldLeft f (f acc h) t
        |[]-> acc

    let rec lfold_left_two f acc (l1,l2)= foldLeftTwo f acc (toEagerList l1,toEagerList l2)

//    let rec lListOfHeads lL1 lL2 =
//        let lE1 = 

    let rec lfilter fpred = 
        function 
        |LKoniec -> LKoniec
        |LElement(hd,ftl) ->
            if fpred hd
            then LElement(hd,fun() -> lfilter fpred (ftl()))
            else lfilter fpred (ftl())

    //let rec ldzialanie lL1 lL2 f

//    let rec l_fold_left f acc l= function
//        |lhd::ltl -> l_fold_left f (f acc h) t
//        |LKoniec -> acc