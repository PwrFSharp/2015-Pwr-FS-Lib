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
        let rec hBranch acc =
           function
            |EmptyE -> (eRev (fst2 acc),eRev (snd2 acc))
            |BodyE( h, t ) ->
                if isEven h then hBranch (BodyE( h,fst2 acc),snd2 acc) t
                else hBranch (fst2 acc, BodyE(h,snd2 acc)) t
        in hBranch (EmptyE,EmptyE) tapeListE

    let rec (|@) fstTapeLE sndTapeLE =
        let rec hAppend acc =
            function
            |(EmptyE,EmptyE) -> eRev acc
            |(BodyE( h1, t1),BodyE( h2, t2 )) -> hAppend (BodyE( h1 , acc )) ( t1, BodyE( h2, t2 ))
            |(BodyE( h, t ),EmptyE) -> hAppend (BodyE( h , acc )) ( t, EmptyE)
            |(EmptyE,BodyE( h, t )) -> hAppend (BodyE( h , acc )) (EmptyE , t)
            |_ -> eRev acc
        in hAppend EmptyE (fstTapeLE,sndTapeLE)

//    let rec eMergeBraid fstTapeListE sndTapeListE =
        