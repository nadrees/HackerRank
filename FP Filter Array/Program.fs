open System

let rec FilterInputs n =
    let next = Console.ReadLine() |> int
    
    match next with
    | num when num < n -> printfn "%i" num
    | _ -> ()
    
    FilterInputs n

[<EntryPoint>]
let main argv = 
    let n = Console.ReadLine() |> int
    FilterInputs n
    0 // return an integer exit code
