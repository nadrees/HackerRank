open System

[<EntryPoint>]
let main argv = 
    Seq.initInfinite (fun i -> (i, Console.ReadLine() |> int))
    |> Seq.filter (fun (i, num) -> i % 2 <> 0)
    |> Seq.iter (fun (i, num) -> printfn "%i" num)
    0 // return an integer exit code
