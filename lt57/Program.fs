// 定义 list

let l = [ 1..10 ]

// add
let newList = 100 :: l
let newList2 = l @ [ 100 ]

// retrieve
let newElement :: _ = newList
let newElement2 = newList2 |> Seq.last
