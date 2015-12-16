namespace Pwr.BT.MatcherAndTR
    module Predicate=

      let modularOf ( aValIn:int,aDivider ) = aValIn % aDivider = 0

      let notModularOf ( aValIn:int,aDivider ) = aValIn % aDivider <> 0

      let predicate1 = fun x-> x%2=0

      let predicate2 x = x%2=0

      let takeFromListOnlyPredicatHead aList = 
        if predicate1 ( List.head aList  ) then 0
        else 1

      let boolSwitch aBegin = 
        if aBegin=true then false
         else true

      let switch aList0 aList1 aInitVal =
        match aInitVal with
        | false when aList0=[] -> ( List.head aList1 )::[]
        | false -> ( List.head aList0 )::[]
        | true when aList1=[]-> ( List.head aList0 )::[]
        | true -> ( List.head aList1 )::[]