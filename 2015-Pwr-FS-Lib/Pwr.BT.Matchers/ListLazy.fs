namespace Pwr.BT.Collections.Own.ListLazy
    module Atomic =
    open Pwr.BT.Collections.Tuple.Operations
    open Pwr.BT.Numeric.Predicates

    type 'a ListL =
        |EmptyL
        |BodyL of 'a * (unit ->'a ListL)

    let lHead = 
        function
        |EmptyL -> failwith "lhd"
        |BodyL (hd,_) -> hd
        
    let lTail =
        function
        |EmptyL -> failwith "ltl"
        |BodyL (_, tl) -> tl()

    let lIsEmpty = 
        function
        |EmptyL -> true
        |_ -> false

    let rec lContains ll tape =
        let rec hContains acc =
            function
            |EmptyL -> acc
            |BodyL( h, t ) ->
                if h = ll then hContains true (t())
                else hContains acc (t())
        in hContains false tape
//
//    let rec lRev lTape=
//        match lTape with
//            |EmptyL ->EmptyL
//            |BodyL( hd, tl ) -> BodyL( hd, fun () ->  lRev (tl())) 

    let rec lRev eTape=
        let rec hRev acc =
            function
            |EmptyL -> acc
            |BodyL( hd, tl ) -> hRev (BodyL( hd, fun()->acc )) (tl())
        in hRev EmptyL eTape

    let rec lSum lList=
        match lList with
            |EmptyL -> 0
            |BodyL (hd,tl) -> hd+(lSum (tl()))

    let rec lPartOrdCompare tapeListL comparedListE =
            match tapeListL with
            |EmptyL -> true
            |BodyL( h, t ) ->  ( h < (lHead comparedListE)) && (lPartOrdCompare (t()) comparedListE)

    let rec lToNative lList=
        match lList with
            |EmptyL -> []
            |BodyL (hd,tl) -> hd::(lToNative (tl()))

//    let rec lToEager nList=
//        let rec hEager acc =
//            function
//            |[] -> EmptyL
//            |hd:: tl -> BodyL( hd, lToEager (tl()) )
//        in hEager EmptyL nList

//    let rec lDuplicate ll multipl =
//            if multipl <= 0 then EmptyL
//            else ( BodyL( ll, lDuplicate ll (hMulti-1) )
//
//    let rec lDuplicate2 ll multipl =
//            if multipl <= 0 then EmptyL
//            else lDuplicate2 (BodyL( ll, fun () -> acc )) (multipl-1)
 
    let rec lDuplicate el multipl =
            if multipl <= 0 then EmptyL
            else (BodyL( el, fun()->lDuplicate el (multipl-1) ))

//    let rec lDuplicate el multipl =
//        let rec hDupl acc hMulti=
//            if hMulti <= 0 then acc
//            else hDupl (BodyL( el, fun()->acc )) (hMulti-1)
//        in hDupl EmptyL multipl

//    let rec lMergInSepS lETape lEInfix=
//        let rec hMerge acc =
//            function
//            |EmptyL  -> acc
//            |BodyL( h, EmptyL) -> hMerge (acc^ h) (EmptyL())
//            |BodyL( h, t ) -> hMerge (acc^ h^ lHead lEInfix) t
//        in hMerge "" lETape

    let rec lSize tapeListL =
        let rec hLength acc=
            function
            |EmptyL ->acc
            |BodyL(h,t) -> hLength (acc+1) (t())
        in hLength 0 tapeListL

    let rec genListIncl tapeBeginE tapeEndE =
        let rec hGenList acc =
            function
            |EmptyL -> BodyL(-1,fun () -> EmptyL)
            |BodyL(hd,_) -> 
                if hd > lHead tapeEndE then lRev acc
                else hGenList (BodyL( hd, fun () -> acc)) (BodyL( hd + 1,fun () -> EmptyL ))
        in hGenList EmptyL tapeBeginE 

    let rec lBranchByEven tapeListL =
        let rec hBranch (accEven,accOdd) =
           function
            |EmptyL -> ( lRev accEven, lRev accOdd)
            |BodyL( h, t ) ->
                if isEven h then hBranch (BodyL( h,fun () -> accEven),accOdd) (t())
                else hBranch (accEven, BodyL(h,fun () -> accOdd) ) (t())
        in hBranch (EmptyL,EmptyL) tapeListL

    let rec lBranchBy10y5Even tapeListL =
        let rec hBranch10y5 (modEq10,modEq5,modOdd) =
            function
            |EmptyL -> ( lRev modEq10, lRev modEq5, lRev modOdd)
            |BodyL( h, t ) ->
                if isDividend10 h then hBranch10y5 ( BodyL( h, fun () -> modEq10 ), BodyL( h, fun () -> modEq5 ), modOdd ) (t())
                else if isDividend5 h then hBranch10y5 ( modEq10 , BodyL( h, fun () -> modEq5 ), modOdd ) (t())
                else hBranch10y5 ( modEq10 , modEq5 , BodyL( h, fun () -> modOdd)) (t())
        in hBranch10y5 (EmptyL,EmptyL,EmptyL) tapeListL

    let rec lBranchByIdxEven3 tapeListL =
        let rec hBranchIdx (modEq0,modEq1,modEq2) idx =
            function
            |EmptyL -> ( lRev modEq0, lRev modEq1, lRev modEq2)
            |BodyL( h, t ) ->
                if isMod3Eq0 idx then hBranchIdx (BodyL( h, fun () -> modEq0 ), modEq1, modEq2) (idx+1) (t())
                else if isMod3Eq1 idx then hBranchIdx (modEq0,BodyL( h, fun () -> modEq1 ),modEq2) (idx+1) (t())
                else hBranchIdx (modEq0,modEq1,BodyL( h, fun () -> modEq2 )) (idx+1) (t())
        in hBranchIdx (EmptyL,EmptyL,EmptyL) 0 tapeListL

    let rec (@) fstTapeLE sndTapeLE =
        let rec hAppend acc =
            function
            |(EmptyL,EmptyL) -> lRev acc
            |(BodyL( h1, t1),BodyL( h2, t2 )) -> hAppend (BodyL( h1 , fun ()->acc )) ( t1(), BodyL( h2, t2 ))
            |(BodyL( h, t ),EmptyL ) -> hAppend (BodyL( h , fun ()->acc )) ( t(), EmptyL)
            |(EmptyL,BodyL( h, t )) -> hAppend (BodyL( h ,fun ()-> acc )) (EmptyL , (t()))
        in hAppend EmptyL (fstTapeLE,sndTapeLE)
