namespace Pwr.BT
    module Curry =
    let curry3 f x y z = f( x, y, z)

    let curry2 f x y = f(x,y)

    let plusZ (x,y) = x+y;

    let add = curry2 plusZ

