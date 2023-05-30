// 类，接口，显式转换

// 约定接口都以 I 开头
type IAsType<'T> =
    // 抽象的成员，不管是方法还是属性
    abstract member NewValue: 'T with get, set

// 定义一个类
type MyClass() =
    // 类里面的一个可变属性
    let mutable v = 8

    // 实例化一个接口使其变成一个真正的类型
    interface IAsType<int> with
        // 所有的方法和属性都以 member 开始
        member _.NewValue
            // 实例化类型时提供接口实现
            with get () = v
            // 这里是要赋值
            and set (i) = v <- i

    // 另一个实例
    interface IAsType<string> with
        member _.NewValue
            with get () = v.ToString()
            and set (i) = v <- System.Convert.ToInt32(i)

// 不需要 new
let mc = MyClass()
// 输入 mc 时自动补全不会给出里面的接口
// 需要显式进行类型转换转换成接口
// a 的类型是 IAsType<int>
let a = mc :> IAsType<int>
let b = mc :> IAsType<string>
a.NewValue <- 4
printfn "%s" b.NewValue
