//tree
module Tree

type Tree<'a> = Leaf of 'a | Fork of Tree<'a> * Tree<'a>

let rec size t =
    match t with   
    Leaf _ -> 1
    |Fork(t1,t2) -> size t1 + size t2

// Function to compute the product of integer leaves
let rec treeprod t =
    match t with
    | Leaf x -> x
    | Fork (t1, t2) -> treeprod t1 * treeprod t2

// Function to compute the sum of integer leaves
let rec treesum t =
    match t with
    | Leaf x -> x
    | Fork (t1, t2) -> treesum t1 + treesum t2
