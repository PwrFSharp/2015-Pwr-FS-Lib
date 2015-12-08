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