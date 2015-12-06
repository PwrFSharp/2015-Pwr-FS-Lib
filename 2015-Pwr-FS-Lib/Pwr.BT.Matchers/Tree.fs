namespace Pwr.BT.Collections.Tree
open Pwr.BT.Types
    module Oper =
    open Pwr.BT.Collections.Stack.OperRef
    
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
 
    let rec postOrderTree aTree =
        let rec innerHelpers(inStackTrace,inStackWaiting,inStackFrame,tempTree) =
//           let backWait = backTreeRef inStackWaiting; // ret Elem
//           let popWait = popRef inStackWaiting;// unit
//           let pushWait = pushRef inStackWaiting; // need element
//           let pushTrace = pushRef inStackTrace;// need element
//           let backFrame = backBoolRef inStackFrame ; // ret Elem
//           let popFrame = popRef inStackFrame ; // unit
//           let pushFrame = pushRef inStackFrame in// need element
//           let inkey = key temptree ;// ret elem
//           let inLeft = left tempTree ;// ret Elem
//           let inRight = right tempTree; // ret Elemin
            let rec inInHelp(tempTree2,outList) =
            if( !inStackWaiting <> []) then
                    if ( backBoolRef inStackFrame = false) then
                        match tempTree2 with
                        |Node(_, Empty, Empty)->
                            //ChosenFrame
                            popRef inStackFrame 
                            pushRef inStackFrame  true
                            //Wait
                            inInHelp(backTreeRef inStackWaiting ,[]) // open last Node
                        |Node(_, Empty, _) ->
                            //ChosenFrame
                            popRef inStackFrame 
                            pushRef inStackFrame  true
                            //Wait
                            pushRef inStackFrame  false;pushRef inStackWaiting  (right tempTree2)
                            //RecFunction
                            inInHelp(backTreeRef inStackWaiting ,[]) 
                        |Node(_, _, Empty) ->
                            //ChosenFrame
                            popRef inStackFrame 
                            pushRef inStackFrame  true
                            //Wait
                            pushRef inStackFrame  false;pushRef inStackWaiting  (left tempTree2)
                            //RecFunction
                            inInHelp(backTreeRef inStackWaiting ,[]) 
                        |Node(_) ->
                            //ChosenFrame
                            popRef inStackFrame 
                            pushRef inStackFrame  true
                            //Wait
                            pushRef inStackFrame  false;pushRef inStackWaiting  (right tempTree2) // check time of tying values
                            pushRef inStackFrame  false;pushRef inStackWaiting  (left tempTree2)
                            //RecFunction
                            inInHelp(backTreeRef inStackWaiting ,[])
                        |Empty -> 
                            pushRef inStackFrame  false
                            popRef inStackWaiting 
                            outList= !inStackTrace
                            outList
                    else
                        //ChosenFrame
                        popRef inStackWaiting ; popRef inStackFrame 
                        //RetList
                        pushRef inStackTrace  (key tempTree2)
                        //RecFunction
                        inInHelp(backTreeRef inStackWaiting ,[])
                else popRef inStackFrame ;!inStackTrace
                in inInHelp(tempTree,[])
        in innerHelpers(ref [],ref [aTree],ref [false;false],aTree)      
//    let rec postOrderTree aTree =
//        let rec innerHelpers(inStackTrace,inStackWaiting,inStackFrame,tempTree) =
////           let backWait = backTreeRef inStackWaiting; // ret Elem
////           let popWait = popRef inStackWaiting;// unit
////           let pushWait = pushRef inStackWaiting; // need element
//            let pushTrace = lazy(pushRef inStackTrace);// need element
////           let backFrame = backBoolRef inStackFrame ; // ret Elem
////           let popFrame = popRef inStackFrame ; // unit
////           let pushFrame = pushRef inStackFrame in// need element
//            let inkey = key tempTree in// ret elem
////           let inLeft = left tempTree ;// ret Elem
////           let inRight = right tempTree; // ret Elemin
//            let rec inInHelp(tempTree2,outList) =
//
//            if( !inStackWaiting <> []) then
//                    if ( backBoolRef inStackFrame = false) then
//                        match tempTree2 with
//                        |Node(_, Empty, Empty)->
//                            //ChosenFrame
//                            popRef inStackFrame 
//                            pushRef inStackFrame  true
//                            //Wait
//                            inInHelp(backTreeRef inStackWaiting ,[]) // open last Node
//                        |Node(_, Empty, _) ->
//                            //ChosenFrame
//                            popRef inStackFrame 
//                            pushRef inStackFrame  true
//                            //Wait
//                            pushRef inStackFrame  false;pushRef inStackWaiting  (right tempTree2)
//                            //RecFunction
//                            inInHelp(backTreeRef inStackWaiting ,[]) 
//                        |Node(_, _, Empty) ->
//                            //ChosenFrame
//                            popRef inStackFrame 
//                            pushRef inStackFrame  true
//                            //Wait
//                            pushRef inStackFrame  false;pushRef inStackWaiting  (left tempTree2)
//                            //RecFunction
//                            inInHelp(backTreeRef inStackWaiting ,[]) 
//                        |Node(_) ->
//                            //ChosenFrame
//                            popRef inStackFrame 
//                            pushRef inStackFrame  true
//                            //Wait
//                            pushRef inStackFrame  false;pushRef inStackWaiting  (right tempTree2) // check time of tying values
//                            pushRef inStackFrame  false;pushRef inStackWaiting  (left tempTree2)
//                            //RecFunction
//                            inInHelp(backTreeRef inStackWaiting ,[])
//                        |Empty -> 
//                            pushRef inStackFrame  false
//                            popRef inStackWaiting 
//                            outList= !inStackTrace
//                            outList
//                    else
//                        //ChosenFrame
//                        popRef inStackWaiting ; popRef inStackFrame 
//                        //RetList
//                        pushTrace (inkey)
//                        //RecFunction
//                        inInHelp(backTreeRef inStackWaiting ,[])
//                else popRef inStackFrame ;!inStackTrace
//                in inInHelp(tempTree,[])
//        in innerHelpers(ref [],ref [aTree],ref [false;false],aTree)
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