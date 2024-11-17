//examples.fsx

#load "SnocList.fs"
open SnocList

// Create example snoc-lists
let intList = Snoc(Snoc(Snoc(Empty, 1), 2), 3)
let anotherIntList = Snoc(Snoc(Empty, 4), 5)
let combinedList = append intList anotherIntList

let stringList = Snoc(Snoc(Empty, "a"), "b")
let anotherStringList = Snoc(Snoc(Empty, "c"), "d")
let combinedStringList = append stringList anotherStringList

// Show results for integer list functions
printfn "Length of intList: %d" (length intList)
printfn "Sum of intList: %d" (sum intList)
printfn "Length of combinedList: %d" (length combinedList)
printfn "Sum of combinedList: %d" (sum combinedList)

// Show results for string list functions
printfn "Length of stringList: %d" (length stringList)
printfn "Length of combinedStringList: %d" (length combinedStringList)