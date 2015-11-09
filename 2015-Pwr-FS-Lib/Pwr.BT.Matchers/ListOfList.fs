namespace Pwr.BT.MatcherAndTR
    module ListOfLists =

//      let rec flatten aList1 = 
//        let rec help(aList1,acc) =
//          match aList1 with      
//          |h1::t1 -> help(t1,List.head h1@acc)
//          |[] -> acc
//        in help(aList1,[])
//
//          else []
//        |[[]]->[]
//        |[_] -> List.head(List.head aList)

      let switch aList0 aList1 aInitVal =
        match aInitVal with
        | false when aList0=[] -> ( List.head aList1 )::[]
        | false -> ( List.head aList0 )::[]
        | true when aList1=[]-> ( List.head aList0 )::[]
        | true -> ( List.head aList1 )::[]

      let tailOfHead aList = List.tail(List.head aList)

//      let rec flatten aList1 =      
//        let rec help(aList2,acc) = 
//          let hh = doubleHead aList2 in
//            let ht = tailOfHead aList2 in
//          match aList2 with
//          |h1::t1 -> help(ht::t1 ,hh ::acc)
//          |[] -> acc
//        in help(aList1,[])

      let rec iterator aList = 
        let rec help (aListHelp,aAcc)=
          match aListHelp with
          |h::t -> help (t,h::aAcc)
          |[] -> aAcc
        in help(aList,[])