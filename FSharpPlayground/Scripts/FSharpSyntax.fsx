
// Immutable values

let myInt = 5
let myFloat = 3.14
let myString = "hello"

// Lists

let twoToFive = [2;3;4;5]
let oneToFive = 1 :: twoToFive
let zeroToFive = [0;1] @ twoToFive

// Functions

let square x = x * x
square 3

let add x y = x + y
add 2 3

let evens list = 
    let isEven x = x % 2 = 0
    List.filter isEven list

evens oneToFive

let sumOfSquaresTo100 = 
    List.sum ( List.map square [1..100] )

let sumOfSquaresTo100Piped =
    [1..100] |> List.map square |> List.sum

let sumOfSquaresTo100WithFun =
    [1..100] |> List.map (fun x -> x * x) |> List.sum

// Pattern Matching

let simplePatternMatch = 
    let x = "a"
    match x with
        | "a" -> printfn "x is a"
        | "b" -> printfn "x is b"
        | _ -> printfn "x is something else"

let validValud = Some(99)
let invalidValue = None

let optionPatternMatch input =
    match input with
        | Some i -> printfn "input is an int=%d" i
        | None -> printfn "input is missing"

optionPatternMatch validValud
optionPatternMatch invalidValue

