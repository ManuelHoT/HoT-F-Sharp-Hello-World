open System

let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    let message = from "House of Test" 
    printfn "Hello world %s" message
    0 