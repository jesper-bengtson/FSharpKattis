// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open Kattio

let rec testIntegers (s : Scanner) =
    printf "Input an integer: "
    if s.hasNext() then
        printfn "You wrote: %d" (s.NextInt ())
        testIntegers s
    else
        ()

let rec testFloats (s : Scanner) =
    printf "Input a float: "
    if s.hasNext() then
        printfn "You wrote: %f" (s.NextFloat ())
        testFloats s
    else
        ()

[<EntryPoint>]
let main argv =
    let s = new Scanner()
    testFloats s
    0 // return an integer exit code
