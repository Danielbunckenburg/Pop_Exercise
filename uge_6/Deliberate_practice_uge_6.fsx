//Deliberate practice - week 6

//Question 1

(*
let f v =
    if v > 0 then Some v
    else None


//let result1 = f -10 // expect none
//let result2 = f 10 //Expect "some 10" in output


//printfn "%A" result

//question 2


let f v =
    if v%2 = 0 then Some v // Using modulo operation that gives that is back after dividing, if what is back after devidion is 0, it is an even number if what is back is higher it must be uneven
    else None

let result3 = f 10

printfn "%A" result3


//question 3

let f v =
    if v.Length >5 then Some v // 
    else None

let result4 = (f "Daniel")



let f (v: string) =
    if v.Length > 5 then Some v
    else None

// Example usage:
let result1 = f "hello"      // "hello" has 5 characters, so this returns None
let result2 = f "worldwide"  // "worldwide" has 9 characters, so this returns Some "worldwide"
let result3 = f "FSharp"     // "FSharp" has 6 characters, so this returns Some "FSharp"

// Checking the results:
printfn "%A" result1  // Output: None
printfn "%A" result2  // Output: Some "worldwide"
printfn "%A" result3  // Output: Some "FSharp"



//Question 2. Generic types - 1

type Pair<'T> = Pair of 'T * 'T

let intPair: Pair<int> = Pair(4, 3)
let floatPair: Pair<float> = Pair(3.0, 2.0)
let stringPair: Pair<string> = Pair("povl", "eric")


let f (x: 'T) =
    printfn "%A" x

f 42            // prints: 42
f 3.14          // prints: 3.14
f "Hello world" // prints: "Hello world"
f [1; 2; 3]     // prints: [1; 2; 3]




//Qustion 2. Generic types - 2
let f (lst: 'T list) : 'T option =
    match lst with
    | [] -> None                // Return None if the list is empty
    | head :: _ -> Some head    // Return Some(head) if the list is not empty

// Test cases with explicit type annotations
let firstElement1: int option = f [1; 2; 3]         // returns Some 1
let firstElement2: string option = f ["a"; "b"; "c"] // returns Some "a"

// Output the results
printfn "%A" firstElement1  // Output: Some 1
printfn "%A" firstElement2  // Output: Some "a"
*)
//Question 2 - part 3

let f (arr: 'T array) : 'T option =
    if arr.Length = 0 then
        None                    // Return None if the array is empty
    else
        Some arr.[0]            // Return Some(first element) if the array is not empty

// Test cases
let firstElement1 = f [| 1; 2; 3 |]         // returns Some 1
let firstElement2 = f [| "a"; "b"; "c" |]   // returns Some "a"

// Output the results
printfn "%A" firstElement1  // Output: Some 1
printfn "%A" firstElement2  // Output: Some "a"

//question 3 - part 1

