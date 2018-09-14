// Learn more about F# at http://fsharp.org

open System

type Sequenceinator5000() =
    let mutable nums = [| 1; 3; 7; 15; 31; 63; 127; 255; 511; 1023 |]

    override __.ToString() = String.Join(' ', nums)

    member __.FindLargestSmallerThan(target: int) =
        let mutable ctr = nums.Length - 1

        while ctr > 0 && nums.[ctr] >= target do
            ctr <- ctr - 1

        if ctr > 0 then
            &nums.[ctr]
        else
            &nums.[0]

[<EntryPoint>]
let main argv =
    let s = Sequenceinator5000()

    printfn "%s" (s.ToString())

    let target = 16
    let result = &s.FindLargestSmallerThan(16)
    result <- result * 2

    printfn "%s" (s.ToString())

    0 // return an integer exit code
