﻿namespace Pwr.BT.Consultations.Questions
    module ConsultationsQuestions =
    open Pwr.BT.Collections.Own.ListEager

    ///////////////////// ********** 1 ********** /////////////////////
    // WORK
    let rec genListIncl tapeBeginE tapeEndE =
        let rec hGenList acc beginE =
            match beginE with
            |EmptyE -> BodyE(-1,EmptyE)
            |BodyE(hd,tl) -> 
                if hd > eHead tapeEndE then eRev acc
                else hGenList (BodyE( hd, acc)) (BodyE( hd + 1, EmptyE ))
        in hGenList EmptyE tapeBeginE 

//    // Not_WORK
//    let rec genListIncl2 tapeBeginE tapeEndE =
//        let rec hGenList acc beginE =
//            match beginE with
//            |EmptyE -> BodyE(-1,EmptyE)
//            |BodyE(hd,tl) -> 
//                if hd > eHead tapeEndE then eRev acc
//                else hGenList (BodyE( hd, acc)) BodyE( hd + 1, EmptyE )
//        in hGenList EmptyE tapeBeginE 

     ///////////////////// ********** 2 ********** /////////////////////

    let rec genListInclMatchList tapeBeginE tapeEndE =
        let rec hGenList acc beginE =
            match beginE with
            |EmptyE -> BodyE(-1,EmptyE)
            |BodyE(hd,_) -> 
                if hd > eHead tapeEndE then eRev acc
                else hGenList (BodyE( hd, acc)) (BodyE( hd + 1, EmptyE ))
        in hGenList EmptyE tapeBeginE 

    let rec genListIncl2MatchFunction tapeBeginE tapeEndE =
        let rec hGenList acc =
            function
            |EmptyE -> BodyE(-1,EmptyE)
            |BodyE(hd,_) -> 
                if hd > eHead tapeEndE then eRev acc
                else hGenList (BodyE( hd, acc)) (BodyE( hd + 1, EmptyE ))
        in hGenList EmptyE tapeBeginE 



