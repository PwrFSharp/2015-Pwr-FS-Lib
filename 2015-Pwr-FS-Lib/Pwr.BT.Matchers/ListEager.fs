namespace Pwr.BT.Collections.Own
    module ListEager =
    open Pwr.BT.Collections.Tuple.Operations
    open Pwr.BT.Numeric.Operations

    type 'a ListE =
        |EmptyE
        |BodyE of 'a * ('a ListE)

    let eHead = 
        function
        |EmptyE -> failwith "lhd"
        |BodyE (hd,_) -> hd
        
    let eTail =
        function
        |EmptyE -> failwith "ltl"
        |BodyE (_, tl) -> tl

    let eIsEmpty = 
        function
        |EmptyE -> true
        |_ -> false

    let rec eRev eTape=
        let rec hRev acc =
            function
            |EmptyE -> acc
            |BodyE( hd, tl ) -> hRev (BodyE( hd, acc )) tl
        in hRev EmptyE eTape

    let rec eSum eList=
        let rec hSum acc =
            function
            |EmptyE -> acc
            |BodyE (hd,tl) -> hSum (hd+acc) tl
        in hSum 0. eList

    let rec ePartOrdCompare tapeListE comparedListE =
        let rec hPartOrd acc =
            function
            |EmptyE -> acc
            |BodyE( h, t ) -> hPartOrd ( acc && h < eHead comparedListE ) t
        in hPartOrd true tapeListE

    let rec eToNormal eList=
        let rec hNormal acc=
            function
            |EmptyE -> acc
            |BodyE (hd,tl) -> hNormal (hd::acc) tl
        in hNormal [] eList

    let rec eToEager nList=
        let rec hEager acc =
            function
            |[] -> EmptyE
            |hd:: tl -> BodyE( hd, eToEager tl )
        in hEager EmptyE nList

    let rec eMergInSepS lETape lEInfix=
        let rec hMerge acc =
            function
            |EmptyE  -> acc
            |BodyE( h, EmptyE) -> hMerge (acc^ h) EmptyE
            |BodyE( h, t ) -> hMerge (acc^ h^ eHead lEInfix) t
        in hMerge "" lETape

    let rec eSize tapeListE =
        let rec hLength acc=
            function
            |EmptyE ->acc
            |BodyE(h,t) -> hLength (acc+1) t
        in hLength 0 tapeListE

    let rec genListIncl tapeBeginE tapeEndE =
        let rec hGenList acc =
            function
            |EmptyE -> BodyE(-1,EmptyE)
            |BodyE(hd,_) -> 
                if hd > eHead tapeEndE then eRev acc
                else hGenList (BodyE( hd, acc)) (BodyE( hd + 1, EmptyE ))
        in hGenList EmptyE tapeBeginE 

    let rec eBranchByEven tapeListE =
        let rec hBranch (accEven,accOdd) =
           function
            |EmptyE -> (eRev accEven,eRev accOdd)
            |BodyE( h, t ) ->
                if isEven h then hBranch (BodyE( h,accEven),accOdd) t
                else hBranch (accEven, BodyE(h,accOdd) ) t
        in hBranch (EmptyE,EmptyE) tapeListE

    let rec eBranchBy10y5Even tapeListE =
        let rec hBranch10y5 (modEq10,modEq5,modOdd) =
            function
            |EmptyE -> (eRev modEq10,eRev modEq5,eRev modOdd)
            |BodyE( h, t ) ->
                if isDividend10 h then hBranch10y5 ( BodyE( h, modEq10 ), BodyE( h, modEq5 ), modOdd ) t
                else if isDividend5 h then hBranch10y5 ( modEq10 , BodyE( h, modEq5 ), modOdd ) t
                else hBranch10y5 ( modEq10 , modEq5 , BodyE( h, modOdd)) t
        in hBranch10y5 (EmptyE,EmptyE,EmptyE) tapeListE

    let rec eBranchByIdxEven3 tapeListE =
        let rec hBranchIdx (modEq0,modEq1,modEq2) idx =
            function
            |EmptyE -> (eRev modEq0,eRev modEq1,eRev modEq2)
            |BodyE( h, t ) ->
                if isMod3Eq0 idx then hBranchIdx (BodyE( h, modEq0 ), modEq1, modEq2) (idx+1) t
                else if isMod3Eq1 idx then hBranchIdx (modEq0,BodyE( h, modEq1 ),modEq2) (idx+1) t
                else hBranchIdx (modEq0,modEq1,BodyE( h, modEq2 )) (idx+1) t
        in hBranchIdx (EmptyE,EmptyE,EmptyE) 0 tapeListE

    let rec (@) fstTapeLE sndTapeLE =
        let rec hAppend acc =
            function
            |(EmptyE,EmptyE) -> eRev acc
            |(BodyE( h1, t1),BodyE( h2, t2 )) -> hAppend (BodyE( h1 , acc )) ( t1, BodyE( h2, t2 ))
            |(BodyE( h, t ),EmptyE ) -> hAppend (BodyE( h , acc )) ( t, EmptyE)
            |(EmptyE,BodyE( h, t )) -> hAppend (BodyE( h , acc )) (EmptyE , t)
        in hAppend EmptyE (fstTapeLE,sndTapeLE)

    let rec eMergeBraid fstTapeListE sndTapeListE =
        let rec hMerge acc=
            function
            |(EmptyE,EmptyE) -> eRev acc
            |(BodyE( h1, t1),BodyE( h2, t2 )) -> hMerge (BodyE( h2, BodyE( h1, acc ))) (t1,t2)
            |(BodyE( h, t ),EmptyE) -> (eRev acc) @ (BodyE(h,t))
            |(EmptyE,BodyE( h, t )) -> (eRev acc) @ (BodyE(h,t))
        in hMerge EmptyE (fstTapeListE,sndTapeListE)

    let rec eSumBraid fstTapeListE sndTapeListE =
        let rec hSumBraid acc =
            function
            |(EmptyE,EmptyE) -> eRev acc
            |(BodyE( h, t ),EmptyE) -> hSumBraid (BodyE( h, acc )) (t,EmptyE)
            |(EmptyE,BodyE( h, t )) -> hSumBraid (BodyE( h, acc )) (EmptyE,t)
            |(BodyE( h1, t1 ),BodyE( h2, t2 )) -> hSumBraid (BodyE( h1+h2, acc )) (t1,t2)
        in hSumBraid (EmptyE) (fstTapeListE,sndTapeListE)

    let rec eBranchByPivot tapeListE pivotE =
        let rec hBranchWithPivot (accHigher,accLower) =
            function
            |EmptyE -> (eRev accHigher, eRev accLower)
            |BodyE( h, t )->
                if h > (eHead pivotE) then hBranchWithPivot (BodyE( h, accHigher), accLower) t
                else if h < (eHead pivotE) then hBranchWithPivot (accHigher,BodyE( h, accLower )) t
                else hBranchWithPivot (accHigher,accLower) t
        in hBranchWithPivot (EmptyE,EmptyE) tapeListE

    let eMerge tapeListE pivotE = tapeListE @ pivotE

    let rec eMap f tapeE=
        let rec hMap f acc =
            function
            |EmptyE -> eRev acc
            |BodyE( h, t ) -> hMap f (BodyE( f h, acc )) t
        in hMap f EmptyE tapeE