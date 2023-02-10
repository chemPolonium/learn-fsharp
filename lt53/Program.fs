// 53 强制退出程序

open System

let f x =
    printfn "%d" x
    exit -1

let f2 x =
    printfn "%d" x
    raise <| Exception "error"

let f3 x =
    printfn "%d" x
    failwith "error"
