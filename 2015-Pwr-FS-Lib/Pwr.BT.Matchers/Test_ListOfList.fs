namespace Pwr.BT.Test.MatcherAndTR
    module ListOfLists =
      open System
      open System.Collections
      open NUnit.Framework
      open NUnit.Framework.Constraints
      open Pwr.BT.MatcherAndTR.List
      open Pwr.BT.MatcherAndTR.ListOfLists
    
        [<Test>]
        let Flatten() =
          // arrange
          let _inputVal1 = [1;2;3]
          let _inputVal2 = [4;5;6]
          let _inputCummVal1 = [_inputVal1;_inputVal2]
          let _expectedVal = [1;2;3;4;5;6]

          // act
          let _reachedVal = flatten ( _inputCummVal1 )
          printfn "Reached: %A" _reachedVal
               
          // assert
          let _reachedLogic = _expectedVal = _reachedVal
          Assert.True(_reachedLogic)

        [<Test>]
        let Iterator1() =
          // arrange
          let _inputVal1 = []
          let _expectedVal = []

          // act
          let _reachedVal = iterator _inputVal1

          // assert
          let _reachedLogic = _expectedVal = _reachedVal
          Assert.IsTrue(_reachedLogic)

        [<Test>]
        let Iterator2() =
          // arrange
          let _inputVal1 = [3;2;3]
          let _expectedVal = [3;2;3]

          // act
          let _reachedVal = iterator _inputVal1

          // assert
          let _reachedLogic = _expectedVal = _reachedVal
          Assert.IsTrue(_reachedLogic)       

        [<Test>]
        let Iterator3() =
          // arrange
          let _inputVal1 = [1;2;3]
          let _expectedVal = [3;2;1]

          // act
          let _reachedVal = iterator _inputVal1

          // assert
          let _reachedLogic = _expectedVal = _reachedVal
          Assert.IsTrue(_reachedLogic)