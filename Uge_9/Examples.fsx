// Examples.fsx
#load "ConsListModule/ConsList.fs"
#load "TreeModule/Tree.fs"

open Tree
open ConsList
(*
// Create some cons-lists and compute their lengths
let list1 = Nil
let list2 = Cons(1, Nil)
let list3 = Cons(1, Cons(2, Nil))
let list4 = Cons(1, Cons(2, Cons(3, Nil)))


// Side-effecting statements to show the results
printfn "Length of list1 (Nil): %d" (length list1)         // Expected: 0
printfn "Length of list2 (Cons 1, Nil): %d" (length list2) // Expected: 1
printfn "Length of list3 (Cons 1, Cons 2, Nil): %d" (length list3) // Expected: 2
printfn "Length of list4 (Cons 1, Cons 2, Cons 3, Nil): %d" (length list4) // Expected: 3




// Define the sum function
let rec sum xs =
    match xs with
    | Nil -> 0
    | Cons (head, tail) -> head + sum tail

// Testing the sum function with some cons-lists
let list1 = Nil
let list2 = Cons(1, Nil)
let list3 = Cons(1, Cons(2, Nil))
let list4 = Cons(1, Cons(2, Cons(3, Nil)))

// Print out the results
printfn "Sum of list1 (Nil): %d" (sum list1)           // Expected: 0
printfn "Sum of list2 (Cons 1, Nil): %d" (sum list2)   // Expected: 1
printfn "Sum of list3 (Cons 1, Cons 2, Nil): %d" (sum list3) // Expected: 3
printfn "Sum of list4 (Cons 1, Cons 2, Cons 3, Nil): %d" (sum list4) // Expected: 6
*)



// Example tree for testing
let exampleTree = Fork (Leaf 2, Fork (Leaf 3, Leaf 4))

// Test size function
let sizeResult = size exampleTree
printfn "Size of exampleTree: %d" sizeResult  // Output should be 3

// Test treeprod function
let productResult = treeprod exampleTree
printfn "Product of leaves in exampleTree: %d" productResult  // Output should be 24

// Test treesum function
let sumResult = treesum exampleTree
printfn "Sum of leaves in exampleTree: %d" sumResult  // Output should be 9
