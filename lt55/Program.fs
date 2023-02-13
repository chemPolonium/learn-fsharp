// 55 使用 box 打包 obj

let a = 4
// obj 是 .NET 平台上的通用类型
let b = box (a)
// 但是最好之后拆包的时候告知类型
let c = unbox<int> (b)
