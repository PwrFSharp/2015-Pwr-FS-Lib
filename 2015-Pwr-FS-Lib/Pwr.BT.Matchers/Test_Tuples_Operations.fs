namespace Pwr.BT.Test
    module Test_Tuples_Operations =
    
    open System
    open System.Collections
    open NUnit.Framework
    open Pwr.BT.Collections.Own.ListEager
    open NUnit.Framework.Constraints
    open Pwr.BT.Types
    open Pwr.BT.Collections.List.Iter
    open Pwr.BT.Collections.ReferencesToLists
    open Pwr.BT.Collections.Tuple.Operations

    [<Test>]
    let fst2_Native2_1() =
      let tape2 = (1,2)
        
      let _expectedVal = 1
      let _reachedVal = fst2 tape2
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let snd2_Native2_2() =
      let tape2 = (1,[1;2;3])
        
      let _expectedVal = [1;2;3]
      let _reachedVal = snd2 tape2
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let fst2_Own2_1() =
      let tape2 = (EmptyE,EmptyE)
        
      let _expectedVal = EmptyE
      let _reachedVal = fst2 tape2
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
    
    [<Test>]
    let snd2_Own2_2() =
      let tape2 = (EmptyE,BodyE(2,EmptyE))
        
      let _expectedVal = BodyE(2,EmptyE)
      let _reachedVal = snd2 tape2
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let fst3_Native3_1() =
      let tape3 = (1,2,3)
        
      let _expectedVal = 1
      let _reachedVal = fst3 tape3
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
    
    [<Test>]
    let snd3_Native3_2() =
      let tape3 = (1,[1;2;3],3)
        
      let _expectedVal = [1;2;3]
      let _reachedVal = snd3 tape3
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let thrd3_Native3_3() =
      let tape3 = (1,[1;2;3],(1,2,3))
        
      let _expectedVal = (1,2,3)
      let _reachedVal = thrd3 tape3
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)