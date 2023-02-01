open Module1

let a = [ 1..10 ]
let b = [| 1..10 |]

for i in a do
    printfn "%d," i

a |> Seq.iter printInt
