namespace Pwr.BT.Test
    module Test_Lab7_eList =
    
    open System
    open System.Collections
    open NUnit.Framework
    open NUnit.Framework.Constraints
    open Pwr.BT.Types
    open Pwr.BT.Collections.List.Iter
    open Pwr.BT.Collections.Own.ListEager.Atomic
    open Pwr.BT.Collections.Tuple.Operations
    open Pwr.BT.Collections.Own.ListEager.Functionals

    [<Test>]
    let mergeBraid_ListE_ListE_1() =
      let fstTapeListE = BodyE(1,BodyE(3,BodyE(5,BodyE(7,BodyE(9,BodyE(11,EmptyE))))))
      let sndTapeListE = BodyE(2,BodyE(4,BodyE(6,BodyE(8,EmptyE))))

      let _expectedVal = BodyE(1,BodyE(2,BodyE(3,BodyE(4,BodyE(5,BodyE(6,BodyE(7,BodyE(8,BodyE(9,BodyE(11,EmptyE))))))))))
      let _reachedVal = eMergeBraid fstTapeListE sndTapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let mergeBraid_ListE_ListE_3() =
      let fstTapeListE = BodyE(5,BodyE(4,BodyE(3,BodyE(2,EmptyE))))
      let sndTapeListE = BodyE(1,BodyE(2,BodyE(3,BodyE(4,BodyE(5,BodyE(6,EmptyE))))))
              
      let _expectedVal = BodyE(5,BodyE(1,BodyE(4,BodyE(2,BodyE(3,BodyE(3,BodyE(2,BodyE(4,BodyE(5,BodyE(6,EmptyE))))))))))
      let _reachedVal = eMergeBraid fstTapeListE sndTapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let powiel_ListE_1() =
      let tapeListE = BodyE(1,BodyE(2,BodyE(3,EmptyE)))
              
      let _expectedVal = BodyE(1,BodyE(2,BodyE(2,BodyE(3,BodyE(3,BodyE(3,EmptyE))))))
      let _reachedVal = powiel tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let powiel_ListE_2() =
      let tapeListE = BodyE(0,EmptyE)
              
      let _expectedVal = EmptyE
      let _reachedVal = powiel tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
