// 04 使用中文定义单位 unit of measure

[<Measure>]
type 元

[<Measure>]
type 小孩

[<Measure>]
type 大人

let kidPrice = 3<元 / 小孩>
let adultPrice = 5<元 / 大人>

let familyCost (child: int<小孩>) (adult: int<大人>) =
    let result = kidPrice * child + adultPrice * adult
    result

[<EntryPoint>]
let main _ =
    let cost = familyCost 2<小孩> 2<大人>
    printfn $"total cost = {cost}"
    0
