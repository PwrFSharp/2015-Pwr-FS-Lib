namespace Pwr.BT.Test
    module Test_ListL =
    
    open System
    open System.Collections
    open NUnit.Framework
    open NUnit.Framework.Constraints
    open Pwr.BT.Types
    open Pwr.BT.Collections.List.Iter
    open Pwr.BT.Collections.Own.ListLazy.Atomic
    open Pwr.BT.Collections.Tuple.Operations
    open Pwr.BT.Numeric.Predicates
    open Pwr.BT.Collections.Own.ListLazy.Functionals
//    open Pwr.BT.Collections.Own.ListEager.eNumericOperations
//
//    [<Test>]
//    let eMap_eSize_ListE_1() =
//      let tapeListE = BodyL(BodyL(5,BodyL(1,EmptyL)),BodyL(BodyL(5,BodyL(1,BodyL(1,EmptyL))),EmptyL))
//              
//      let _expectedVal = BodyL(2,BodyL(3,EmptyL))
//      let _reachedVal = eMap eSize tapeListE 
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eMap_eRev_ListE_1() =
//      let tapeListE = BodyL(BodyL(5,BodyL(1,EmptyL)),BodyL(BodyL(5,BodyL(1,BodyL(1,EmptyL))),EmptyL))
//              
//      let _expectedVal = BodyL(BodyL(1,BodyL(5,EmptyL)),BodyL(BodyL(1,BodyL(1,BodyL(5,EmptyL))),EmptyL))
//      let _reachedVal = eMap eRev tapeListE 
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eMap_eSum_ListE_1() =
//      let tapeListE = BodyL(BodyL(5.,BodyL(1.,EmptyL)),BodyL(BodyL(5.,BodyL(1.,BodyL(1.,EmptyL))),EmptyL))
//              
//      let _expectedVal = BodyL(6.,BodyL(7.,EmptyL))
//      let _reachedVal = eMap eSum tapeListE 
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eMap_eAdd3_ListE_1() =
//      let tapeListE = BodyL(5,BodyL( 4, BodyL( 3, BodyL( 2, EmptyL ) ) ))
//              
//      let _expectedVal = BodyL(8,BodyL( 7, BodyL( 6, BodyL( 5, EmptyL ) ) ))
//      let _reachedVal = eMap (fun x-> x+3) tapeListE 
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eMap_eStickListWithIdxAsc_ListE_1() =
//      let tapeListE = BodyL( BodyL(5,BodyL(1,BodyL(1,BodyL(4,EmptyL)))), EmptyL )
//              
//      let _expectedVal = BodyL( BodyL((5,0),BodyL((1,1),BodyL((1,2), BodyL((4,3), EmptyL ) ))), EmptyL )
//      let _reachedVal = eMap eStickListWithIdxAsc tapeListE 
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eStickListWithIdxAsc_ListE_1() =
//      let tapeListE = BodyL(5,BodyL(1,BodyL(1,BodyL(4,EmptyL))))
//              
//      let _expectedVal = BodyL((5,0),BodyL((1,1),BodyL((1,2), BodyL((4,3), EmptyL ) )))
//      let _reachedVal = eStickListWithIdxAsc tapeListE 
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eStickListWithIdxAsc_ListE_2() =
//      let tapeListE = EmptyL
//              
//      let _expectedVal = EmptyL
//      let _reachedVal = eStickListWithIdxAsc tapeListE 
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eStickListWithIdxAsc_ListE_3() =
//      let tapeListE = BodyL( 1., EmptyL )
//              
//      let _expectedVal = BodyL(( 1.,0), EmptyL )
//      let _reachedVal = eStickListWithIdxAsc tapeListE 
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eStickListWithIdxDesc_ListE_1() =
//      let tapeListE = BodyL(5,BodyL(1,BodyL(1,BodyL(4,EmptyL))))
//              
//      let _expectedVal = BodyL((5,3),BodyL((1,2),BodyL((1,1), BodyL((4,0), EmptyL ) )))
//      let _reachedVal = eStickListWithIdxDesc tapeListE 
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eStickListWithIdxDesc_ListE_2() =
//      let tapeListE = EmptyL
//              
//      let _expectedVal = EmptyL
//      let _reachedVal = eStickListWithIdxDesc tapeListE 
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eStickListWithIdxDesc_ListE_3() =
//      let tapeListE = BodyL( 1., EmptyL )
//              
//      let _expectedVal = BodyL(( 1.,0), EmptyL )
//      let _reachedVal = eStickListWithIdxDesc tapeListE 
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)

    [<Test>]
    let eFilter_isDividend_ListE_1() =
      let tapeListE = BodyL(20,fun()->BodyL(21,fun()->BodyL(25,fun()->BodyL(30,fun()->BodyL(40,fun()->EmptyL)))))
              
      let _expectedVal = [20;30;40]
      let _reachedVal = lToNative (lFilter isDividend10 tapeListE )
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eFilter_isEven_ListE_1() =
//      let tapeListE = BodyL(3,BodyL(6,BodyL(8,BodyL(9,BodyL(13,EmptyL)))))
//              
//      let _expectedVal = BodyL(6,BodyL(8,EmptyL))
//      let _reachedVal = eFilter isEven tapeListE
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)

    [<Test>]
    let eFoldLeft_isEven_listE_listE_1() =
      let tapeListE = BodyL(3,fun()->BodyL(6,fun()->BodyL(8,fun()->BodyL(9,fun()->BodyL(13,fun()->EmptyL)))))
              
      let _expectedVal = [false;true;true;false;false]
      let _reachedVal = lToNative (lFoldLeftOneArg isEven EmptyL tapeListE)
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

//    [<Test>]
//    let eFoldLeft_PowPart_listE_listE_2() =
//      let tapeListE = BodyL(3,BodyL(6,BodyL(8,BodyL(9,BodyL(13,EmptyL)))))
//              
//      let _expectedVal = BodyL(9,BodyL(36,BodyL( 64, BodyL( 81, BodyL( 169,EmptyL ) ) )))
//      let _reachedVal = eFoldLeft (pow 2) EmptyL tapeListE
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)

    [<Test>]
    let eFoldLeft_eConcat_ListE_ListEListE_1() =
      let fstTapeListE = BodyL(5,fun()->BodyL(4,fun()->BodyL(3,fun()->BodyL(2,fun()->EmptyL))))
      let sndTapeListE = BodyL(1,fun()->BodyL(2,fun()->BodyL(3,fun()->BodyL(4,fun()->BodyL(5,fun()->BodyL(6,fun()->EmptyL))))))
      let finalTapeListE = BodyL( fstTapeListE, fun()->BodyL( sndTapeListE, fun()->EmptyL ) )
              
      let _expectedVal = [5;4;3;2;1;2;3;4;5;6]
      let _reachedVal = lToNative (lFoldLeftForFlat (@) EmptyL finalTapeListE)
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eConcat_ListEListE_1() =
//      let fstTapeListE = BodyL(5,BodyL(4,BodyL(3,BodyL(2,EmptyL))))
//      let sndTapeListE = BodyL(1,BodyL(2,BodyL(3,BodyL(4,BodyL(5,BodyL(6,EmptyL))))))
//              
//      let _expectedVal = BodyL(5,BodyL(4,BodyL(3,BodyL(2,BodyL(1,BodyL(2,BodyL(3,BodyL(4,BodyL(5,BodyL(6,EmptyL))))))))))
//      let _reachedVal = fstTapeListE @ sndTapeListE
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)