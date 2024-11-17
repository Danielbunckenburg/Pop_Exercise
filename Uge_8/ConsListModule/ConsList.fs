//ConsList.fs

module ConsList

type ConsList<'a> = 
    | Nil 
    | Cons of 'a * ConsList<'a>

let rec length xs = 
    match xs with
    | Nil -> 0
    | Cons (_, xs) -> 1 + length xs
