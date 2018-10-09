// Learn more about F# at http://fsharp.org

open System

let tryParseIntAsync (value: string) =
    async {
        match Int32.TryParse(value) with
        | (true, v) -> return ValueSome v
        | (false, _) -> return ValueNone
    }

let print str =
    async {
        match! tryParseIntAsync str with
        | ValueSome x -> printfn "%d" x
        | ValueNone -> printfn "No parsy!"
    }

[<EntryPoint>]
let main argv =
    [print "12"; print "13"; print "phillip"]
    |> Async.Parallel
    |> Async.RunSynchronously
    |> ignore
    0 // return an integer exit code
