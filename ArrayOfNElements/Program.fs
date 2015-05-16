open System

let f n = 
    Seq.init n (fun _ -> n)
    |> Seq.toArray


let main() =
    let input = Console.ReadLine()
    let n = int input
    printfn "%d" (f n).Length

 
main()