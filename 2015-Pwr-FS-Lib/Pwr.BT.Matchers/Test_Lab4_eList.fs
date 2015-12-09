namespace Pwr.BT.Test
    module Test_Lab4_eList =
    open NUnit.Framework
    open Pwr.BT.Collections.Own.ListEager.Atomic
    open Pwr.BT.Collections.Own.ListEager.Functionals
    open Pwr.BT.Collections.Own.ListEager.eNumericOperations
    
    [<Test>]
    let eFilterContains_ListE_1() =
      let l1 = BodyE( 1, BodyE( 2, BodyE( 3, EmptyE ) ) )
      let l2 = BodyE( 3, BodyE( 4, EmptyE ) )
      let l3 = BodyE( 5, BodyE( 6, EmptyE ) )

      let tapeListE = BodyE( l1, BodyE( l2, BodyE( l3, EmptyE ) ) )

      let el = 3
       
      let _hExpectedVal = BodyE( 1, BodyE( 2, BodyE( 3, EmptyE ) ) )
      let _hhExpectedVal = BodyE( 3, BodyE( 4, EmptyE ) )
      
      let _expectedVal = BodyE( _hExpectedVal, BodyE( _hhExpectedVal, EmptyE ) )
      let _reachedVal = eFilterContains el tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eFilterContains_ListE_2() =
//      let l1 = BodyE( 1, BodyE( 2, BodyE( 3, EmptyE ) ) )
//      let l2 = BodyE( 3, BodyE( 4, EmptyE ) )
//      let l3 = BodyE( 5, BodyE( 6, EmptyE ) )
//
//      let tapeListE = BodyE( l1, BodyE( l2, BodyE( l3, EmptyE ) ) )
//
//      let el = 6
//       
//      let _hExpectedVal = BodyE( 5, BodyE( 6, EmptyE ) )
//      
//      let _expectedVal = BodyE( _hExpectedVal, EmptyE )
//      let _reachedVal = eFilterContains el tapeListE
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eFilterContains_ListE_3() =
//      let l1 = BodyE( 1, BodyE( 2, BodyE( 3, EmptyE ) ) )
//      let l2 = BodyE( 3, BodyE( 4, EmptyE ) )
//      let l3 = BodyE( 5, BodyE( 6, EmptyE ) )
//
//      let tapeListE = BodyE( l1, BodyE( l2, BodyE( l3, EmptyE ) ) )
//
//      let el = 7
//       
//      let _hExpectedVal = EmptyE
//      
//      let _expectedVal = EmptyE
//      let _reachedVal = eFilterContains el tapeListE
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eFilterContains_ListE_4() =
//      let l1 = EmptyE
//      let l2 = EmptyE
//      let l3 = EmptyE
//
//      let tapeListE = BodyE( l1, BodyE( l2, BodyE( l3, EmptyE ) ) )
//
//      let el = 7
//       
//      let _hExpectedVal = EmptyE
//      
//      let _expectedVal = EmptyE
//      let _reachedVal = eFilterContains el tapeListE
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)

    [<Test>]
    let eBinToDec_ListE_1() =
      let tapeListE = BodyE( 1, BodyE( 1, BodyE( 1, BodyE( 0, EmptyE ) ) ) )
      
      let _expectedVal = 14
      let _reachedVal = eBinToDec tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eBinToDec_ListE_2() =
//      let tapeListE = BodyE( 0, EmptyE )
//      
//      let _expectedVal = 0
//      let _reachedVal = eBinToDec tapeListE
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eBinToDec_ListE_3() =
//      let tapeListE = BodyE( 1, EmptyE )
//      
//      let _expectedVal = 1
//      let _reachedVal = eBinToDec tapeListE
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eBinToDec_ListE_4() =
//      let tapeListE = BodyE( 0, BodyE( 0, BodyE( 0, BodyE( 0, EmptyE ) ) ) )
//      
//      let _expectedVal = 0
//      let _reachedVal = eBinToDec tapeListE
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)