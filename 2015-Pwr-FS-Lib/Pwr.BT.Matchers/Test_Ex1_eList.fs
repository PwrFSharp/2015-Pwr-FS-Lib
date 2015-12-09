namespace Pwr.BT.Test
    module Test_Ex1_eList =
    
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

    [<Test>]
    let eConcat_ListE_ListE_1() =
      let fstTapeListE = BodyE(5,EmptyE)
      let sndTapeListE = BodyE(1,EmptyE)
              
      let _expectedVal = BodyE(5,BodyE(1,EmptyE))
      let _reachedVal = fstTapeListE @ sndTapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eConcat_ListE_ListE_2() =
//      let fstTapeListE = EmptyE
//      let sndTapeListE = EmptyE
//              
//      let _expectedVal = EmptyE
//      let _reachedVal = fstTapeListE @ sndTapeListE
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eConcat_ListE_ListE_3() =
//      let fstTapeListE = BodyE(5,BodyE(1,EmptyE))
//      let sndTapeListE = EmptyE
//              
//      let _expectedVal = BodyE(5,BodyE(1,EmptyE))
//      let _reachedVal = fstTapeListE @ sndTapeListE
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eConcat_ListE_ListE_4() =
//      let fstTapeListE = EmptyE
//      let sndTapeListE = BodyE(5,BodyE(1,EmptyE))
//              
//      let _expectedVal = BodyE(5,BodyE(1,EmptyE))
//      let _reachedVal = fstTapeListE @ sndTapeListE
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)

    [<Test>]
    let eContains_ListE_ListE_1() =
      let tapeListE = EmptyE
      let el = 5.
              
      let _expectedVal = false
      let _reachedVal = eContains el tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eContains_ListE_ListE_2() =
//      let tapeListE = BodyE(5.,BodyE(1.,BodyE(1.,BodyE(5.,EmptyE))))
//      let el = 5.
//              
//      let _expectedVal = true
//      let _reachedVal = eContains el tapeListE
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eContains_ListE_ListE_3() =
//      let tapeListE = BodyE(5.,BodyE(1.,BodyE(1.,BodyE(5.,EmptyE))))
//      let el = 2.
//              
//      let _expectedVal = false
//      let _reachedVal = eContains el tapeListE
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)

    [<Test>]
    let eDuplicate_El_Int_1() =
      let el = "ab"
      let multipl = 3
              
      let _expectedVal = BodyE( "ab" ,BodyE( "ab" ,BodyE( "ab", EmptyE )))
      let _reachedVal = eDuplicate el multipl
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eDuplicate_El_Int_2() =
//      let el = 3
//      let multipl = 3
//              
//      let _expectedVal = BodyE( 3 ,BodyE( 3 ,BodyE( 3, EmptyE )))
//      let _reachedVal = eDuplicate el multipl
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eDuplicate_El_Int_3() =
//      let el = [1;2;3]
//      let multipl = 0
//              
//      let _expectedVal = EmptyE
//      let _reachedVal = eDuplicate el multipl
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
    [<Test>]
    let eFlatten_eListeList_1() =
      let fstTapeListE = BodyE( 5, BodyE( 6, EmptyE ))
      let sndTapeListE =  BodyE( 1, BodyE( 2, BodyE( 3, EmptyE )))
      let tapeListE =  BodyE( fstTapeListE, BodyE( sndTapeListE, EmptyE ) )
              
      let _expectedVal = BodyE( 5, BodyE( 6, BodyE( 1, BodyE( 2, BodyE( 3, EmptyE ) ) ) ) )
      let _reachedVal = eFlatten tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)





