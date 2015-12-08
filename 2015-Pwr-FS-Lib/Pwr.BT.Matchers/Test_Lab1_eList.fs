namespace Pwr.BT.Test
    module Test_Lab1_eList =
    
    open System
    open System.Collections
    open NUnit.Framework
    open NUnit.Framework.Constraints
    open Pwr.BT.Types
    open Pwr.BT.Collections.Own.ListEager
    open Pwr.BT.Collections.Tuple.Operations

    [<Test>]
    let eSum_ListE_Int_1() =
      let tapeListe = BodyE(5.,BodyE(3.,BodyE(2.,EmptyE)))
        
      let _expectedVal = 10.
      let _reachedVal = eSum tapeListe
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eSum_ListE_Int_2() =
      let tapeListe = BodyE(0.,BodyE(1.,BodyE(-2.,EmptyE)))
        
      let _expectedVal = -1.
      let _reachedVal = eSum tapeListe
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eSum_ListE_Int_3() =
      let tapeListe = BodyE(0.,EmptyE)
        
      let _expectedVal = 0.
      let _reachedVal = eSum tapeListe
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eSum_ListE_Int_4() =
      let tapeListe = EmptyE
        
      let _expectedVal = 0.
      let _reachedVal = eSum tapeListe
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let sum4_FloatTup4_Float_1() =
      let tapeTup4 = (3.,2.,5.,1.)
        
      let _expectedVal = 11.
      let _reachedVal = sum4 tapeTup4
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let sum4_FloatTup4_Float_2() =
      let tapeTup4 = (0.,0.,0.,1.)
        
      let _expectedVal = 1.
      let _reachedVal = sum4 tapeTup4
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let sum4_FloatTup4_Float_3() =
      let tapeTup4 = (1.,1.,1.,1.)
        
      let _expectedVal = 4.
      let _reachedVal = sum4 tapeTup4
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eMergInSepS_StrlistE_Str_1() =
      let tapeListE = BodyE( "To", BodyE( "jest", BodyE( "napis", EmptyE) ) )
      let infixListE = BodyE( "-", EmptyE)

      let _expectedVal = "To-jest-napis"
      let _reachedVal = eMergInSepS tapeListE infixListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eMergInSepS_StrlistE_Str_2() =
      let tapeListE = BodyE( "To", BodyE( "jest", BodyE( "napis", EmptyE) ) )
      let infixListE = BodyE( "___", EmptyE)

      let _expectedVal = "To___jest___napis"
      let _reachedVal = eMergInSepS tapeListE infixListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eMergInSepS_StrlistE_Str_3() =
      let tapeListE = BodyE( "To", EmptyE )
      let infixListE = BodyE( "___", EmptyE)

      let _expectedVal = "To"
      let _reachedVal = eMergInSepS tapeListE infixListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eMergInSepS_StrlistE_Str_4() =
      let tapeListE = EmptyE
      let infixListE = BodyE( "___", EmptyE)

      let _expectedVal = ""
      let _reachedVal = eMergInSepS tapeListE infixListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let ePartOrdCompare_pListE_pListE_1() =
      let tapeListE = BodyE( 1, BodyE( 2, BodyE( 3, BodyE( 4, EmptyE ))))
      let comparedListE = BodyE( 5, EmptyE)

      let _expectedVal = true
      let _reachedVal = ePartOrdCompare tapeListE comparedListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let ePartOrdCompare_pListE_pListE_2() =
      let tapeListE = BodyE( 6, BodyE( 1, BodyE( 3, BodyE( 2, EmptyE ))))
      let comparedListE = BodyE( 6, EmptyE)

      let _expectedVal = false
      let _reachedVal = ePartOrdCompare tapeListE comparedListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let ePartOrdCompare_pListE_pListE_3() =
      let tapeListE = BodyE( "aa", BodyE( "ab", BodyE( "ac", BodyE( "ad", EmptyE ))))
      let comparedListE = BodyE( "bb", EmptyE)

      let _expectedVal = true
      let _reachedVal = ePartOrdCompare tapeListE comparedListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let third3_AnyTup3_Any_1() =
      let tapeTup3 = (3.,2.,5.)
        
      let _expectedVal = 5.
      let _reachedVal = thrd3 tapeTup3
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let third3_AnyTup3_Any_2() =
      let tapeTup3 = ("ab",2.,3)
        
      let _expectedVal = 3
      let _reachedVal = thrd3 tapeTup3
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let third3_AnyTup3_Any_3() =
      let tapeTup3 = (0,1,'a')
        
      let _expectedVal = 'a'
      let _reachedVal = thrd3 tapeTup3
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let genListIncl_Int_Int_1() =
      let tapeBeginE = BodyE( 4, EmptyE )
      let tapeEndE = BodyE( 8, EmptyE )

      let _expectedVal =  BodyE( 4, BodyE( 5, BodyE( 6, BodyE( 7, BodyE( 8, EmptyE ) ))))
      let _reachedVal = genListIncl tapeBeginE tapeEndE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let genListIncl_Int_Int_2() =
      let tapeBeginE = BodyE( 4, EmptyE )
      let tapeEndE = BodyE( 4, EmptyE )

      let _expectedVal =  BodyE( 4, EmptyE )
      let _reachedVal = genListIncl tapeBeginE tapeEndE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let genListIncl_Int_Int_3() =
      let tapeBeginE = BodyE( 4, EmptyE )
      let tapeEndE = BodyE( 5, EmptyE )

      let _expectedVal =  BodyE( 4, BodyE( 5, EmptyE ) )
      let _reachedVal = genListIncl tapeBeginE tapeEndE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let genListIncl_Int_Int_4() =
      let tapeBeginE = BodyE( 5, EmptyE )
      let tapeEndE = BodyE( 4, EmptyE )

      let _expectedVal = EmptyE
      let _reachedVal = genListIncl tapeBeginE tapeEndE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

