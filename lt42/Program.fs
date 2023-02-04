// 先定义后引用
type CommandType =
    | Deposit
    | Withdraw

type TCommand = Command of CommandType * int

let result = ref 7
let deposit x = result.Value <- result.Value + x
let withdraw x = result.Value <- result.Value - x

let Do =
    fun (cmd: TCommand) ->
        match cmd with
        | Command(CommandType.Deposit, n) -> deposit n
        | Command(CommandType.Withdraw, n) -> withdraw n

let Undo =
    fun (cmd: TCommand) ->
        match cmd with
        | Command(CommandType.Deposit, n) -> withdraw n
        | Command(CommandType.Withdraw, n) -> deposit n

printfn "current balance %d" result.Value
let depositCmd = Command(Deposit, 3)
