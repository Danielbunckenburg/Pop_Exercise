//examples.fsx

#load "Stree.fs"
open Stree


let singleLeaf = LNode 5
//Simple tree


let simpleTree = INode(LNode 3, 7, LNode 9)
// Tree:       7
//           /   \
//          3     9
let complexTree = 
    INode(
        INode(LNode 1, 2, LNode 3), // Left subtree
        4,                           // Root value
        INode(LNode 5, 6, LNode 7)   // Right subtree
    )
// Tree structure:
//             4
//           /   \
//          2     6
//         / \   / \
//        1   3 5   7


let tree = INode(LNode 1, 2, INode(LNode 3, 4, LNode 5))

let treeSize = size' tree       // Output: 5
let treeSum = sum' tree         // Output: 15
let treeHeight = height' tree   // Output: 3