namespace Pwr.BT.Calc.Logic
    module Pred =

    let xor (a,b) = a = not b
    let xorA (a,b) = a <> b
    let imply(a,b) = not a || b

