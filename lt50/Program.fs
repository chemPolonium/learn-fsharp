[<AutoOpen>]
module MyModule =
    let a = 100

// 不加 AutoOpen 无法编译
printfn "%d" a

// 正常方式引用
printfn "%d" MyModule.a
