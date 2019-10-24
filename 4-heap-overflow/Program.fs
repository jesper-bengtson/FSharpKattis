//Depending on the size of your heap this can run for a really long time

let rec infinite_insert x xs = infinite_insert x (x :: xs)

[<EntryPoint>]

let main argv =
    let lst = infinite_insert 0 []
    printfn "Done."
    0 
