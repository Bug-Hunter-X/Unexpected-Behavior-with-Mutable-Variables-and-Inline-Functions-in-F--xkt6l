let mutable x = 10
let mutable y = 20

let add x y =  x + y

let inline add2 x y = x + y

let mutable z = add x y
printf "%d" z

let mutable a = add2 x y
printf "%d" a
