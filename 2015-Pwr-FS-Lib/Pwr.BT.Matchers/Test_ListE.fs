namespace Pwr.BT.Test
    module Test_ListE =
    
    open System
    open System.Collections
    open NUnit.Framework
    open NUnit.Framework.Constraints
    open Pwr.BT.Types
    open Pwr.BT.Collections.List.Iter
    open Pwr.BT.Collections.Own.ListEager
    open Pwr.BT.Collections.Tuple.Operations

    [<Test>]
    let concat_ListE_ListE_1() =
      let fstTapeListE = BodyE(5,EmptyE)
      let sndTapeListE = BodyE(1,EmptyE)
              
      let _expectedVal = BodyE(5,BodyE(1,EmptyE))
      let _reachedVal = fstTapeListE @ sndTapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let concat_ListE_ListE_2() =
      let fstTapeListE = EmptyE
      let sndTapeListE = EmptyE
              
      let _expectedVal = EmptyE
      let _reachedVal = fstTapeListE @ sndTapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let concat_ListE_ListE_3() =
      let fstTapeListE = BodyE(5,BodyE(1,EmptyE))
      let sndTapeListE = EmptyE
              
      let _expectedVal = BodyE(5,BodyE(1,EmptyE))
      let _reachedVal = fstTapeListE @ sndTapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let concat_ListE_ListE_4() =
      let fstTapeListE = EmptyE
      let sndTapeListE = BodyE(5,BodyE(1,EmptyE))
              
      let _expectedVal = BodyE(5,BodyE(1,EmptyE))
      let _reachedVal = fstTapeListE @ sndTapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
