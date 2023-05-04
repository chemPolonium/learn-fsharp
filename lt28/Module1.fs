// 命名空间可以跨越文件出现
// 只要打开命名空间，分布在不同文件中的同一个命名空间都会被打开
// 模块则一般不能跨文件
namespace MyNamespace

type StringAlias = String

module Module1 =
    let printInt = printfn "%d"

module Module2 =
    let f () = printfn "in function f"
