// 26 在一个数组上循环

let a = [ 1..10 ]
let b = [| 1..10 |]

for i in a do
    printf "%d, " i

printfn ""

a |> Seq.iter (printf "%d, ")

printfn ""

// 比较复杂
// makeF 接收一个整数，输出一个打印该整形的函数
let makeF x = fun () -> printf "%d, " x
// 整形数列 -> 函数数列 -> Seq iter 调用
a |> Seq.map makeF |> Seq.iter (fun f -> f ())

printfn ""

// 太复杂没必要
// 整形数列 -> 函数数列 -> Seq reduce 将一组函数串起来
// reduce 类似于 fold
// >> 是函数的组合
let y = a |> Seq.map makeF |> Seq.reduce (>>)
y ()
