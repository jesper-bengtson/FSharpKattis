// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System.IO

[<EntryPoint>]
let main argv =
    File.ReadAllLines("/etc/passwd") |> 
    Array.iter (printfn "%s")
    0 // return an integer exit code