//
//    let rec lMergeBraid fstTapeListE sndTapeListE =
//        let rec hMerge acc=
//            function
//            |(EmptyL,EmptyL) -> lRev acc
//            |(BodyL( h1, t1),BodyL( h2, t2 )) -> hMerge (BodyL( h2, BodyL( h1, fun ()-> acc ))) (t1(),t2())
//            |(BodyL( h, t ),EmptyL) -> (eRev acc) @ (BodyL(h,t))
//            |(EmptyL,BodyL( h, t )) -> (eRev acc) @ (BodyL(h,t))
//        in hMerge EmptyL (fstTapeListE,sndTapeListE)

    let rec lSumBraid fstTapeListE sndTapeListE =
        let rec hSumBraid acc =
            function
            |(EmptyL,EmptyL) -> lRev acc
            |(BodyL( h, t ),EmptyL) -> hSumBraid (BodyL( h, fun ()->acc )) (t(),EmptyL)
            |(EmptyL,BodyL( h, t )) -> hSumBraid (BodyL( h, fun ()->acc )) (EmptyL,t())
            |(BodyL( h1, t1 ),BodyL( h2, t2 )) -> hSumBraid (BodyL( h1+h2, fun ()->acc )) (t1(),t2())
        in hSumBraid (EmptyL) (fstTapeListE,sndTapeListE)

    let rec lBranchByPivot tapeListL pivotE =
        let rec hBranchWithPivot (accHigher,accLower) =
            function
            |EmptyL -> ( lRev accHigher, lRev accLower)
            |BodyL( h, t )->
                if h > ( lHead pivotE) then hBranchWithPivot (BodyL( h, fun ()->accHigher), accLower) (t())
                else if h < ( lHead pivotE) then hBranchWithPivot (accHigher,BodyL( h, fun ()->accLower )) (t())
                else hBranchWithPivot (accHigher,accLower) (t())
        in hBranchWithPivot (EmptyL,EmptyL) tapeListL

    let lMerge tapeListL pivotE = tapeListL @ pivotE

    let rec lMap f=
        function
        |EmptyL -> EmptyL
        |BodyL( h, t ) -> (BodyL( f h, fun ()-> lMap f (t())))

    let rec lFilter f =
            function
            |EmptyL -> EmptyL
            |BodyL( h, t ) ->
                if f h then (BodyL( h, fun ()-> lFilter f (t()) ))
                else lFilter f (t())

    let rec lStickListWithIdxAsc tapeListL=
        let rec hStick acc idx = 
            function
            |EmptyL -> lRev acc
            |BodyL( h, t ) -> hStick ( BodyL(( h, idx), fun ()->acc) ) (idx+1) (t())
        in hStick EmptyL 0 tapeListL

    let rec lStickListWithIdxDesc tapeListL=
        let rec hStick acc idx = 
            function
            |EmptyL -> acc
            |BodyL( h, t ) -> hStick ( BodyL(( h, idx), fun ()->acc) ) (idx+1) (t())
        in hStick EmptyL 0 ( lRev tapeListL)

    let rec lFoldLeftOneArg f acc tapeListL =
        match tapeListL with
        |EmptyL -> lRev acc
        |BodyL( h, t ) -> lFoldLeftOneArg (f) (BodyL( f h, fun()->acc)) (t())

//    let rec fold_left f acc l =      
//    match l with         
//    h::t -> fold_left f (f acc h) t       
//    | []   -> acc;; 

    let rec lFoldLeftForFlat f acc tapeListL =
        let rec hFold hAcc =
            function
            |EmptyL -> lRev hAcc
            |BodyL( h, t ) -> hFold (f ( lRev h) hAcc) (t())
        in hFold acc tapeListL

            