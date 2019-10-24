open System

let rec guess min max =
        let g = (min + max) / 2
        printfn "%d" g 
        match Console.ReadLine() with
        | "lower"   -> guess min g
        | "higher" -> guess g max
        | "correct" -> ()
        | _         -> guess min max
        
[<EntryPoint>]
let main argv =
    guess 1 1000
    0 // return an integer exit code
