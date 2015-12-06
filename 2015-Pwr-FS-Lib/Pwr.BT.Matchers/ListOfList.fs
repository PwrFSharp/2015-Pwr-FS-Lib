namespace Pwr.BT.Matchers
    module ListOfLists =
    
    let rec flattenM aList1 = 
      match aList1 with
      |[] -> []
      |h1::t1-> h1@flattenM t1

    let rec rev aList =
        let rec rIHelp(aListH,acc) =
            match aListH with
            |[] -> acc
            |_ -> rIHelp(List.tail aListH,List.head aListH::acc)
        in rIHelp(aList,[])

    let rec append aList1 aList2 = 
        let rec help(tape1,tape2,acc) = 
          match tape1,tape2 with
          |h1::t1,h2::t2 -> help(t1,tape2,h1::acc)
          |[],h2::t2  -> help([],t2,h2::acc)
          |[],[] -> rev acc
          |_-> []
        in help(aList1,aList2,[])