namespace Pwr.BT.MatcherAndTR
    module List =
      open Pwr.BT
      open ListOfLists

      let rec append aList1 aList2 = 
        let rec help(tape1,tape2,acc) = 
          match tape1,tape2 with
          |h1::t1,h2::t2 -> help(t1,tape2,h1::acc)
          |[],h2::t2  -> help([],t2,h2::acc)
          |[],[] -> iterator acc
          |_-> []
        in help(aList1,aList2,[])

      let switch aList0 aList1 aInitVal =
        match aInitVal with
        | false when aList0=[] -> [List.head aList1]
        | false -> [List.head aList0]
        | true when aList1=[]-> [List.head aList0]
        | true -> [List.head aList1]

      let tailOfHead aList = List.tail(List.head aList)