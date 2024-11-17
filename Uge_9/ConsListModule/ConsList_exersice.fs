
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


