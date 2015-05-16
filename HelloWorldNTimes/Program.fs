open System

[<EntryPoint>]
let main argv = 
    let n = Console.ReadLine() |> int
    Seq.init n (fun i -> i) |> Seq.iter (fun i -> printfn "Hello World")
    0 // return an integer exit code
