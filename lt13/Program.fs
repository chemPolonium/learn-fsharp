// 13 面向对象支持

type Dog() =
    member val Age = 2 with get, set
    member val Breed = "狼狗" with get

    member that.bark() = "wangwang"

    member this.叫() = "汪汪"
    member _.哭 = "..."

let dog = Dog()
dog.bark () |> printfn "%s"
dog.叫 () |> printfn "%s"
dog.哭 |> printfn "%s"
