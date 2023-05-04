// 27 使用模块可以让项目更有序

// 使用 open 打开项目内的模块
// 项目内 Module1 需要排在 Program 前面才能找到
open Module1

let a = [ 1..10 ]
let b = [| 1..10 |]

for i in a do
    printfn "%d," i

// printInt 来自 Module1
a |> Seq.iter printInt
