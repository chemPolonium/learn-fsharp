// 28 使用命名空间组织模块

// open MyNamespace.Module1
open MyNamespace
open Module1

let a = [ 1..10 ]
let b = [| 1..10 |]

for i in a do
    printfn "%d," i
    MyNamespace.Module2.f ()

a |> Seq.iter printInt
