let f x =
    if (x < 0) then failwith "negative number" else "good"

let f2 x =
    try
        ignore <| f x
        printfn "good"
    with _ ->
        printfn "error"

f2 -1
