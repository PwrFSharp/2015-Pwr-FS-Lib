namespace Pwr.BT.Collections.Own
        module eList =
            begin
                type 'T ListE =
                    |EmptyE
                    |Ele of 'T *('T eList)                                                        let isEmpty = function
                    |EmptyE -> true
                    |_ -> false
            end