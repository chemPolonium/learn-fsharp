type IA =
    abstract member MyValue2: string with get, set

type MyBase() =
    member val MyValue = "MyString" with get, set

type MyClass() =
    inherit MyBase()

    interface IA with
        member _.MyValue2
            with get () = base.MyValue
            and set (i) = base.MyValue <- i

let mc = MyClass()

let b = mc :> IA
printfn "%s" b.MyValue2
