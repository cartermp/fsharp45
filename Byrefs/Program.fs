// Learn more about F# at http://fsharp.org

open System

let print (x: inref<int>) =
    printfn "%d" x

let print2 (x: byref<int>) =
    printfn "%d" x
    x <- x * x
    printf "%d" x

[<EntryPoint>]
let main argv =

    let num = 12
    let mutable num2 = 13

    print &num
    print2 &num2

    let x =
        let mutable y = 12
        &y // Intentionally doesn't compile!

    0 // return an integer exit code
