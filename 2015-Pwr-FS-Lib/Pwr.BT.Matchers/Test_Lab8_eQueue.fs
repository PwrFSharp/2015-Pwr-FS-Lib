namespace Pwr.BT.Test
    module Test_Lab8_eQueue =
    
    open System
    open System.Collections
    open NUnit.Framework
    open NUnit.Framework.Constraints
    open Pwr.BT.Types
    open Pwr.BT.Collections.Own.ListEager.Atomic
    open Pwr.BT.Collections.Own.QueueEager.QueueEager_Own
    open Pwr.BT.Collections.Tuple.Operations
    open Pwr.BT.Collections.Own.ListEager.Functionals

    [<Test>]
    let enqueue_El_y_ListE() =
      let queueE = BodyQ(1,BodyQ(2,EmptyQ))
      let enqueued = 3

      let _expectedVal = BodyQ(3, BodyQ(1,BodyQ(2,EmptyQ)))
      let _reachedVal = enqueue(enqueued,queueE)
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let dequeue_queueE_1() =
      let queueE = BodyQ(1,BodyQ(2,EmptyQ))

      let _expectedVal = BodyQ( 1, EmptyQ )
      let _reachedVal = dequeue queueE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let dequeue_queueE_2() =
      let queueE = BodyQ(1,BodyQ(2,BodyQ( 3, BodyQ( 4, EmptyQ ) )))

      let _expectedVal = BodyQ(1,BodyQ(2,BodyQ( 3, EmptyQ )))
      let _reachedVal = dequeue queueE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let dequeue_queueE_3() =
      let queueE = EmptyQ

      let _expectedVal = EmptyQ
      let _reachedVal = dequeue queueE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let dequeue_queueE_4() =
      let queueE = BodyQ( 1, EmptyQ )

      let _expectedVal = EmptyQ
      let _reachedVal = dequeue queueE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let rev_queueE_1() =
      let queueE = BodyQ(1,BodyQ(2,EmptyQ))

      let _expectedVal = BodyQ(2, BodyQ(1,EmptyQ))
      let _reachedVal = rev queueE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let rev_queueE_2() =
      let queueE = BodyQ(1,BodyQ(2,BodyQ( 3, BodyQ( 4, EmptyQ ) )))

      let _expectedVal = BodyQ(4,BodyQ(3, BodyQ( 2, BodyQ( 1, EmptyQ ) )))
      let _reachedVal = rev queueE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let rev_queueE_3() =
      let queueE = EmptyQ

      let _expectedVal = EmptyQ
      let _reachedVal = rev queueE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let empty_1() =

      let _expectedVal = EmptyQ
      let _reachedVal = empty
          
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let isEmpty_queueE_1() =
      let inQueue = EmptyQ

      let _expectedVal = true
      let _reachedVal = isEmpty inQueue
          
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let isEmpty_queueE_2() =
      let inQueue = BodyQ( 1, BodyQ( 2, EmptyQ ) )

      let _expectedVal = false
      let _reachedVal = isEmpty inQueue
          
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let isEmpty_queueE_3() =
      let inQueue = BodyQ( 1, BodyQ( 2, BodyQ( 3, EmptyQ ) ) )

      let _expectedVal = false
      let _reachedVal = isEmpty inQueue
          
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let top_queueE_1() =
      let inQueue = BodyQ( 1, BodyQ( 2, BodyQ( 3, EmptyQ ) ) )

      let _expectedVal = 3
      let _reachedVal = top inQueue
          
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let top_queueE_2() =
      let inQueue = BodyQ( 1, BodyQ( 2, EmptyQ ) )

      let _expectedVal = 2
      let _reachedVal = top inQueue
          
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let get_queueE_Idx_1() =
      let inQueue = BodyQ( 1, BodyQ( 2, BodyQ( 3, EmptyQ ) ) )
      let idx = 0

      let _expectedVal = 3
      let _reachedVal = get (idx,inQueue)
          
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let get_queueE_Idx_2() =
      let inQueue = BodyQ( 1, BodyQ( 2, BodyQ( 3, EmptyQ ) ) )
      let idx = 1

      let _expectedVal = 2
      let _reachedVal = get (idx,inQueue)
          
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let get_queueE_Idx_3() =
      let inQueue = BodyQ( 1, BodyQ( 2, BodyQ( 3, EmptyQ ) ) )
      let idx = 2

      let _expectedVal = 1
      let _reachedVal = get (idx,inQueue)
          
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let toList_queueE_1() =
      let inQueue = BodyQ( 1, BodyQ( 2, BodyQ( 3, EmptyQ ) ) )

      let _expectedVal = [3;2;1]
      let _reachedVal = toList inQueue
          
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let toList_queueE_2() =
      let inQueue = BodyQ( 1, BodyQ( 2, BodyQ( 3, BodyQ( 4, EmptyQ ) ) ) )

      let _expectedVal = [4;3;2;1]
      let _reachedVal = toList inQueue
          
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let toList_queueE_3() =
      let inQueue = EmptyQ

      let _expectedVal = []
      let _reachedVal = toList inQueue
          
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)