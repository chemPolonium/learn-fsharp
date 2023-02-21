// 06 含有入口点的 F# 程序执行顺序

let debug = printfn "reach here %d"

debug 1

let from whom = sprintf "from %s" whom

debug 2

[<EntryPoint>]
let main argv =
    printfn "entry main"
    let message = from "F#"
    printfn "Hello world %s" message
    0

// EntryPoint 后面不能写新东西了
