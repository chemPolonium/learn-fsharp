let ``inc 1`` = (+) 1
let toKiloMeter = (*) 1.6
let ``20 div`` = (/) 20

let 开方 = sqrt
let 乘十 = (*) 10.
// >> 是组合函数
let 开方乘十 = 开方 >> 乘十

let result = ``inc 1`` 50
printfn $"result = {result}"

// 在这里要写 36.0 而不是 36
let result2 = 开方乘十 36.
printfn $"result = {result2}"
