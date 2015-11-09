namespace Pwr.BT.Test.MatcherAndTR
    module Predicate =    
      open System
      open System.Collections
      open NUnit.Framework
      open NUnit.Framework.Constraints
      open Pwr.BT.MatcherAndTR.Predicate

      [<Test>]
        let Switch1() =
          let _inList1 = [1;2;3]
          let _inList2 = [3;1;2]
      
          let _reachedValue = switch _inList1 _inList2 false
          let _expectedVal=1::[]
      
          let _reachedComparison = _expectedVal = _reachedValue 
          
          Assert.True(_reachedComparison)