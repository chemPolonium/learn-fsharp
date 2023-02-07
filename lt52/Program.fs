// 52 一个完整的类的例子和关键字 do

open System

type MyType(a: int, b: int) as self =
    // 实际上所有的 type 都是从 Object 继承过来的，写了个寂寞
    inherit Object()
    // 真正的构造函数
    let x = 2 * a
    let y = 2 * b
    // 现在就运行的函数
    do printfn "Initializing object %d %d %d %d %d %d" a b x y (self.Prop1) (self.Prop2)
    // 静态的构造函数也可以加 do
    static do printfn "Initializing MyType."
    // 可以直接引用同级的 x 和 y
    member _.Prop1 = 4 * x
    member _.Prop2 = 4 * y
    override this.ToString() = $"{this.Prop1}, {this.Prop2}"

// 静态的构造函数先被引用，先显示 Initializing MyType
let obj1 = new MyType(1, 2)

printfn "%A" obj1
