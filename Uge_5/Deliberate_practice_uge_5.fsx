
(*
//Deliberate practice - week 5
//Define a mutable variable of type int and value 0; write a while loop that iterates 10 times and print the value of the variable at each iteration
// (hint: the mutable variable is increase by one at each iteration)
 //let mutable i:int = 0
//while i <10 do
 //   printfn "%d" i
//i <- i + 1

//Define a mutable variable ot type int and value 1; write a while loop that prints the value of the mutable variable and increases
// it by 1 at each iteration until the value of the mutable variable is divisible by 5 
//(i.e., the remainder of the division by 5 is 0 - e.g., the result of 2 % 5  is 2 and the result of the 8%5 is 3).

//let mutable i: int = 1

//while (i/5<1) do
 //   printfn "%d" i
 //   i <- i + 1

//Write a while loop that prints "#" 15 times.


//let mutable i:int = 0

//while i <15 do
 //   printfn "#" 
 //   i <- i+1

//Write a while loop that prints "#" indefinitely (use ctrl-c to break the infinite loop)
//let mutable i:int = 0

//while i <15 do
 //   printfn "#" 


 //Define a mutable variable of type int with the value of your choice; Write a 
 //while loop that prints the value of this mutable variable and multiply it by itself until the value of the variable reaches 1000.


//let mutable i: int = 2

//while (i<1000) do
  //  printfn "%d" i 
   // i <- i *i



//Write a function that swaps the values of two mutable variables
let mutable i: int = 2
let mutable j: int = 3
while (i<1000) do
    printfn "%d" i 
    i <- i *i

Create an array with the values "a", "b", "c" and "d".
let array = [|"a";"b";"c";"d"|]
printfn"%A" array



Create an array with the values 1.1, 1.2, 1.3, 1.4 .

let array = [|1.1;1.2;1.3;1.4|]
printfn"%A" array


Create an array of 20 integers initialised at 0 
let a:int array=Array.zeroCreate 20
printfn"%A" a



// Create an array of 20 integers initialized with the square of their index
let arr = Array.init 20 ( fun i -> i *i )

// Print the array
printfn "%A" arr


let lenghtarray = Array.length arr



printfn "%A" lenghtarray

let mutable arr = Array.init 30 (fun l -> l)


printfn "%A" arr

arr[0] <- 5


printfn "%A" arr


let mutable arr = Array.init 30 (fun l -> l)

printfn "%A"arr


// Function to increment each value in an array by 1
for i = 0 to Array.length arr - 1 do
     arr.[i] <- arr.[i] + 1

printfn "%A" arr 




let mutable arr = Array.init 30 (fun l -> l)

let mutable sum = 0
for i=0 to Array.length arr - 1 do
    sum <- sum + arr.[i]

printfn"%A" sum




let mutable arr = Array.init 30 (fun l -> l)
let mutable maxVal = arr.[0]  // Start with the first element as the max
for i = 1 to Array.length arr - 1 do
    if arr.[i] > maxVal then maxVal <- arr.[i]




let mutable arr = Array.init 30 (fun l -> l)


// Function to reverse an array of integers
let length = Array.length arr
let reversed = Array.create length 0 // Create a new array to hold the reversed values
for i = 0 to length - 1 do
    reversed.[i] <- arr.[length - 1 - i] // Copy values in reverse order


printfn "The maximum value in the array is: %A" reversed

*)


