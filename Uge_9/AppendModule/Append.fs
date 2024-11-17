//defining append mondule

module append

type ConsList<'a> = 
    | Nil
    | Cons of 'a * ConsList<'a>

let rec append xs xs' =
    match xs with
    | Nil -> xs'
    | Cons (x, xsTail) -> Cons (x, append xsTail xs')
