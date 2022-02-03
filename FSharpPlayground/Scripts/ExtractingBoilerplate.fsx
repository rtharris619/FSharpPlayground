
let product n =
    let initialValue = 1
    let action productSoFar x = productSoFar * x
    [1..n] |> List.fold action initialValue


let p = product 4
printfn "%d" p

let sumOfOdds n = 
    let initialValue = 0
    let action sumSoFar x = if x % 2 = 0 then sumSoFar else sumSoFar + x
    [1..n] |> List.fold action initialValue

let s = sumOfOdds 3
printfn "%d" s

let alternatingSum n =
    let initialValue = (true, 0)
    let action (isNeg, sumSoFar) x = if isNeg then (false, sumSoFar - x)
                                              else (true, sumSoFar + x)
    [1..n] |> List.fold action initialValue |> snd

let a = alternatingSum(2)
printfn "%d" a
