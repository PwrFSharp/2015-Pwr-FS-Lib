namespace Pwr.BT
    module Types =
            
    type 'a eList = Koniec | Element of 'a * ('a eList);;


