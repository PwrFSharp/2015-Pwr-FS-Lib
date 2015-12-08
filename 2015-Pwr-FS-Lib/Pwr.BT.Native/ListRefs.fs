namespace Pwr.BT.Collections
    module ReferencesToLists =
    open Pwr.BT.Types
        
    let headRemover (aList: eval list ref) = 
        aList:=List.tail !aList
        !aList

    let rec RPN aList1 = 0.0