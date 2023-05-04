// 24 DU 作为分类

type Category =
    | Zero
    | Small
    | Big
    | Huge
    | VeryHuge

let categorize x =
    match x with
    | 0 -> Zero
    | 1
    | 2 -> Small
    | _ when x > 2 && x < 10 -> Big
    | _ when x >= 10 && x < 100 -> Huge
    | _ -> VeryHuge

printfn "%A" (categorize -1)
