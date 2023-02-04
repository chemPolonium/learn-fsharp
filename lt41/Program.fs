let a = ref 1

// 等价为设置地址指向的值
// 已弃用
//a := 3
a.Value <- 3

// 等价为取地址的值
//printfn "%d" !a
printfn "%d" a.Value
