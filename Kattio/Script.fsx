#load "Kattio.fs"
// Learn more about F# at http://fsharp.org. See the 'F# Tutorial' project
// for more guidance on F# programming.

open Kattio

    let s = new Scanner()

    let _ = printfn "%d" (s.NextInt())