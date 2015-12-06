namespace Pwr.BT.Test
    module Test_LazyLists =
    
    open System
    open System.Collections
    open NUnit.Framework
    open NUnit.Framework.Constraints
    open Pwr.BT.Types
    open Pwr.BT.Collections.List.Lazy.Oper
    open Pwr.BT.Collections.List.Iter
    open Pwr.BT.Collections.ReferencesToLists
    open Pwr.BT.Matchers.ListOfLists
    open Pwr.BT.Collections.List.Oper

    [<Test>]
    let Lhd_Functor() =
      let gList = [1;2;3;4]
      let lList = toLazyList gList
 
      let _expectedVal = 1
      let _reachedVal = lhd lList
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let Lhead_Functor() =
      let gList = [1;2;3;4]
      let lList = toLazyList gList
 
      let _expectedVal = 1
      let _reachedVal = lhead lList
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let Ltail_Functor() =
      let gList = [1;2;3;4]
      let lList = toLazyList gList
 
      let l_expectedVal = toLazyList [2;3;4]
      let l_reachedVal = ltl lList

      let _expectedVal = ltake(3,l_expectedVal)
      let _reachedVal = ltake(3,l_reachedVal)
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let LHeadFromTail_Functor() =
      let gList = [1;2;3;4]
      let lList = toLazyList gList
 
      let _expectedVal = 2
      let _reachedVal =lhd( ltl lList )
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let LHead_Concat_HeadFromTail_Functor() =
      let gList = [1;2;3;4]
      let lList = toLazyList gList
 
      let _expectedVal = [1;2]
      let _reachedVal =lhd(lList)::lhd(ltl lList)::[]
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let LToEager_Functor() =
      let gList = [1;2;3;4]
      let lList = toLazyList gList
 
      let _expectedVal = [1;2;3;4]
      let _reachedVal = toEagerList lList
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eList_and_eList_FoldLeftTwo_Val_Add() =
      let eList1 = [1;2;3;4]
      let eList2 = [1;2;3;4]
 
      let _expectedVal = 20
      let _reachedVal = foldLeftTwo (+) 0 (eList1,eList2)
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eList_and_eList_FoldLeftTwo_Val_Mult() =
      let eList1 = [1;2;3;4]
      let eList2 = [1;2;3;4]
 
      let _expectedVal = 576
      let _reachedVal = foldLeftTwo (*) 1 (eList1,eList2)
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eList_and_eList_Dzialanie_ListVal_Mult1() =
      let eList1 = [1;2;3;4]
      let eList2 = [1;2;3;4]
 
      let _expectedVal = [2;4;6;8]
      let _reachedVal = dzialanie2 eList1 eList2 (+)
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

//    [<Test>]
//    let eList_and_eList_Dzialanie_ListVal_Mult3() =
//      let eList1 = [1;2;3]
//      let eList2 = [1;2;3;4]
// 
//      let _expectedVal = [2;4;6;4]
//      let _reachedVal = dzialanie eList1 eList2 (+)
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)

    [<Test>]
    let eList_and_eList_Dzialanie_ListVal_Mult2() =
      let eList1 = []
      let eList2 = []
 
      let _expectedVal = []
      let _reachedVal = dzialanie2 eList1 eList2 (+)
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eList_and_eList_Dzialanie_FoldLeftWIthTwo_Mult() =
      let eList1 = [1;2;3;4]
      let eList2 = [1;2;3;4]
 
      let _expectedVal = [2;4;6;8]
      let _reachedVal = foldLeftTwoInList (+) [] (eList1,eList2)
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let eList_and_eList_FoldLeftTwo_Val_Concat() =
      let eList1 = [1;2;3;4]
      let eList2 = [5;6;7;8]
      let eList3 = [eList1;eList2]

      let eList4 = [-1;-2;-3;-4]
      let eList5 = [-5;-6;-7;-8]
      let eList6 = [eList4;eList5]
 
      let _expectedVal = [1;2;3;4;-1;-2;-3;-4;5;6;7;8;-5;-6;-7;-8]
      let _reachedVal = foldLeftTwo (append) [] (eList3,eList6)
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

//    [<Test>]
//    let eList_and_eList_DzialanieG_eList_Concat() =
//      let eList1 = [1;2;3]
//      let eList2 = [2;3;4;5]
// 
//      let _expectedVal = [3;5;7;5]
//      let _reachedVal = dzialanie eList1 eList2 (+)
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)

//    [<Test>]
//    let eList_and_eList_DzialanieG_eList_Concat() =
//      let eList1 = [1;2;3]
//      let eList2 = [2;3;4]
// 
//      let _expectedVal = [3;5;7]
//      let _reachedVal = dzialanie eList1 eList2 (+)
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)

//    [<Test>]
//    let eList_and_eList_FoldLeftTwo_Val_Mult_InSuff() =
//      let eList1 = [1;2;3;4]
//      let eList2 = [1;2;3;4;5;6]
// 
//      let _expectedVal = 17280
//      let _reachedVal = foldLeftTwo (*) 1 (eList1,eList2)
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)

    [<Test>]
    let lList_and_lList_FoldLeftTwo_Val_Mult() =
      let eList1 = [1;2;3;4]
      let eList2 = [1;2;3;4]

      let lList1 = toLazyList eList1
      let lList2 = toLazyList eList2
 
      let _expectedVal = 576
      let _reachedVal = lfold_left_two (*) 1 (lList1,lList2)
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

    [<Test>]
    let LazyList_FoldLeft_EagerList() =
      let gList = [1;2;3;4]
      let lList = toLazyList gList
 
      let _expectedVal = 10
      let _reachedVal = lfold_left (+) 0 lList
    
      let _reachedLogic = _expectedVal = _reachedVal
    
      Assert.True(_reachedLogic)

//    [<Test>]
//    let LfoldLeft_Functor_2_Add() =
//      let gList1 = [1;2;3]
//      let lList1 = Oper.toLazyList gList1
//
//      let gList2 = [2;3;4;5]
//      let lList2 = Oper.toLazyList gList2
// 
//      let l_expectedVal = Oper.toLazyList [3;5;7;5]
//      let l_reachedVal = Oper.ldzialanie lList1 lList2 (+)
//
//      let _expectedVal = Oper.ltake(4,l_expectedVal)
//      let _reachedVal = Oper.ltake(4,l_reachedVal)
//    
//      let _reachedLogic = _expectedVal = _reachedVal
//    
//      Assert.True(_reachedLogic)