let rec qs1 list cont =
    match list with
    | [] -> cont ([])
    | [ a ] -> cont ([ a ])
    | head :: tail ->
        let lessList = tail |> List.filter (fun i -> i <= head)
        let moreList = tail |> List.filter (fun i -> i > head)

        qs1 lessList (fun lessListPara ->
            qs1 moreList (fun moreListPara -> cont (lessListPara @ [ head ] @ moreListPara)))

//without CPS
let rec qs2 list =
    match list with
    | [] -> []
    | [ a ] -> [ a ]
    | head :: tail ->
        let lessList = tail |> List.filter (fun i -> i <= head)
        let moreList = tail |> List.filter (fun i -> i > head)
        qs2 lessList @ [ head ] @ qs2 moreList

let list = [ 0; 7; 2; 6; 8; 4; 1; 12 ]
let result1 = qs1 list id
let result2 = qs2 list

printfn "%A" result1
printfn "%A" result2
