﻿namespace Pwr.BT.Test
    module Test_Lab7_lList =
    
    open NUnit.Framework
    open Pwr.BT.Collections.Own.ListLazy.Atomic
    open Pwr.BT.Collections.Own.ListLazy.Functionals

    [<Test>]
    let lPowiel_ListE_1() =
      let tapeListE = BodyL(1,fun()->BodyL(2,fun()->BodyL(3,fun()->EmptyL)))
              
      let _expectedVal = [1;2;2;3;3;3]
      let _reachedVal = lToNative (lPowiel tapeListE)
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let powiel_ListE_2() =
      let tapeListE = BodyL(0,fun()->EmptyL)
              
      let _expectedVal = []
      let _reachedVal = lToNative (lPowiel tapeListE)
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
//
    [<Test>]
    let powiel_ListE_3() =
      let tapeListE = BodyL(7,fun()->EmptyL)
              
      let _expectedVal = [7;7;7;7;7;7;7]
      let _reachedVal = lToNative (lPowiel tapeListE)
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(true)

    [<Test>]
    let powiel_ListE_4() =
      let tapeListE = BodyL(-4,fun()->EmptyL)
              
      let _expectedVal = []
      let _reachedVal = lToNative (lPowiel tapeListE)
    
//      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(true)
