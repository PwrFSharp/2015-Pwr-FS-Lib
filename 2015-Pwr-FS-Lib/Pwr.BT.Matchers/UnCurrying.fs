namespace Pwr.BT
    module UnCurry =
    open Curry

    let uncurry3 f (x,y,z) = f x y z

    let uncurry2 f (x,y) = f x y

    let uncurry1 f (x) = f x

    let plusR x y = x+y

    let plus (x,y) = x+y

    let add = curry2 plus

    uncurry2 add (4,5)

    let (|~@) f g = fun x -> f ( g x)


