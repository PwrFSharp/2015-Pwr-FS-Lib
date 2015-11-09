namespace Pwr.BT.Matchers
    module ListOfLists =
    
    let rec flattenM aList1 = 
      match aList1 with
      |[] -> []
      |h1::t1-> h1@flattenM t1