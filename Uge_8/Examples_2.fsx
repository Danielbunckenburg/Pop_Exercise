#load "ConsListModule/ConsList.fs"
#load "ConsListModule/ConsList_exersice.fs"
#load "STreeModule/STree.fs"
open ConsList
open ConsList_exersice
open Stree


let myConsList = Cons (1, Cons (2, Cons (3, Nil)))

let list20 = toList myConsList 

printfn("%A") list20


let exampleList = genConsList 10

printfn "%A" exampleList




let myTree = Node (1, Node (2, Leaf, Leaf), Node (3, Leaf, Leaf))

printfn "%A" myTree