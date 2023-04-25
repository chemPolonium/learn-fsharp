// 14 元组

let a = (2, 4)
let a1 = (2, 4)
let b = (2, 5)
let c = (a, "even pair")
let d = ((2, 4), "pair")

// 只要元组内部数据内容一样元组就是一样的
printfn "%A" (a = a1)
// 元组内部数据内容不一样的话就不相等
printfn "%A" (a = b)
