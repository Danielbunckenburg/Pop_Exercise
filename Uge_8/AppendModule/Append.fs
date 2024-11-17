//defining append mondule

module append

type ConsList<'a> = 
    | Nil
    | Cons of 'a * ConsList<'a>

let rec append xs xs' =
    match xs with
    | Nil -> xs'
    | Cons (x, xsTail) -> Cons (x, append xsTail xs')



/// Recursive definition of appendAll
let rec appendAll (xss: 'a list list) : 'a list =
    match xss with
    | [] -> []                           // Base case: empty list of lists
    | xs :: xss' -> xs @ appendAll xss'  // Recursive case: concatenate the head with the result of the tail