namespace Pwr.BT.Calc.Logic
    module Pred =

    let xor (a,b) =
        if a = not b then true
        else false

