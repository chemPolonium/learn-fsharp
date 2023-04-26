// 21 联合的实际使用

type Dog =
    { Owner: string
      Breed: string
      DogName: string
      Age: int }

let dog =
    { Owner = "Tao"
      Breed = "corgi"
      DogName = "Lucky"
      Age = 2 }

type Cat() =
    member val Owner = "Tao" with get, set
    member val Name = "Lovely" with get, set
    member val Age = 2 with get, set

// 这里的 new 不一定可以省略
// 下面的代码会被警告
// let f = FileStream("hello.txt", FileMode.Open)
let cat = new Cat()
let cat1 = Cat(Name = "Vanilla")

// 这里新的 Dog 遮蔽了原有的 Dog
type Animal =
    | Dog of Dog
    | 猫 of Cat

let printName animal =
    match animal with
    | Dog d -> printfn "%A" d.DogName
    | 猫 c -> printfn "%A" c.Name

let d = Dog dog
let c = 猫 cat
let c1 = 猫 cat1

printName d
printName c
printName c1
