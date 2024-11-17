//STree.fs

module Stree

type STree<'a> =  
    LNode of 'a 
    |  INode of STree<'a> * 'a * STree<'a>

let rec SizeStree tree =
    match tree with
    |LNode _ -> 1
    |INode (left,_,right) -> 1 + SizeStree left + SizeStree right

let rec SumStree tree= 
    match tree with
    |LNode value -> value
    |INode (left,value,right) -> value + SumStree left + SumStree right

let rec height tree =
    match tree with
    | LNode _ -> 1
    | INode(left, _, right) -> 1 + max (height left) (height right)


let rec fold fLeaf fNode tree =
    match tree with
    | LNode value -> fLeaf value
    | INode(left, value, right) -> fNode (fold fLeaf fNode left) value (fold fLeaf fNode right)

let size' tree =
    fold (fun _ -> 1) (fun leftSize value rightSize -> 1 + leftSize + rightSize) tree

let sum' tree =
    fold (fun value -> value) (fun leftSum value rightSum -> value + leftSum + rightSum) tree

let height' tree =
    fold (fun _ -> 1) (fun leftHeight value rightHeight -> 1 + max leftHeight rightHeight) tree
