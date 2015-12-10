namespace Pwr.BT.Test
    module Test_Lab7_eList =
    
    open System
    open System.Collections
    open NUnit.Framework
    open NUnit.Framework.Constraints
    open Pwr.BT.Types
    open Pwr.BT.Collections.List.Iter
    open Pwr.BT.Collections.Own.ListEager.Atomic
    open Pwr.BT.Collections.Tuple.Operations
    open Pwr.BT.Collections.Own.ListEager.Functionals

    [<Test>]
    let mergeBraid_ListE_ListE_1() =
      let fstTapeListE = BodyE(1,BodyE(3,BodyE(5,BodyE(7,BodyE(9,BodyE(11,EmptyE))))))
      let sndTapeListE = BodyE(2,BodyE(4,BodyE(6,BodyE(8,EmptyE))))

      let _expectedVal = BodyE(1,BodyE(2,BodyE(3,BodyE(4,BodyE(5,BodyE(6,BodyE(7,BodyE(8,BodyE(9,BodyE(11,EmptyE))))))))))
      let _reachedVal = eMergeBraid fstTapeListE sndTapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let mergeBraid_ListE_ListE_2() =
      let fstTapeListE = BodyE(5,BodyE(4,BodyE(3,BodyE(2,EmptyE))))
      let sndTapeListE = BodyE(1,BodyE(2,BodyE(3,BodyE(4,BodyE(5,BodyE(6,EmptyE))))))
              
      let _expectedVal = BodyE(5,BodyE(1,BodyE(4,BodyE(2,BodyE(3,BodyE(3,BodyE(2,BodyE(4,BodyE(5,BodyE(6,EmptyE))))))))))
      let _reachedVal = eMergeBraid fstTapeListE sndTapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let powiel_ListE_1() =
      let tapeListE = BodyE(1,BodyE(2,BodyE(3,EmptyE)))
              
      let _expectedVal = BodyE(1,BodyE(2,BodyE(2,BodyE(3,BodyE(3,BodyE(3,EmptyE))))))
      let _reachedVal = powiel tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let powiel_ListE_2() =
      let tapeListE = BodyE(0,EmptyE)
              
      let _expectedVal = EmptyE
      let _reachedVal = powiel tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let powiel_ListE_3() =
      let tapeListE = BodyE(7,EmptyE)
              
      let _expectedVal = BodyE(7,BodyE(7,BodyE(7,BodyE(7,BodyE(7,BodyE(7,BodyE(7,EmptyE)))))))
      let _reachedVal = powiel tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let powiel_ListE_4() =
      let tapeListE = BodyE(-4,EmptyE)
              
      let _expectedVal = EmptyE
      let _reachedVal = powiel tapeListE
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let insert_ListE_El_Filled_Internal() =
      let tapeListE = BodyE(1,BodyE( 3, BodyE( 5, BodyE( 7, EmptyE ) ) ))
      let el = 4
              
      let _expectedVal = BodyE(1,BodyE( 3, BodyE( 4, BodyE( 5, BodyE( 7, EmptyE ) ) ) ))
      let _reachedVal = insert tapeListE el
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let insert_ListE_El_Filled_NewLeftLimit() =
      let tapeListE = BodyE( 1,BodyE( 2, BodyE( 3, BodyE( 5, BodyE( 6, EmptyE ) ) ) ))
      let el = 0
              
      let _expectedVal = BodyE(0,BodyE( 1,BodyE( 2, BodyE( 3, BodyE( 5, BodyE( 6, EmptyE ) ) ) )))
      let _reachedVal = insert tapeListE el
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let insert_ListE_El_Filled_EqualToLeftLimit() =
      let tapeListE = BodyE( 1,BodyE( 2, BodyE( 3, BodyE( 5, BodyE( 6, EmptyE ) ) ) ))
      let el = 1
              
      let _expectedVal = BodyE( 1,BodyE( 1,BodyE( 2, BodyE( 3, BodyE( 5, BodyE( 6, EmptyE ) ) ) )))
      let _reachedVal = insert tapeListE el
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let insert_ListE_El_Filled_EqualToSecond() =
      let tapeListE = BodyE( 1,BodyE( 2, BodyE( 3, BodyE( 5, BodyE( 6, EmptyE ) ) ) ))
      let el = 2
              
      let _expectedVal = BodyE( 1,BodyE( 2,BodyE( 2, BodyE( 3, BodyE( 5, BodyE( 6, EmptyE ) ) ) )))
      let _reachedVal = insert tapeListE el
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let insert_ListE_El_Filled_Latter() =
      let tapeListE = BodyE( 1,BodyE( 3, BodyE( 4, BodyE( 5, BodyE( 6, EmptyE ) ) ) ))
      let el = 2
              
      let _expectedVal = BodyE( 1,BodyE( 2, BodyE( 3, BodyE( 4, BodyE( 5, BodyE( 6, EmptyE ) ) ) ) ))
      let _reachedVal = insert tapeListE el
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let insert_ListE_El_Filled_LastButOne() =
      let tapeListE = BodyE( 1,BodyE( 2, BodyE( 3, BodyE( 5, BodyE( 6, EmptyE ) ) ) ))
      let el = 5
              
      let _expectedVal = BodyE( 1,BodyE( 2, BodyE( 3, BodyE( 5, BodyE( 5, BodyE( 6, EmptyE ) ) ) ) ))
      let _reachedVal = insert tapeListE el
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let insert_ListE_El_Filled_NewRightLimit() =
      let tapeListE = BodyE( 1,BodyE( 2, BodyE( 3, BodyE( 5, BodyE( 6, EmptyE ) ) ) ))
      let el = 7
              
      let _expectedVal = BodyE( 1,BodyE( 2, BodyE( 3, BodyE( 5, BodyE( 6, BodyE( 7, EmptyE ) ) ) ) ))
      let _reachedVal = insert tapeListE el
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let insert_ListE_El_Filled_EqualToRightLimit() =
      let tapeListE = BodyE( 1,BodyE( 2, BodyE( 3, BodyE( 5, BodyE( 6, EmptyE ) ) ) ))
      let el = 6
              
      let _expectedVal = BodyE( 1,BodyE( 2, BodyE( 3, BodyE( 5, BodyE( 6, BodyE( 6, EmptyE ) ) ) ) ))
      let _reachedVal = insert tapeListE el
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let insert_ListE_El_Filled_EqualToInnerTriple() =
      let tapeListE = BodyE( 1,BodyE( 3, BodyE( 3, BodyE( 3, BodyE( 6, EmptyE ) ) ) ))
      let el = 3
              
      let _expectedVal = BodyE( 1,BodyE( 3, BodyE( 3, BodyE( 3, BodyE( 3, BodyE( 6, EmptyE ) ) ) ) ))
      let _reachedVal = insert tapeListE el
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let insert_ListE_El_Empty() =
      let tapeListE = EmptyE
      let el = 4
              
      let _expectedVal = BodyE( 4,EmptyE )
      let _reachedVal = insert tapeListE el
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let insert_ListE_El_Single_Lower() =
      let tapeListE = BodyE( 6, EmptyE )
      let el = 4
              
      let _expectedVal = BodyE( 4,BodyE( 6, EmptyE ) )
      let _reachedVal = insert tapeListE el
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let insert_ListE_El_Single_Higher() =
      let tapeListE = BodyE( 6, EmptyE )
      let el = 8
              
      let _expectedVal = BodyE( 6,BodyE( 8, EmptyE ) )
      let _reachedVal = insert tapeListE el
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let insert_ListE_El_Single_Equal() =
      let tapeListE = BodyE( 6, EmptyE )
      let el = 6
              
      let _expectedVal = BodyE( 6,BodyE( 6, EmptyE ) )
      let _reachedVal = insert tapeListE el
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)