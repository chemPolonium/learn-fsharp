// 05 F# 的入口点

// F# 没有入口点的时候是顺序执行的

let ask student ``a question`` =
    printf "me ask %s: %s" student ``a question``

let askJohn = ask "John"

askJohn "How old are you?"
