//object expression
type IA =
    abstract MyFunction: int -> int
    abstract MyValue: string with get, set

let myFunction i = i + 1
//这个不能写在OE里面
let mutable str = "Hello"

let a =
    { new IA with
        member _.MyFunction i = myFunction i

        member _.MyValue
            with get () = str
            and set (i) = str <- i }
