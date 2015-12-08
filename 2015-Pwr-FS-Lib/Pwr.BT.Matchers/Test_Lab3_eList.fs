namespace Pwr.BT.Test
    module Test_Lab3_eList =
    
    open System
    open System.Collections
    open NUnit.Framework
    open NUnit.Framework.Constraints
    open Pwr.BT.Types
    open Pwr.BT.Collections.Own.ListEager
    open Pwr.BT.Collections.Tuple.Operations

    [<Test>]
    let eBranchByIdxEven3_ListE_1() =
      let tapeListE = BodyE( 5, BodyE( 4, BodyE( 3, BodyE( 2, EmptyE ) ) ) )
       
      let _fstExpectedVal2 = BodyE( 5, BodyE( 2, EmptyE ) )
      let _sndExpectedVal2 = BodyE( 4, EmptyE )
      let _thrdExpectedVal2 = BodyE( 3, EmptyE )
      
      let _expectedVal = (_fstExpectedVal2,_sndExpectedVal2,_thrdExpectedVal2)
      let _reachedVal = eBranchByIdxEven3 tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eBranchByIdxEven3_ListE_2() =
      let tapeListE = BodyE( 5, EmptyE )
       
      let _fstExpectedVal2 = BodyE( 5, EmptyE )
      let _sndExpectedVal2 = EmptyE
      let _thrdExpectedVal2 = EmptyE
      
      let _expectedVal = (_fstExpectedVal2,_sndExpectedVal2,_thrdExpectedVal2)
      let _reachedVal = eBranchByIdxEven3 tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eBranchByIdxEven3_ListE_3() =
      let tapeListE = EmptyE
       
      let _fstExpectedVal2 = EmptyE
      let _sndExpectedVal2 = EmptyE
      let _thrdExpectedVal2 = EmptyE
      
      let _expectedVal = (_fstExpectedVal2,_sndExpectedVal2,_thrdExpectedVal2)
      let _reachedVal = eBranchByIdxEven3 tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eBranchByIdxEven3_ListE_4() =
      let tapeListE = BodyE( 5, BodyE( 4, BodyE( 3, BodyE( 2, BodyE( 1, BodyE( 0, EmptyE ) ) ) ) ) )
       
      let _fstExpectedVal2 = BodyE( 5, BodyE( 2, EmptyE ) )
      let _sndExpectedVal2 = BodyE( 4, BodyE( 1, EmptyE ) )
      let _thrdExpectedVal2 = BodyE( 3, BodyE( 0, EmptyE ) )
      
      let _expectedVal = (_fstExpectedVal2,_sndExpectedVal2,_thrdExpectedVal2)
      let _reachedVal = eBranchByIdxEven3 tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eSumBrain_ListE_1() =
      let fstTapeListE = BodyE( 1, BodyE( 2, BodyE( 3, EmptyE ) ) )
      let sndTapeListE = BodyE( 4, BodyE( 5, BodyE( 6, BodyE( 7, BodyE( 8, EmptyE ) ) ) ) )
             
      let _expectedVal = BodyE( 5, BodyE( 7, BodyE( 9, BodyE( 7, BodyE( 8, EmptyE ) ) ) ) )
      let _reachedVal = eSumBraid fstTapeListE sndTapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eSumBrain_ListE_2() =
      let fstTapeListE = BodyE( 1, BodyE( 2, BodyE( 3, EmptyE ) ) )
      let sndTapeListE = BodyE( 1, BodyE( 2, BodyE( 3, EmptyE ) ) )
             
      let _expectedVal = BodyE( 2, BodyE( 4, BodyE( 6, EmptyE ) ) )
      let _reachedVal = eSumBraid fstTapeListE sndTapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eSumBrain_ListE_3() =
      let fstTapeListE = BodyE( 1, BodyE( 2, BodyE( 3, BodyE( 8, BodyE( 9, EmptyE ) ) ) ) )
      let sndTapeListE = BodyE( 1, BodyE( 2, BodyE( 3, EmptyE ) ) )
             
      let _expectedVal = BodyE( 2, BodyE( 4, BodyE( 6, BodyE( 8, BodyE( 9, EmptyE ) ) ) ) )
      let _reachedVal = eSumBraid fstTapeListE sndTapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eSumBrain_ListE_4() =
      let fstTapeListE = EmptyE
      let sndTapeListE = EmptyE
             
      let _expectedVal = EmptyE
      let _reachedVal = eSumBraid fstTapeListE sndTapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eSumBrain_ListE_5() =
      let fstTapeListE = BodyE( 1, EmptyE )
      let sndTapeListE = EmptyE
             
      let _expectedVal = BodyE( 1, EmptyE )
      let _reachedVal = eSumBraid fstTapeListE sndTapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eBranchByPivot_ListE_1() =
      let tapeListE = BodyE( 5, BodyE( 4, BodyE( 3, BodyE( 2, BodyE( 1, EmptyE ) ) ) ) )
      let pivotE = BodyE( 3, EmptyE )
       
      let _fstExpectedVal2 = BodyE( 5, BodyE( 4, EmptyE ) )
      let _sndExpectedVal2 = BodyE( 2, BodyE( 1, EmptyE ) )
      
      let _expectedVal = (_fstExpectedVal2,_sndExpectedVal2)
      let _reachedVal = eBranchByPivot tapeListE pivotE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eBranchByPivot_ListE_2() =
      let tapeListE = BodyE( 5, BodyE( 4, BodyE( 3, BodyE( 2, BodyE( 1, EmptyE ) ) ) ) )
      let pivotE = BodyE( 6, EmptyE )
       
      let _fstExpectedVal2 = EmptyE
      let _sndExpectedVal2 = BodyE( 5, BodyE( 4, BodyE( 3, BodyE( 2, BodyE( 1, EmptyE ) ) ) ) )
      
      let _expectedVal = (_fstExpectedVal2,_sndExpectedVal2)
      let _reachedVal = eBranchByPivot tapeListE pivotE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eBranchByPivot_ListE_3() =
      let tapeListE = BodyE( 5, BodyE( 4, BodyE( 3, BodyE( 2, BodyE( 1, EmptyE ) ) ) ) )
      let pivotE = BodyE( 0, EmptyE )
       
      let _fstExpectedVal2 = BodyE( 5, BodyE( 4, BodyE( 3, BodyE( 2, BodyE( 1, EmptyE ) ) ) ) )
      let _sndExpectedVal2 = EmptyE
      
      let _expectedVal = (_fstExpectedVal2,_sndExpectedVal2)
      let _reachedVal = eBranchByPivot tapeListE pivotE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eBranchByPivot_ListE_4() =
      let tapeListE = EmptyE
      let pivotE = BodyE( 0, EmptyE )
       
      let _fstExpectedVal2 = EmptyE
      let _sndExpectedVal2 = EmptyE
      
      let _expectedVal = (_fstExpectedVal2,_sndExpectedVal2)
      let _reachedVal = eBranchByPivot tapeListE pivotE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)