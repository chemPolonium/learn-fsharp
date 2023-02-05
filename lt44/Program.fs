let f (a, b, c) =
    let delta = b ** 2. - 4. * a * c
    if (delta < 0.) then Error "无实根" else Ok delta

let x = f (1., float (2), 4 |> float)

printfn "%A" x
