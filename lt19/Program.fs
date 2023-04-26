// 19 记录就是加了名字的元组
// 不要什么都用记录写

// 声明记录
type Dog =
    { Owner: string
      Breed: string
      DogName: string
      Age: int }

// Dog2 后声明，所以 dog2 被匹配到 Dog2
type Dog2 =
    { Owner: string
      Breed: string
      DogName: string
      Age: int }

// 自动匹配至 Dog2
let dog2 =
    { Owner = "Tao"
      Breed = "German shepherd"
      DogName = "Lucky"
      Age = 3 }

// 显式声明 Owner 属于 Dog 后自动匹配至 Dog
// 避免使用这种方法
let dog3 =
    { Dog.Owner = "Tao"
      Breed = "German shepherd"
      DogName = "Lucky"
      Age = 3 }

let puppy =
    { dog2 with
        Age = 1
        DogName = "Lovely" }

printfn "%A" puppy
