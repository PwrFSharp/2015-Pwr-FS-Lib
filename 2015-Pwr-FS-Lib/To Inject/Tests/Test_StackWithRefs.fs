namespace Pwr.BT.Test
    module Test_StackWithRefs =
    
    open NUnit.Framework
    open Pwr.BT.Collections.Stack.OperRef
    open Pwr.BT.Types

    [<Test>]
    let Functors_PushBackRef() =
      let tapeli = [1;2;3;4]
      let tapeLiRef = ref tapeli
      let el = 5
        
      let _expectedVal = [1;2;3;4;5]
      pushSRef(tapeLiRef,el)
    
      let _reachedLogic = _expectedVal = !tapeLiRef
    
      Assert.True(_reachedLogic)

    [<Test>]
    let Functors_PopRef() =
      let tapeli = [1;2;3;4]
      let tapeliRef = ref tapeli
        
      let _expectedVal = [1;2;3]
      popRef tapeliRef
    
      let _reachedLogic = _expectedVal = !tapeliRef
    
      Assert.True(_reachedLogic)

    [<Test>]
    let Functors_Count4() =
      let tapeli = [Empty;Node(2,Empty,Node(3,Empty,Empty));Empty;Empty]
      let tapeliRef = ref tapeli
        
      let _expectedVal = 4
      let _reachedVal = count tapeliRef
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let Functors_Count1() =
      let tapeli = [Node(2,Empty,Node(3,Empty,Empty))]
      let tapeliRef = ref tapeli
        
      let _expectedVal = 1
      let _reachedVal = count tapeliRef
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let Functors_Count0() =
      let tapeli = []
      let tapeliRef = ref tapeli
        
      let _expectedVal = 0
      let _reachedVal = count tapeliRef
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let Functors_Back() =
//      let tapeli = [1;2;3;4]
//        
//      let _expectedVal = 4
//      let _reachedVal = backNR tapeli
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let ListReferences1_ReadingHeadFromReference() =
//      let tapeli = [1;2;3;4]
//      let tapeRef = ref tapeli
//        
//      let _expectedVal = 1
//      let _reachedVal = List.head !tapeRef
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let rev_ArgAsAReference() =
//      let _inTape = [Num 5.0; Num 3.0; Add; Num 2.0; Add]
//      let _inTapeRef = ref _inTape
//        
//      let _expectedVal = Add
//      let _reachedVal = List.head (rev !_inTapeRef)
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    
//    [<Test>]
//    let rev() =
//      let (_inTape:eval list) = [Num 5.0; Num 3.0; Add; Num 2.0; Add]
//        
//      let _expectedVal = Add
//      let _reachedVal = List.head (rev _inTape)
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let Functors_PopFromEmpty() =
//      let _inTape = []
//        
//      let _expectedVal = []
//      let _reachedVal = popSAR _inTape
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let Functors_UndressToLast1() =
//      let tapeli = [1;2;3;4]
//        
////      let _expectedVal1 = [1]
//      let _expectedVal2 = [4;3;2]
//      let _reachedVal2 = undressToLast tapeli
//    
////      let _reachedLogic1 = _expectedVal1 = _reachedVal1
//      let _reachedLogic2 = _expectedVal2 = _reachedVal2
//    
//      Assert.True(_reachedLogic2)
//
//    [<Test>]
//    let Functors_UndressToLast2() =
//      let tapeli = [1;2;3]
//        
////      let _expectedVal1 = [1]
//      let _expectedVal2 = [3;2]
//      let _reachedVal2 = undressToLast tapeli
//    
////      let _reachedLogic1 = _expectedVal1 = _reachedVal1
//      let _reachedLogic2 = _expectedVal2 = _reachedVal2
//    
//      Assert.True(_reachedLogic2)
//
//    [<Test>]
//    let Functors_MainNodesIntoStack() =
//      let tapeli = Node(1,Node(2,Empty,Node(3,Empty,Empty)),Empty)
//
//      let _expectedVal = [Empty;Node(2,Empty,Node(3,Empty,Empty))]
//      let _reachedVal = pushLAndRFTree tapeli
//
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let Functors_IsEmptyFalse1() =
//      let tapeli = [Node(1,Node(2,Empty,Node(3,Empty,Empty)),Empty)]
//
//      let _expectedVal = false
//      let _reachedVal = isEmpty tapeli
//
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let Functors_IsEmptyFalse2() =
//      let tapeli = [Node(1,Node(2,Empty,Node(3,Empty,Empty)),Empty);Empty;Empty]
//
//      let _expectedVal = false
//      let _reachedVal = isEmpty tapeli
//
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let Functors_IsEmptyTrue() =
//      let tapeli = []
//
//      let _expectedVal = true
//      let _reachedVal = isEmpty tapeli
//
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)

//    [<Test>]
//    let ReversePolishNotation1() =
//      let (_inTape:eval list) = [Num 5.0; Num 3.0; Add; Num 2.0; Add]
//        
//      let _expectedVal = 10.0
//      let _reachedVal = RPN _inTape
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)