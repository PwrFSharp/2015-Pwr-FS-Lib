namespace Pwr.BT.Collections.Tree
open Pwr.BT.Types
    module Oper =
    
    let key aTree =
        match (aTree) with
        |Node(mVal,mLeft,mRight) -> mVal
        |Empty -> raise (Failure "EmptyNode->KeyAway")

    let left aTree = 
        match (aTree) with
        |Empty -> Empty
        |Node(_,Empty,_) -> Empty
        |Node(_,mLeft,_) -> mLeft

    let right aTree = 
        match (aTree) with
        |Empty -> Empty
        |Node(_,_,Empty) -> Empty
        |Node(_,_,mRight) -> mRight

//    module TreeStack =
//    open Stack
//
//    let pushLAndRFTree(aTree) =
//        let buff = pushSR([],getRightNode(aTree)) in
//            pushSR(buff,getLeftNode(aTree))
//
//    module TreeConverter =
//      open StackRefs

//    let rec treeToListPostFix aTree=
//        let rec helpStack(leftAndRightStack) =
//                let rec appliedNode = backNR leftAndRightStack in
//                    let leftAndRightStack = popSAR leftAndRightStack in
//                        let rec helptPf(appliedNode,stackAcc,endList) =
//                            if not(Stack.isEmpty leftAndRightStack) then 
//                                match appliedNode with
//                                // if i finished left subTree, go to the right subTree
//                                |Node(el,left,right) when left = Empty && right = Empty->
//                                    let bNowRight = backNR leftAndRightStack in
//                                    leftAndRightStack = popSAR leftAndRightStack;
//                                    let buffStack = pushSR(stackAcc,el) in
////                                    let undressed = undressToLast buffStack in
//                                    helptPf(bNowRight,[List.head buffStack],endList@(undressToLast buffStack))
//                                // if i still have next nodes on right side
//                                |Node(el,left,right) when left = Empty && right <> Empty -> 
//                                    helptPf(right,pushSR(stackAcc,el),endList)
//                               // if i still have next nodes on left side
//                                |Node(el,left,right) when left <> Empty-> 
//                                    helptPf(left,pushSR(stackAcc,el),endList)
//                                |_ -> endList@stackAcc
//                            else endList
//                        in helptPf(aTree,[],[])
//         in helpStack(pushLAndRFTree(aTree))
//

// GOOOOOOOOOOOOOOOOOOOOOOOOOOODXXXXXXXXXXXXXXXXX
//      let rec treeToListPostFix aTree=
//        let rec helpStack(leftAndRightStack) =
//                    let leftAndRightStack = popSAR leftAndRightStack;
//                    let refToMainStack = ref leftAndRightStack in
//                        let rec helptPf(appliedNode,stackAcc,endList) =
//                            if not(Stack.isEmpty !refToMainStack && appliedNode = Empty ) then 
//                                match appliedNode with
//                                // if i finished left subTree, go to the right subTree
//                                |Node(el,left,right) when left = Empty && right = Empty->
//                                    let bNowRight = popAndBack refToMainStack 
////                                    popRefTree refToMainStack; // ch
//                                    let buffStack = pushSR(stackAcc,el) in
////                                    let undressed = undressToLast buffStack in
//                                    helptPf(bNowRight,[List.head buffStack],endList@(undressToLast buffStack))
//                                // if i still have next nodes on right side
//                                |Node(el,left,right) when left = Empty && right <> Empty -> 
//                                    helptPf(right,pushSR(stackAcc,el),endList)
//                               // if i still have next nodes on left side
//                                |Node(el,left,right) when left <> Empty-> 
//                                    helptPf(left,pushSR(stackAcc,el),endList)
//                                |_ -> []
//                            else endList@stackAcc
//                        in helptPf(popAndBack refToMainStack,[],[])
//         in helpStack(pushLAndRFTree(aTree))

//
// GOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOD
//      let rec treeToListPostFix aTree=
//        let rec helpStack(leftAndRightStack) =
//                    let leftAndRightStack = popSAR leftAndRightStack;
//                    let refToMainStack = ref leftAndRightStack in
//                        let rec helptPf(appliedNode,stackAcc,endList) =
//                            if not(Stack.isEmpty !refToMainStack && appliedNode = Empty ) then 
//                                match appliedNode with
//                                // if i finished left subTree, go to the right subTree
//                                |Node(el,left,right) when left = Empty && right = Empty->
//                                    let bNowRight = 
//                                        if ((count refToMainStack = 1) && left = Empty && right = Empty )
//                                        then Empty
//                                        else backNR !refToMainStack in
//                                    popRef refToMainStack;
//                                    let buffStack = pushSR(stackAcc,el) in
////                                    let undressed = undressToLast buffStack in
//                                    helptPf(bNowRight,[List.head buffStack],endList@(undressToLast buffStack))
//                                // if i still have next nodes on right side
//                                |Node(el,left,right) when left = Empty && right <> Empty -> 
//                                    helptPf(right,pushSR(stackAcc,el),endList)
//                               // if i still have next nodes on left side
//                                |Node(el,left,right) when left <> Empty-> 
//                                    helptPf(left,pushSR(stackAcc,el),endList)
//                                |_ -> []
//                            else endList@stackAcc
//                        in helptPf(aTree,[],[])
//         in helpStack(pushLAndRFTree(aTree))