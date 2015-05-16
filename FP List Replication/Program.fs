open System

let rec ReadAndPrintNum n =
    let num = Console.ReadLine() |> int
    Seq.init n (fun _ -> n) |> Seq.iter (fun _ -> printfn "%i" num)
    ReadAndPrintNum n

[<EntryPoint>]
let main argv = 
    let n = Console.ReadLine() |> int
    ReadAndPrintNum n
    0 // return an integer exit code
