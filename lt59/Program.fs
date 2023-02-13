// inline

// int -> int -> int
let f x y = x + y
// 'a -> 'b -> 'c(requires member (+))
let inline f2 x y = x + y

printfn "f 1 2: %A" <| f 1 2
// 这一句会报错
// printfn "f 1 2: %A" <| f 1.0 2.0

printfn "f2 1 2: %A" <| f2 1 2
printfn "f2 1.0 2.0: %A" <| f2 1.0 2.0
