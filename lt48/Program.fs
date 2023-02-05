let array = [| 1..10 |]
let v = array.[0]

let array2 = [| 1..2..10 |]
let v1 = array.[1]

array2 |> Seq.iter (printf "%d,")
