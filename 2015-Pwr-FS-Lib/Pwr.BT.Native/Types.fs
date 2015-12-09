﻿namespace Pwr.BT
    module Types =
        
    type eval = Num of float | Add | Sub | Mul | Div

    type 'a bt = Empty | Node of 'a * 'a bt * 'a bt

    type 'a llist = LKoniec | LElement of 'a * (unit -> 'a llist);;
