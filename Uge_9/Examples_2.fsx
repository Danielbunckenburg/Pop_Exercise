#load "ConsListModule/ConsList.fs"
#load "ConsListModule/ConsList_exersice.fs"
open ConsList
open ConsList_exersice


let myConsList = Cons (1, Cons (2, Cons (3, Nil)))

let list20 = toList myConsList 

printfn("%A") list20


let exampleList = genConsList 10

printfn "%A" exampleList