open MyNamespace
open Module1

let a = [ 1..10 ]
let b = [| 1..10 |]

for i in a do
    printfn "%d," i
    MyNamespace.Module2.f ()

a |> Seq.iter printInt
