namespace Pwr.BT.Test
    module Test_NumericE =
   
    open NUnit.Framework
    open Pwr.BT.Collections.Own.ListEager.eNumericOperations

    [<Test>]
    let Pow_Int_ListE_1() =
      let baseVal = 2
      let exponentVal = 3
              
      let _expectedVal = 8
      let _reachedVal = pow exponentVal baseVal
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let Pow_Int_ListE_2() =
      let baseVal = 2
      let exponentVal = 0
              
      let _expectedVal = 1
      let _reachedVal = pow exponentVal baseVal
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let Pow_Int_ListE_3() =
      let baseVal = 2
      let exponentVal = 1
              
      let _expectedVal = 2
      let _reachedVal = pow exponentVal baseVal
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let Pow_Int_ListE_4() =
      let baseVal = 0
      let exponentVal = 8
              
      let _expectedVal = 0
      let _reachedVal = pow exponentVal baseVal
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

