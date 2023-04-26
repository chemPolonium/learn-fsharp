// 17 类型与记录不是一个东西

let dog =
    {| Owner = "Tao"
       Breed = "German shepherd"
       DogName = "Lucky"
       Age = 3 |}

let anotherDog =
    {| Owner = "Tao"
       Breed = "German shepherd"
       DogName = "Lucky"
       Age = 3 |}

type Dog =
    { Owner: string
      Breed: string
      DogName: string
      Age: int }

let dog2 =
    { Owner = "Tao"
      Breed = "German shepherd"
      DogName = "Lucky"
      Age = 3 }

let dog3 =
    { Owner = "Tao"
      Breed = "German shepherd"
      DogName = "Lucky"
      Age = 3 }

printfn $"{dog = anotherDog}"
printfn $"{dog2 = dog3}"
// 下式会报错，记录和类不一样
// printfn $"{dog = dog2}"
