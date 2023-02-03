type Variant =
    | HugeNumber of int
    | BigNumber
    | SmallNumber

module FunctionLibrary =
    let print =
        function
        | HugeNumber n -> printfn "Num %d" n
        | BigNumber -> printfn $"nameof{BigNumber}"
        | SmallNumber -> printfn "Small number"

type Variant with

    member x.Print() = FunctionLibrary.print x

let a = Variant.SmallNumber
let b = Variant.HugeNumber 100
a |> FunctionLibrary.print
b.Print()
