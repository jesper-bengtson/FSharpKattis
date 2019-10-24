open System.IO
open System

let printDifference x y = 
    printfn "%d" (abs (x + y))

[<EntryPoint>]
let main argv =
    (fun _ -> Console.ReadLine()) |>
    Seq.initInfinite |>
    Seq.takeWhile ((<>) null) |>
    Seq.iter 
       (fun (s : string) -> 
            let arr = s.Split([|' '|]) in 
                printDifference (int64 arr.[0]) (int64 arr.[1]))
    0
    