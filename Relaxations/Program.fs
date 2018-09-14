// Learn more about F# at http://fsharp.org

open System

// Collections and subsumption relaxations
let x0: obj list = [ "a" ]
let x1: obj list = [ "a"; "b" ]
let x2: obj list = [ yield "a" :> obj ]

// Indentation relaxation
let f() =
    System.Console.WriteLine(format="{0}", arg=[| 
        "hello"
        |])
    System.Console.WriteLine([|
        "hello"
        |])

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
