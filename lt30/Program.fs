type IAsType<'T> =
    abstract member NewValue: 'T with get, set

type MyClass() =
    let mutable v = 8

    interface IAsType<int> with
        member _.NewValue
            with get () = v
            and set (i) = v <- i

    interface IAsType<string> with
        member _.NewValue
            with get () = v.ToString()
            and set (i) = v <- System.Convert.ToInt32(i)

let mc = MyClass()
let a = mc :> IAsType<int>
let b = mc :> IAsType<string>
a.NewValue <- 4
printfn "%s" b.NewValue
