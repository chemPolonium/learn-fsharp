let l = [ 1..100 ]

let rec sumBad l =
    match l with
    | [] -> 0
    | h :: t -> h + (sumBad t)

let ybad = sumBad l
printfn "%A" ybad
