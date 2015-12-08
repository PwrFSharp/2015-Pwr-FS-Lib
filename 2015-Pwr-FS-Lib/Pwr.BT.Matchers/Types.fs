namespace Pwr.BT
    module Types =
            
    type 'a llist = LKoniec | LElement of 'a * (unit -> 'a llist);;

    type 'a eList = Koniec | Element of 'a * ('a eList);;


