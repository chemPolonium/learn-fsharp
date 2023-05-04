// 23 不可变与可变数据

// 不可变
let a = 2

// 可变数据
let mutable b = 3
b <- 5

let swap (a, b) = b, a
let x = swap (2, 4)

printfn "%A" a
printfn "%A" b
printfn "%A" x
