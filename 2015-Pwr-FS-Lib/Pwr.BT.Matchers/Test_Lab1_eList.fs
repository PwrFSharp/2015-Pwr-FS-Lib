namespace Pwr.BT.Test
    module Test_Lab1_eList =
    
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


