namespace Pwr.BT.Collections.Own.QueueEager

module QueueEager_Own =
    type 'a queueE = EmptyQ |BodyQ of 'a * 'a queueE
    val enqueue : 'a * 'a queueE -> 'a queueE
    val dequeue : 'a queueE -> 'a queueE
    val empty : 'a queueE
    val isEmpty : 'a queueE -> bool
    val top : 'a queueE -> 'a
    val get : int * 'a queueE -> 'a
    val toList : 'a queueE -> 'a list
    val rev : 'a queueE -> 'a queueE