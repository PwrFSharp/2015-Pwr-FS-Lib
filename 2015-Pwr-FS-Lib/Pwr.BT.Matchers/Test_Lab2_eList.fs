﻿namespace Pwr.BT.Test
    module Test_Lab2_eList =
    
    open System
    open System.Collections
    open NUnit.Framework
    open NUnit.Framework.Constraints
    open Pwr.BT.Types
    open Pwr.BT.Collections.List.Iter
    open Pwr.BT.Collections.ReferencesToLists
    open Pwr.BT.Collections.Own.ListEager
    open Pwr.BT.Collections.Tuple.Operations

    [<Test>]
    let eSize_ListE_1() =
      let tapeListE = BodyE(5.,BodyE(3.,BodyE(2.,EmptyE)))
        
      let _expectedVal = 3
      let _reachedVal = eSize tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eSize_ListE_2() =
      let tapeListE = EmptyE
        
      let _expectedVal = 0
      let _reachedVal = eSize tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eSize_ListE_3() =
      let tapeListE = BodyE(2.,EmptyE)
        
      let _expectedVal = 1
      let _reachedVal = eSize tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eBranchByEven_ListE_ListE2_1() =
      let tapeListE = BodyE(3,BodyE(6,BodyE(8,BodyE(9,BodyE(13,EmptyE)))))
        
      let _firstExpectedVal2 = BodyE(6,BodyE(8,EmptyE))
      let _secondExpectedVal2 = BodyE(3,BodyE(9,BodyE(13,EmptyE)))
      
      let _expectedVal = (_firstExpectedVal2,_secondExpectedVal2)
      let _reachedVal = eBranchByEven tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eBranchByEven_ListE_ListE2_2() =
      let tapeListE = EmptyE
        
      let _firstExpectedVal2 = EmptyE
      let _secondExpectedVal2 = EmptyE
      
      let _expectedVal = (_firstExpectedVal2,_secondExpectedVal2)
      let _reachedVal = eBranchByEven tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eBranchByEven_ListE_ListE2_3() =
      let tapeListE = BodyE(4,BodyE(6,BodyE(8,BodyE(10,BodyE(12,EmptyE)))))
        
      let _firstExpectedVal2 = BodyE(4,BodyE(6,BodyE(8,BodyE(10,BodyE(12,EmptyE)))))
      let _secondExpectedVal2 = EmptyE
      
      let _expectedVal = (_firstExpectedVal2,_secondExpectedVal2)
      let _reachedVal = eBranchByEven tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let mergeBraid_ListE_ListE_1() =
      let fstTapeListE = BodyE(5,BodyE(4,BodyE(3,BodyE(2,EmptyE))))
      let sndTapeListE = BodyE(1,BodyE(2,BodyE(3,BodyE(4,BodyE(5,BodyE(6,EmptyE))))))
              
      let _expectedVal = BodyE(5,BodyE(1,BodyE(4,BodyE(2,BodyE(3,BodyE(3,BodyE(2,BodyE(4,BodyE(5,BodyE(6,EmptyE))))))))))
      let _reachedVal = eMergeBraid fstTapeListE sndTapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let mergeBraid_ListE_ListE_2() =
      let fstTapeListE = BodyE(5,BodyE(4,BodyE(3,BodyE(2,EmptyE))))
      let sndTapeListE = EmptyE
              
      let _expectedVal = BodyE(5,BodyE(4,BodyE(3,BodyE(2,EmptyE))))
      let _reachedVal = eMergeBraid fstTapeListE sndTapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let mergeBraid_ListE_ListE_3() =
      let fstTapeListE = EmptyE
      let sndTapeListE = EmptyE
              
      let _expectedVal = EmptyE
      let _reachedVal = eMergeBraid fstTapeListE sndTapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let mergeBraid_ListE_ListE_4() =
      let fstTapeListE = EmptyE
      let sndTapeListE = BodyE(5,BodyE(4,BodyE(3,BodyE(2,EmptyE))))
              
      let _expectedVal = BodyE(5,BodyE(4,BodyE(3,BodyE(2,EmptyE))))
      let _reachedVal = eMergeBraid fstTapeListE sndTapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)