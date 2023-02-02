let l = [ 1L .. 1000000L ]

//continuous passing style (CPS)
//continuous programing style (CPS)
let rec sum l cont =
    match l with
    | [] -> cont 0L
    | h :: t -> sum t (fun x -> cont (h + x))

let y = sum l id
printfn "%A" y

let z = sum l (fun x -> x + 1L)
printfn "%A" z
