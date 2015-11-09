namespace Pwr.BT.Test.MatcherAndTR
    module List =    
      open System
      open System.Collections
      open NUnit.Framework
      open NUnit.Framework.Constraints
      open Pwr.BT.MatcherAndTR.List
    
//        [<Test>]
//        let Flatten() =
//          // arrange
//          let _inputVal1 = [1;2;3]
//          let _inputVal2 = [4;5;6]
//          let _inputCummVal1 = [_inputVal1;_inputVal2]
//          let _expectedVal = [1;2;3;4;5;6]
//
//          // act
//          let _reachedVal = flatten ( _inputCummVal1 )
//          printfn "Reached: %A" _reachedVal     
//               
//          // assert
//          let _reachedLogic = _expectedVal = _reachedVal
//          Assert.True(_reachedLogic)
          [<Test>]
          let Append() =
            let _inputVal1 = [1;2;3]
            let _inputVal2 = [4;5;6]
          
            let _expectedVal = [1;2;3;4;5;6]
            let _reachedVal = append _inputVal1 _inputVal2

            printfn "Reached: %A" _reachedVal
          
            Assert.AreEqual(_expectedVal,_reachedVal)