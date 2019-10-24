let rec listSum =
    function
    | []    -> 0
    | x::xs -> x + listSum xs

[<EntryPoint>]
let main argv =
    printfn "%A" (listSum [1..1000000])
    0