// 22 IF 和 ELIF

let f a = if a % 2 = 0 then "even" else "odd"

let f2 a =
    match a with
    | 0 -> "Zero"
    | 1 -> "One"
    | 2 -> "Two"
    | _ when a > 2 && a < 100 -> "big number"
    | _ when a >= 100 -> "huge number"
    | _ -> failwith "I do not understand this number"

printfn "%s" (f 3)
printfn "%s" (f2 3)
printfn "%s" (f2 -1)
