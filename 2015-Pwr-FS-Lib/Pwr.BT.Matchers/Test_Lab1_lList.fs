namespace Pwr.BT.Test
    module Test_Lab1_lList =
    
    open System
    open System.Collections
    open NUnit.Framework
    open NUnit.Framework.Constraints
    open Pwr.BT.Types
    open Pwr.BT.Collections.Own.ListLazy.Atomic
    open Pwr.BT.Collections.Tuple.Operations

    [<Test>]
    let eSum_ListE_Int_1() =
      let tapeListe = BodyL(5,fun()->BodyL(3,fun()->BodyL(2,fun()->EmptyL)))
        
      let _expectedVal = 10
      let _reachedVal = lSum tapeListe
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eSum_ListE_Int_2() =
//      let tapeListe = BodyL(0.,BodyL(1.,BodyL(-2.,EmptyL)))
//        
//      let _expectedVal = -1.
//      let _reachedVal = eSum tapeListe
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eSum_ListE_Int_3() =
//      let tapeListe = BodyL(0.,EmptyL)
//        
//      let _expectedVal = 0.
//      let _reachedVal = eSum tapeListe
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eSum_ListE_Int_4() =
//      let tapeListe = EmptyL
//        
//      let _expectedVal = 0.
//      let _reachedVal = eSum tapeListe
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let sum4_FloatTup4_Float_2() =
//      let tapeTup4 = (0.,0.,0.,1.)
//        
//      let _expectedVal = 1.
//      let _reachedVal = sum4 tapeTup4
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let sum4_FloatTup4_Float_3() =
//      let tapeTup4 = (1.,1.,1.,1.)
//        
//      let _expectedVal = 4.
//      let _reachedVal = sum4 tapeTup4
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)

//    [<Test>]
//    let eMergInSepS_StrlistE_Str_1() =
//      let tapeListE = BodyL( "To", fun()->BodyL( "jest", fun()->BodyL( "napis", fun()->EmptyL) ) )
//      let infixListE = BodyL( "-", fun()->EmptyL)
//
//      let _expectedVal = "To-jest-napis"
//      let _reachedVal = lMergInSepS tapeListE infixListE
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eMergInSepS_StrlistE_Str_2() =
//      let tapeListE = BodyL( "To", BodyL( "jest", BodyL( "napis", EmptyL) ) )
//      let infixListE = BodyL( "___", EmptyL)
//
//      let _expectedVal = "To___jest___napis"
//      let _reachedVal = eMergInSepS tapeListE infixListE
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eMergInSepS_StrlistE_Str_3() =
//      let tapeListE = BodyL( "To", EmptyL )
//      let infixListE = BodyL( "___", EmptyL)
//
//      let _expectedVal = "To"
//      let _reachedVal = eMergInSepS tapeListE infixListE
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let eMergInSepS_StrlistE_Str_4() =
//      let tapeListE = EmptyL
//      let infixListE = BodyL( "___", EmptyL)
//
//      let _expectedVal = ""
//      let _reachedVal = eMergInSepS tapeListE infixListE
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)

    [<Test>]
    let ePartOrdCompare_pListE_pListE_1() =
      let tapeListE = BodyL( 1, fun()->BodyL( 2, fun()->BodyL( 3, fun()->BodyL( 4, fun()->EmptyL ))))
      let comparedListE = BodyL( 5, fun()->EmptyL)

      let _expectedVal = true
      let _reachedVal = lPartOrdCompare tapeListE comparedListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let lDuplicate_El_Int_1() =
      let el = "ab"
      let multipl = 3
              
      let _expectedVal = [ "ab" ; "ab" ; "ab"]
      let _reachedVal = lToNative (lDuplicate el multipl)
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let ePartOrdCompare_pListE_pListE_2() =
//      let tapeListE = BodyL( 6, BodyL( 1, BodyL( 3, BodyL( 2, EmptyL ))))
//      let comparedListE = BodyL( 6, EmptyL)
//
//      let _expectedVal = false
//      let _reachedVal = ePartOrdCompare tapeListE comparedListE
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let ePartOrdCompare_pListE_pListE_3() =
//      let tapeListE = BodyL( "aa", BodyL( "ab", BodyL( "ac", BodyL( "ad", EmptyL ))))
//      let comparedListE = BodyL( "bb", EmptyL)
//
//      let _expectedVal = true
//      let _reachedVal = ePartOrdCompare tapeListE comparedListE
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let third3_AnyTup3_Any_2() =
//      let tapeTup3 = ("ab",2.,3)
//        
//      let _expectedVal = 3
//      let _reachedVal = thrd3 tapeTup3
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let third3_AnyTup3_Any_3() =
//      let tapeTup3 = (0,1,'a')
//        
//      let _expectedVal = 'a'
//      let _reachedVal = thrd3 tapeTup3
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let genListIncl_Int_Int_1() =
//      let tapeBeginE = BodyL( 4, fun()->EmptyL )
//      let tapeEndE = BodyL( 8,fun()-> EmptyL )
//
//      let _expectedVal =  BodyL( 4,fun()-> BodyL( 5, fun()->BodyL( 6, fun()->BodyL( 7,fun()-> BodyL( 8, fun()->EmptyL ) ))))
//      let _reachedVal = lGenListIncl tapeBeginE tapeEndE
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let genListIncl_Int_Int_2() =
//      let tapeBeginE = BodyL( 4, EmptyL )
//      let tapeEndE = BodyL( 4, EmptyL )
//
//      let _expectedVal =  BodyL( 4, EmptyL )
//      let _reachedVal = genListIncl tapeBeginE tapeEndE
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let genListIncl_Int_Int_3() =
//      let tapeBeginE = BodyL( 4, EmptyL )
//      let tapeEndE = BodyL( 5, EmptyL )
//
//      let _expectedVal =  BodyL( 4, BodyL( 5, EmptyL ) )
//      let _reachedVal = genListIncl tapeBeginE tapeEndE
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let genListIncl_Int_Int_4() =
//      let tapeBeginE = BodyL( 5, EmptyL )
//      let tapeEndE = BodyL( 4, EmptyL )
//
//      let _expectedVal = EmptyL
//      let _reachedVal = genListIncl tapeBeginE tapeEndE
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)

