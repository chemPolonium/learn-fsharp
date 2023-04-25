// 12 函数参数加上括号变成元组

// 如果只提供一个 x0 那么会报错
let distance (x0, y0) (x1, y1) =
    sqrt ((x0 - x1) ** 2. + (y0 - y1) ** 2.)

// x0 y0 x1 y1 没有依赖关系
let distance2 x0 y0 x1 y1 = ()

// 隐式声明元组
let a = 2., 2.
// 显式声明元组
let original = (0., 0.)

let x = a |> distance original

printfn "%A" x
