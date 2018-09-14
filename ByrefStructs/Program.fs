// Learn more about F# at http://fsharp.org

open System

[<Struct>]
type S(range1: Span<int>, range2: Span<int>) =
    member __.Range1 = range1
    member __.Range2 = range2

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
