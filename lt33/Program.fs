type Patterns =
    | BigNumber of int
    | HugeNumber

printfn "%s" (nameof (BigNumber))
printfn "%s" "BigNumber"
