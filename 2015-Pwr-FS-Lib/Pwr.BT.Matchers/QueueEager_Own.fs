namespace Pwr.BT.Collections.Own.QueueEager

module QueueEager_Own=
    open Pwr.BT.Collections.List  

    type 'a queueE =EmptyQ |BodyQ of 'a * 'a queueE 

    let enqueue (el,que) = BodyQ(el,que)

    let rec rev que =
        let rec hRev acc =
            function
            |EmptyQ -> acc
            |BodyQ( h, t ) -> hRev (BodyQ( h, acc )) t
        in hRev EmptyQ que

    let rec dequeue que =
        let rec hDeq =
            function
            |EmptyQ -> EmptyQ
            |BodyQ( h, t ) -> rev t
        in hDeq (rev que)

    let empty = EmptyQ

    let isEmpty =
        function
        |EmptyQ -> true
        |BodyQ( h, _ ) -> false

    let head = 
        function
        |EmptyQ -> failwith "From Empty Even Salomon can't pour"
        |BodyQ( h, _ ) -> h

    let top que =
        let hTop =
            function
            |EmptyQ -> failwith "From Empty Even Salomon can't pour"
            |BodyQ( h, t ) -> h
        in hTop (rev que)

    let rec get (idx,que) =
        let rec hGet tape curIdx =
            if curIdx <> idx then
                match tape with
                |EmptyQ -> failwith "From Empty Even Salomon can't pour"
                |BodyQ( h, t ) -> hGet t (curIdx+1)
            else
                match tape with
                |EmptyQ -> failwith "From Empty Even Salomon can't pour"
                |BodyQ( h, _ ) -> h
        in hGet (rev que) 0

    let rec toList que =
        let rec hToList (acc:'a list) tape =
            match tape with
            |EmptyQ -> Iter.rev acc
            |BodyQ( h, t ) -> hToList (h::acc) t
        in hToList [] (rev que)

//    module type QUEUE_SIG =
//    sig
//    	type 'a queueE = EmptyQ |BodyQ of 'a * 'a queueE
//    	val enqueue : 'a * 'a queueE -> 'a queueE
//    	val dequeue : 'a queueE -> 'a queueE
//   		val empty : 'a queueE
//    	val isEmpty : 'a queueE -> bool
//    	val top : 'a queueE -> 'a
//    	val get : int * 'a queueE -> 'a
//    	val toList : 'a queueE -> 'a list
//    	val rev : 'a queueE -> 'a queueE
//    end;;
//
//let rec revL aList =
//        let rec rIHelp(aListH,acc) =
//            match aListH with
//            |[] -> acc
//            |_ -> rIHelp(List.tl aListH,List.hd aListH::acc)
//        in rIHelp(aList,[])
//				
//module QueueEager_Own : QUEUE_SIG =
//struct
//    type 'a queueE =EmptyQ |BodyQ of 'a * 'a queueE 
//
//    let enqueue (el,que) = BodyQ(el,que)
//
//    let rec rev que =
//        let rec hRev acc =
//            function
//            |EmptyQ -> acc
//            |BodyQ( h, t ) -> hRev (BodyQ( h, acc )) t
//        in hRev EmptyQ que
//
//    let rec dequeue que =
//        let rec hDeq =
//            function
//            |EmptyQ -> EmptyQ
//            |BodyQ( h, t ) -> rev t
//        in hDeq (rev que)
//
//    let empty = EmptyQ
//
//    let isEmpty =
//        function
//        |EmptyQ -> true
//        |BodyQ( h, _ ) -> false
//
//    let head = 
//        function
//        |EmptyQ -> failwith "From Empty Even Salomon can't pour"
//        |BodyQ( h, _ ) -> h
//
//    let top que =
//        let hTop =
//            function
//            |EmptyQ -> failwith "From Empty Even Salomon can't pour"
//            |BodyQ( h, t ) -> h
//        in hTop (rev que)
//
//    let rec get (idx,que) =
//        let rec hGet tape curIdx =
//            if curIdx <> idx then
//                match tape with
//                |EmptyQ -> failwith "From Empty Even Salomon can't pour"
//                |BodyQ( h, t ) -> hGet t (curIdx+1)
//            else
//                match tape with
//                |EmptyQ -> failwith "From Empty Even Salomon can't pour"
//                |BodyQ( h, _ ) -> h
//        in hGet (rev que) 0
//
//    let rec toList que =
//        let rec hToList (acc:'a list) tape =
//            match tape with
//            |EmptyQ -> revL acc
//            |BodyQ( h, t ) -> hToList (h::acc) t
//        in hToList [] (rev que)
//end;;




