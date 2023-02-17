// 03 定义有两个参数的函数

let familyCost child adult =
    let result = child * 3 + adult * 5
    result

[<EntryPoint>]
let main _ =
    let cost = familyCost 2 2
    printfn $"total cost = {cost}"
    0
