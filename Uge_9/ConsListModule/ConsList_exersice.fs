
module ConsList_exersice
//Loading the module

#load "ConsList.fs"
open ConsList

let rec toList consList =  
    match consList with 
    | Nil -> [] 
    | Cons (head, tail) -> head :: toList tail



//Define function genConsList: int -> ConsList<int> such
//that genConsList n generates a cons-list with n elements where n >= 0. 

let rec genConsList n =
    if n <= 0 then
        Nil
    else 
        Cons(n,genConsList(n-1))


//Define function rev: ConsList<'a> -> ConsList<'a> such that rev reverses the input list, 
//that is, it lists its elements in reverse order.  


let rev consList =
    let rec helper acc lst =
        match lst with
        | Nil -> acc
        | Cons (head, tail) -> helper (Cons (head, acc)) tail
    helper Nil consList
