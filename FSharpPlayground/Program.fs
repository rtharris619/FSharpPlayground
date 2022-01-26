// Page 138 of 1930

[1..100] |> List.sum |> printfn "sum=%d"

let square x = x * x
let sq = square 42
printfn "Square 42? %A" sq

type Person = {First:string; Last:string}

type Employee =
    | Worker of Person
    | Manager of Employee list

let jdoe = {First="John"; Last="Doe"}
let worker = Worker jdoe

let person1 = {First="Jane"; Last="Doe"}
let person2 = {First="Tom"; Last="Doe"}
printfn "Equal? %A" (person1.Last = person2.Last)

let add2times3 = (+) 2 >> (*) 3
let result = add2times3 5
printfn "%A" result
