// 58 lazy

let x = 1
let y = lazy (x + 1)

printfn "y = %A" y
printfn "y value = %d" (y.Force())
