namespace Pwr.BT.MatcherAndTR
    module ListOfLists =
      
      let rec iterator aList = 
        let rec help (aListHelp,aAcc)=
          match aListHelp with
          |h::t -> help (t,h::aAcc)
          |[] -> aAcc
        in help(aList,[])

      let rec append aList1 aList2 = 
        let rec help(tape1,tape2,acc) = 
          match tape1,tape2 with
          |h1::t1,h2::t2 -> help(t1,tape2,h1::acc)
          |[],h2::t2  -> help([],t2,h2::acc)
          |[],[] -> iterator acc
          |_-> []
        in help(aList1,aList2,[])

      let rec flatten aList1 = 
          match aList1 with      
          |h1::t1 -> append h1 ( List.head t1 )
          |[] -> []

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

