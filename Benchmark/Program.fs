// Learn more about F# at http://fsharp.org

open System

open BenchmarkDotNet.Attributes
open BenchmarkDotNet.Running

// "123,456"
// Gets 3 and 4
let parseOld (str: string) =
    let commaPos = str.IndexOf ','
    let first = Int32.Parse(str.Substring(0, commaPos))
    let second = Int32.Parse(str.Substring(commaPos + 1))
    first, second

// "123,456"
// Gets 3 and 4
let parseNew (str: string) =
    let span = str.AsSpan()
    let commaPos = span.IndexOf ','
    let first = Int32.Parse(span.Slice(0, commaPos))
    let second = Int32.Parse(span.Slice(commaPos + 1))
    struct(first, second)

[<MemoryDiagnoser>]
type Bench() =
    let str = "123,456"
    let count = 10000000
    let data = Array.create count str

    [<Benchmark>]
    member __.Old() =
        Array.map parseOld data |> ignore

    [<Benchmark>]
    member __.New() =
        Array.map parseNew data |> ignore

[<EntryPoint>]
let main argv =
    let summary = BenchmarkRunner.Run<Bench>()
    printfn "%A" summary
    0 // return an integer exit code