// 29 通过联合重新声明一个类型

type HumanName = HumanName of string
type DogName = DogName of string

// 此时这个函数只能接收 HumanName 参数
let f =
    function
    | HumanName(n) -> printfn "%s" n

let dogName = DogName("lucky")
let name = HumanName("Tao")

f name
