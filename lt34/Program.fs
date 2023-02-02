type Customer(firstName, middleInitial, lastName) =
    member _.FirstName = firstName
    member _.MiddleInitial = middleInitial
    member _.LastName = lastName

    member this.SayFullName() =
        $"{this.FirstName} {this.MiddleInitial} {this.LastName}"

let customer = Customer("Emillia", "C", "Miller")

//这个会报错，属性不能修改
//customer.FirstName <- "NewFirstName"

printfn $"Hello, I'm {customer.SayFullName()}!"
