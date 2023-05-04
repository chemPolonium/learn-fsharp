// 25 使用 Some 对数据进行分类

// 默认情况下不允许使用 NULL
// 所有类型共享一个 NULL 会带来混乱
// 使用 None 可以避免这个问题
// 不同类型具有不同的 None
// 实际上 F# 支持 NULL 但是只用于和其他语言交流

let a = 2

// None: Option<'T>
// return type is int option
let makeOption x = if x = 0 then None else Some(x)

let f b =
    match b with
    | Some(_) -> "average value"
    | None -> "odd point"

printfn "%A" (a |> makeOption |> f)
