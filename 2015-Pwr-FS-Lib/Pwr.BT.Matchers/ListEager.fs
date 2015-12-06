namespace Pwr.BT.Collections.List.Own
    module ListEager =

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

    let rec eSum eList=
        let rec hSum acc =
            function
            |EmptyE -> acc
            |BodyE (hd,tl) -> hSum (hd+acc) tl
        in hSum 0 eList

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