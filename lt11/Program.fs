﻿// 11 忽略返回值

let 开方 = sqrt
let 乘十 = (*) 10.
let 开方乘十 = 开方 >> 乘十

let 学生分数 = 60.
// 添加了管道操作符
let result = 学生分数 |> 开方乘十

printfn $"result = {result}"

// 使用 ignore 忽略返回值
0 |> ignore
