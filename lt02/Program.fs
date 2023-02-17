// 02 F# 的类型系统

let from whom =
    // 通过使用方法推断 whom 是一个 string
    // 通过 sprintf 的返回类型推断 from 的返回类型
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    // 通过 from 的返回类型推断 message 的类型
    let message = from "F#"
    printfn "Hello world %s" message
    0
