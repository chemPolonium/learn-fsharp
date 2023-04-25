// 16 元组解包

let tuple = (1, 2, 3)
let b = (2, 3, 5)
let c = (tuple, 12, 13)

let x, _, z = tuple
let a, _, _ = c
let (x0, y0, z0), _, _ = c

printfn $"{x} and {z}"
printfn $"{a} and {x0}"
