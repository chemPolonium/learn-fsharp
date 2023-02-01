type HumanName = HumanName of string
type DogName = DogName of string

let f =
    function
    | HumanName(n) -> printfn "%s" n

let dogName = DogName("lucky")
let name = HumanName("Tao")

f name
