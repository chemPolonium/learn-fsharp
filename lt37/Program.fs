let rec qs list cont =
    match list with
    | [] -> cont ([])
    | [ a ] -> cont ([ a ])
    | head :: tail ->
        let lessList = tail |> List.filter (fun i -> i <= head)
        let moreList = tail |> List.filter (fun i -> i > head)

        qs lessList (fun lessListPara ->
            qs moreList (fun moreListPara -> cont (lessListPara @ [ head ] @ moreListPara)))

let list = [ 0; 7; 2; 6; 8; 4; 1; 12 ]
let result = qs list id

for i in result do
    printfn "%A" i
