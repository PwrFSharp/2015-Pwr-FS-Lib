namespace Pwr.BT.Test
    module Test_RefToLists =
    
    open System
    open System.Collections
    open NUnit.Framework
    open NUnit.Framework.Constraints
    open Pwr.BT.Types
    open Pwr.BT.Collections.List.Iter
    open Pwr.BT.Collections.ReferencesToLists

    [<Test>]
    let ListReferences1_ReadingHeadFromReference() =
      let tapeli = [1;2;3;4]
      let tapeRef = ref tapeli
        
      let _expectedVal = 1
      let _reachedVal = List.head !tapeRef
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let rev_ArgAsAReference() =
      let (_inTape:eval list) = [Num 5.0; Num 3.0; Add; Num 2.0; Add]
      let _inTapeRef = ref _inTape
        
      let _expectedVal = Add
      let _reachedVal = List.head (rev !_inTapeRef)
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let ModifyByReffernce_DeletingHead() =
      let _inTape = [Num 5.0; Num 3.0; Add; Num 2.0; Add]
      let refTape = ref _inTape
//      let _inTapeRef = ref _inTape
        
      let _expectedVal = [Num 3.0; Add; Num 2.0; Add]
      let _reachedVal = headRemover (refTape)
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)