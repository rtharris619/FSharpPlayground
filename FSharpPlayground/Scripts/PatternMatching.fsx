
type Shape = 
    | Circle of int
    | Rectangle of int * int
    | Polygon of (int * int) list
    | Point of (int * int)

let draw shape =
    match shape with
    | Circle radius ->
        printfn "The circle has a radius of %d" radius
    | Rectangle (height, width) ->
        printfn "The rectangle is %d high by %d wide" height width
    | Polygon points ->
        printfn "The polygon is made of these points %A" points
    | _ -> printfn "I don't recognise this shape"


let circle = Circle(10)
let rectangle = Rectangle(4, 5)
let polygon = Polygon([(1, 1); (2, 2); (3, 3)])
let point = Point(2, 3)

[circle; rectangle; polygon; point] |> List.iter draw
