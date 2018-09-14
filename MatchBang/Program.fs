// Learn more about F# at http://fsharp.org

open System

let tryParseIntAsync (value: string) =
    async {
        match Int32.TryParse(value) with
        | (true, v) -> return Some v
        | (false, _) -> return None
    }

let print str =
    async {
        let! result = tryParseIntAsync str
        match result with
        | Some i -> printfn "%d" i
        | None -> printfn "Not an int!"
    }

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
