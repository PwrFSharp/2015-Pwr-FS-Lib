namespace Pwr.BT.Test
    module Tree_Oper = 
    open NUnit.Framework
    open Pwr.BT.Types
    open Pwr.BT.Collections.Tree

    [<Test>]
    let OfTree_PullingKey() =
      let inTree = Node(1,Node(2,Empty,Node(3,Empty,Empty)),Empty)
        
      let _expectedVal = 1
      let _reachedVal = Oper.key inTree
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let Tree_PullingLeftNode() =
      let inTree = Node(1,Node(2,Empty,Node(3,Empty,Empty)),Empty)
        
      let _expectedVal = Node(2,Empty,Node(3,Empty,Empty))
      let _reachedVal = Oper.left inTree
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)
//
//    [<Test>]
//    let Tree_PullingRightNode() =
//      let inTree = Node(1,Node(2,Empty,Node(3,Empty,Empty)),Empty)
//        
//      let _expectedVal = Empty
//      let _reachedVal = getRightNode inTree
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)

//    [<Test>]
//    let TreeAlgo_PostfixTreeToListCOvcerterPage19() =
//      let inTree = Node(1,Node(2,Empty,Node(3,Empty,Empty)),Empty)
//        
//      let _expectedVal = [3;2;1]
//      let _reachedVal = treeToListPostFix inTree
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
////
//    [<Test>]
//    let TreeAlgo_PostfixTreeToListCOnverterPage18() =
//      let inTree = Node(1,Node(2,Node(4,Empty,Empty),Empty),Node(3,Node(5,Empty,Node(6,Empty,Empty)),Empty))
//        
//      let _expectedVal = [4;2;6;5;3;1]
//      let _reachedVal = treeToListPostFix inTree
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
//////
//    [<Test>]
//    let TreeAlgo_PostfixTreeToListCOnverterOwn1() =
//      let inTree = Node(1,Empty,Node(2,Node(3,Node(4,Empty,Empty),Empty),Empty))
//        
//      let _expectedVal = [4;3;2;1]
//      let _reachedVal = treeToListPostFix inTree
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)
