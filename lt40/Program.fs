// 静态解析类型
type Adder() =
    member _.Sub(a, b) = a - b
    member _.Add(a, b) = a + b // int * int -> int

// 这里的 Add 被转换过来了，变成了 int -> int -> int
let inline add (obj: ^T) a b =
    (^T: (member Add: int -> int -> int) (obj, a, b))

let adder = Adder()

printfn "%d" (add adder 2 3)
