namespace Pwr.BT.Collections.Own.ListEager
    module Functionals =
    open Pwr.BT.Collections.Own.ListEager.Atomic

    let eFilterContains el tapeListE = eFilter (eContains el) tapeListE