let Null x = x
printfn "%A" (Null 3)
printfn "%A" (id 3)

//int->int->int
let f a b = a + b + 1
//利于柯里化
let f1 = f 0
//a和b有十分密切的关系，不能分离存在
let f2 (a, b) = a + b + 1

printfn "%A" (f1 1)
printfn "%A" (f2 (1, 2))
