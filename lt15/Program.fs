// 15 记录 元组 类

// 元组只是简单地组合在一起
// 对数据的说明不够
let dog0 = ("Tao", "German shepherd", "Lucky", 3)

// 记录，复杂度中等
let dog =
    {| Owner = "Tao"
       Breed = "German shepherd"
       DogName = "Lucky"
       Age = 3 |}

// 定义对象，最复杂
type Dog() =
    member val Owner = "Tao" with get
    member val Breed = "German shepherd" with get
    member val DogName = "Lucky" with get
    member val Age = 3

let dog2 = Dog()
