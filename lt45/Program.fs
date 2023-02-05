let process0 =
    function
    | Ok x ->
        if x > 0 then
            printfn "valid value, continue"
            Ok(System.Random().Next(-1, 3))
        else
            Error "Must be positive"
    | Error _ as y -> y

printfn "%A" ((Ok 1) |> process0 |> process0 |> process0)
