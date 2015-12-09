namespace Pwr.BT.Test
    module Test_ListE =
    
    open System
    open System.Collections
    open NUnit.Framework
    open NUnit.Framework.Constraints
    open Pwr.BT.Types
    open Pwr.BT.Collections.List.Iter
    open Pwr.BT.Collections.Own.ListEager.Atomic
    open Pwr.BT.Collections.Tuple.Operations
    open Pwr.BT.Numeric.Predicates
    open Pwr.BT.Collections.Own.ListEager.Functionals
    open Pwr.BT.Collections.Own.ListEager.eNumericOperations

    [<Test>]
    let eMap_eSize_ListE_1() =
      let tapeListE = BodyE(BodyE(5,BodyE(1,EmptyE)),BodyE(BodyE(5,BodyE(1,BodyE(1,EmptyE))),EmptyE))
              
      let _expectedVal = BodyE(2,BodyE(3,EmptyE))
      let _reachedVal = eMap eSize tapeListE 
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eMap_eRev_ListE_1() =
      let tapeListE = BodyE(BodyE(5,BodyE(1,EmptyE)),BodyE(BodyE(5,BodyE(1,BodyE(1,EmptyE))),EmptyE))
              
      let _expectedVal = BodyE(BodyE(1,BodyE(5,EmptyE)),BodyE(BodyE(1,BodyE(1,BodyE(5,EmptyE))),EmptyE))
      let _reachedVal = eMap eRev tapeListE 
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eMap_eSum_ListE_1() =
      let tapeListE = BodyE(BodyE(5.,BodyE(1.,EmptyE)),BodyE(BodyE(5.,BodyE(1.,BodyE(1.,EmptyE))),EmptyE))
              
      let _expectedVal = BodyE(6.,BodyE(7.,EmptyE))
      let _reachedVal = eMap eSum tapeListE 
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eMap_eAdd3_ListE_1() =
      let tapeListE = BodyE(5,BodyE( 4, BodyE( 3, BodyE( 2, EmptyE ) ) ))
              
      let _expectedVal = BodyE(8,BodyE( 7, BodyE( 6, BodyE( 5, EmptyE ) ) ))
      let _reachedVal = eMap (fun x-> x+3) tapeListE 
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eMap_eStickListWithIdxAsc_ListE_1() =
      let tapeListE = BodyE( BodyE(5,BodyE(1,BodyE(1,BodyE(4,EmptyE)))), EmptyE )
              
      let _expectedVal = BodyE( BodyE((5,0),BodyE((1,1),BodyE((1,2), BodyE((4,3), EmptyE ) ))), EmptyE )
      let _reachedVal = eMap eStickListWithIdxAsc tapeListE 
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eStickListWithIdxAsc_ListE_1() =
      let tapeListE = BodyE(5,BodyE(1,BodyE(1,BodyE(4,EmptyE))))
              
      let _expectedVal = BodyE((5,0),BodyE((1,1),BodyE((1,2), BodyE((4,3), EmptyE ) )))
      let _reachedVal = eStickListWithIdxAsc tapeListE 
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eStickListWithIdxAsc_ListE_2() =
//      let tapeListE = EmptyE
//              
//      let _expectedVal = EmptyE
//      let _reachedVal = eStickListWithIdxAsc tapeListE 
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eStickListWithIdxAsc_ListE_3() =
//      let tapeListE = BodyE( 1., EmptyE )
//              
//      let _expectedVal = BodyE(( 1.,0), EmptyE )
//      let _reachedVal = eStickListWithIdxAsc tapeListE 
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)

    [<Test>]
    let eStickListWithIdxDesc_ListE_1() =
      let tapeListE = BodyE(5,BodyE(1,BodyE(1,BodyE(4,EmptyE))))
              
      let _expectedVal = BodyE((5,3),BodyE((1,2),BodyE((1,1), BodyE((4,0), EmptyE ) )))
      let _reachedVal = eStickListWithIdxDesc tapeListE 
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eStickListWithIdxDesc_ListE_2() =
//      let tapeListE = EmptyE
//              
//      let _expectedVal = EmptyE
//      let _reachedVal = eStickListWithIdxDesc tapeListE 
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eStickListWithIdxDesc_ListE_3() =
//      let tapeListE = BodyE( 1., EmptyE )
//              
//      let _expectedVal = BodyE(( 1.,0), EmptyE )
//      let _reachedVal = eStickListWithIdxDesc tapeListE 
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)

    [<Test>]
    let eFilter_isDividend_ListE_1() =
      let tapeListE = BodyE(20,BodyE(21,BodyE(25,BodyE(30,BodyE(40,EmptyE)))))
              
      let _expectedVal = BodyE(20,BodyE(30,BodyE(40,EmptyE)))
      let _reachedVal = eFilter isDividend10 tapeListE 
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eFilter_isEven_ListE_1() =
      let tapeListE = BodyE(3,BodyE(6,BodyE(8,BodyE(9,BodyE(13,EmptyE)))))
              
      let _expectedVal = BodyE(6,BodyE(8,EmptyE))
      let _reachedVal = eFilter isEven tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eFoldLeft_isEven_listE_listE_1() =
      let tapeListE = BodyE(3,BodyE(6,BodyE(8,BodyE(9,BodyE(13,EmptyE)))))
              
      let _expectedVal = BodyE(false,BodyE(true,BodyE( true, BodyE( false, BodyE( false,EmptyE ) ) )))
      let _reachedVal = eFoldLeft isEven EmptyE tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eFoldLeft_PowPart_listE_listE_2() =
      let tapeListE = BodyE(3,BodyE(6,BodyE(8,BodyE(9,BodyE(13,EmptyE)))))
              
      let _expectedVal = BodyE(9,BodyE(36,BodyE( 64, BodyE( 81, BodyE( 169,EmptyE ) ) )))
      let _reachedVal = eFoldLeft (pow 2) EmptyE tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eFoldLeft_eConcat_ListE_ListEListE_1() =
      let fstTapeListE = BodyE(5,BodyE(4,BodyE(3,BodyE(2,EmptyE))))
      let sndTapeListE = BodyE(1,BodyE(2,BodyE(3,BodyE(4,BodyE(5,BodyE(6,EmptyE))))))
      let finalTapeListE = BodyE( fstTapeListE, BodyE( sndTapeListE, EmptyE ) )
              
      let _expectedVal = BodyE(5,BodyE(4,BodyE(3,BodyE(2,BodyE(1,BodyE(2,BodyE(3,BodyE(4,BodyE(5,BodyE(6,EmptyE))))))))))
      let _reachedVal = eFoldLeftForFlat (@) EmptyE finalTapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eConcat_ListEListE_1() =
      let fstTapeListE = BodyE(5,BodyE(4,BodyE(3,BodyE(2,EmptyE))))
      let sndTapeListE = BodyE(1,BodyE(2,BodyE(3,BodyE(4,BodyE(5,BodyE(6,EmptyE))))))
              
      let _expectedVal = BodyE(5,BodyE(4,BodyE(3,BodyE(2,BodyE(1,BodyE(2,BodyE(3,BodyE(4,BodyE(5,BodyE(6,EmptyE))))))))))
      let _reachedVal = fstTapeListE @ sndTapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)