// 20 联合的声明

type Point =
    | TwoD of int * int
    | ThreeD of int * int * int
    | OneD of int

let p1 = OneD(3)
let p2 = TwoD(1, 2)
let p3 = ThreeD(2, 3, 5)

let printPoint (p: Point) = printfn "%A" p

printPoint p1
printPoint p2
printPoint p3
