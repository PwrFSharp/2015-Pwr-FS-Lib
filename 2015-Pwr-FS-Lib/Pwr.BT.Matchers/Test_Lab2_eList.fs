namespace Pwr.BT.Test
    module Test_Lab2_eList =
    
    open System
    open System.Collections
    open NUnit.Framework
    open NUnit.Framework.Constraints
    open Pwr.BT.Types
    open Pwr.BT.Collections.Own.ListEager.Atomic
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
    let eMergeBraid_ListE_ListE_1() =
      let fstTapeListE = BodyE(5,BodyE(4,BodyE(3,BodyE(2,EmptyE))))
      let sndTapeListE = BodyE(1,BodyE(2,BodyE(3,BodyE(4,BodyE(5,BodyE(6,EmptyE))))))
              
      let _expectedVal = BodyE(5,BodyE(1,BodyE(4,BodyE(2,BodyE(3,BodyE(3,BodyE(2,BodyE(4,BodyE(5,BodyE(6,EmptyE))))))))))
      let _reachedVal = eMergeBraid fstTapeListE sndTapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eMergeBraid_ListE_ListE_2() =
      let fstTapeListE = BodyE(5,BodyE(4,BodyE(3,BodyE(2,EmptyE))))
      let sndTapeListE = EmptyE
              
      let _expectedVal = BodyE(5,BodyE(4,BodyE(3,BodyE(2,EmptyE))))
      let _reachedVal = eMergeBraid fstTapeListE sndTapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eMergeBraid_ListE_ListE_3() =
      let fstTapeListE = EmptyE
      let sndTapeListE = EmptyE
              
      let _expectedVal = EmptyE
      let _reachedVal = eMergeBraid fstTapeListE sndTapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eMergeBraid_ListE_ListE_4() =
      let fstTapeListE = EmptyE
      let sndTapeListE = BodyE(5,BodyE(4,BodyE(3,BodyE(2,EmptyE))))
              
      let _expectedVal = BodyE(5,BodyE(4,BodyE(3,BodyE(2,EmptyE))))
      let _reachedVal = eMergeBraid fstTapeListE sndTapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eRev_ListE_1() =
      let tapeListE = BodyE(5,BodyE(4,BodyE(3,BodyE(2,EmptyE))))
              
      let _expectedVal = BodyE(2,BodyE(3,BodyE(4,BodyE(5,EmptyE))))
      let _reachedVal = eRev tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eRev_ListE_2() =
      let tapeListE = EmptyE
              
      let _expectedVal = EmptyE
      let _reachedVal = eRev tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eRev_ListE_3() =
      let tapeListE = BodyE( 1, EmptyE )
              
      let _expectedVal = BodyE( 1, EmptyE )
      let _reachedVal = eRev tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eRev_ListE_4() =
      let tapeListE = BodyE( 1, BodyE( 2, EmptyE ) )
              
      let _expectedVal = BodyE( 2, BodyE( 1, EmptyE ) )
      let _reachedVal = eRev tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eBranchBy10y5Even_ListE_ListE2_1() =
      let tapeListE = BodyE(20,BodyE(21,BodyE(25,BodyE(30,BodyE(40,EmptyE)))))
        
      let _fstExpectedVal2 = BodyE(20,BodyE(30,BodyE(40,EmptyE)))
      let _sndExpectedVal2 = BodyE(20,BodyE(25,BodyE(30,BodyE(40,EmptyE))))
      let _thrdExpectedVal2 = BodyE(21,EmptyE)
      
      let _expectedVal = (_fstExpectedVal2,_sndExpectedVal2,_thrdExpectedVal2)
      let _reachedVal = eBranchBy10y5Even tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eBranchBy10y5Even_ListE_ListE2_2() =
      let tapeListE = BodyE(20,BodyE(40,BodyE(60,BodyE(100,EmptyE))))
        
      let _fstExpectedVal2 = BodyE(20,BodyE(40,BodyE(60,BodyE( 100, EmptyE ))))
      let _sndExpectedVal2 = BodyE(20,BodyE(40,BodyE(60,BodyE( 100, EmptyE ))))
      let _thrdExpectedVal2 = EmptyE
      
      let _expectedVal = (_fstExpectedVal2,_sndExpectedVal2,_thrdExpectedVal2)
      let _reachedVal = eBranchBy10y5Even tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eBranchBy10y5Even_ListE_ListE2_3() =
      let tapeListE = BodyE(25,BodyE(45,BodyE(65,BodyE(105,EmptyE))))
        
      let _fstExpectedVal2 = EmptyE
      let _sndExpectedVal2 = BodyE(25,BodyE(45,BodyE(65,BodyE(105,EmptyE))))
      let _thrdExpectedVal2 = EmptyE
      
      let _expectedVal = (_fstExpectedVal2,_sndExpectedVal2,_thrdExpectedVal2)
      let _reachedVal = eBranchBy10y5Even tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eBranchBy10y5Even_ListE_ListE2_4() =
      let tapeListE = EmptyE
        
      let _fstExpectedVal2 = EmptyE
      let _sndExpectedVal2 = EmptyE
      let _thrdExpectedVal2 = EmptyE
      
      let _expectedVal = (_fstExpectedVal2,_sndExpectedVal2,_thrdExpectedVal2)
      let _reachedVal = eBranchBy10y5Even tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

