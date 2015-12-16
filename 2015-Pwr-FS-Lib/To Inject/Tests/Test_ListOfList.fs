namespace Pwr.BT.Test
    module Test_ListOfLists =
    
    open NUnit.Framework
    open Pwr.BT.Collections.List
    open Pwr.BT.Collections.List.Oper
    
    [<Test>]
    let Oper_FlattenM_True() =
      let _inputVal1 = [1;2;1]
      let _inputVal2 = [1;2;1]
      let _inputCummVal1 = [[1;2;1];[1;2;1]]
        
      let _expectedVal = [1;2;1;1;2;1]
      let _reachedVal = flattenM _inputCummVal1
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
