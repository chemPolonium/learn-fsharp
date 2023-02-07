// 51 Seq 解决了如何表示无限的问题

// 在内存中间确实存在着 1 到 10
let a = [ 1..10 ]
let b = [| 1..10 |]

// 只是存储着产生 1 到 10 的函数
let seq =
    seq {
        for i = 1 to 10 do
            yield i
    }

printfn "%A" seq
