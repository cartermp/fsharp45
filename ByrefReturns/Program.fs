// Learn more about F# at http://fsharp.org

open System

type Sequenceinator5000() =
    let mutable nums = [| 1; 3; 7; 15; 31; 63; 127; 255; 511; 1023 |]

    override __.ToString() = String.Join(' ', nums)

    member __.FindLargestSmaller(target: int) =
        let mutable ctr = nums.Length - 1

        while ctr > 0 && nums.[ctr] >= target do
            ctr <- ctr - 1

        if ctr > 0 then
            &nums.[ctr]
        else
            &nums.[0]

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
