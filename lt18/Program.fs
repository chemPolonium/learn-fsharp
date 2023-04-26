// 18 利用已有对象创建新对象

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

let puppy =
    { dog2 with
        Age = 1
        DogName = "Lovely" }

printfn "%A" puppy
