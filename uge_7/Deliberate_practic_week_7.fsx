
//3. Higher-order functions for code factoring

type Number =
    | I of int
    | R of int * int // Rational: (numerator, denominator)
    | F of float

//first
(*
//Define the Number type to include integers, rationals, and floats
type Number =
    | I of int
    | R of int * int // Rational: (numerator, denominator)
    | F of float

// Add two numbers while ensuring the least precise type in the result
let add (a: Number) (b: Number): Number =
    match a, b with
    // Adding two integers results in an integer
    | I x, I y -> I (x + y)
    | F x, F y -> F (x + y)
    | I x, F y 
    | F y, I x -> F (float x + y)
    
    // Adding an integer and a rational number results in a rational number
    | I x, R (n, d) 
    | R (n, d), I x -> R (x * d + n, d)

    // Adding two rational numbers results in a rational number
    | R (n1, d1), R (n2, d2) -> R (n1 * d2 + n2 * d1, d1 * d2)

    // Adding an integer and a float results in a float
    // Adding a rational number and a float results in a float
    | R (n, d), F y
    | F y, R (n, d) -> F (float n / float d + y)

    // Adding two floats results in a float
 

// Helper function to print the Number type
let printNumber (n: Number) =
    match n with
    | I x -> printfn "Integer: %d" x
    | R (n, d) -> printfn "Rational: %d/%d" n d
    | F x -> printfn "Float: %f" x

// Test cases
let result1 = add (I 3) (I 4)        // Integer + Integer
let result2 = add (I 3) (R (1, 2))   // Integer + Rational
let result3 = add (R (1, 2)) (F 3.5) // Rational + Float
let result4 = add (F 1.5) (I 3)      // Float + Integer
let result5 = add (R (1, 2)) (R (2, 3)) // Rational + Rational

// Print results
printNumber result1
printNumber result2
printNumber result3
printNumber result4
printNumber result5





// Subtract two numbers while ensuring the least precise type in the result
let subtract (a: Number) (b: Number): Number =
    match a, b with
    // Subtracting two integers results in an integer
    | I x, I y -> I (x - y)

    // Subtracting an integer and a rational number results in a rational number
    | I x, R (n, d) -> R (x * d - n, d)
    | R (n, d), I x -> R (n - x * d, d)

    // Subtracting two rational numbers results in a rational number
    | R (n1, d1), R (n2, d2) -> R (n1 * d2 - n2 * d1, d1 * d2)

    // Subtracting an integer and a float results in a float
    | I x, F y -> F (float x - y)
    | F y, I x -> F (y - float x)

    // Subtracting a rational number and a float results in a float
    | R (n, d), F y -> F (float n / float d - y)
    | F y, R (n, d) -> F (y - float n / float d)

    // Subtracting two floats results in a float
    | F x, F y -> F (x - y)

// Test cases for subtraction
let result6 = subtract (I 7) (I 4)        // Integer - Integer
let result7 = subtract (I 3) (R (1, 2))   // Integer - Rational
let result8 = subtract (R (1, 2)) (F 3.5) // Rational - Float
let result9 = subtract (F 5.5) (I 3)      // Float - Integer
let result10 = subtract (R (2, 3)) (R (1, 2)) // Rational - Rational

let printNumber (n: Number) =
    match n with
    | I x -> printfn "Integer: %d" x
    | R (n, d) -> printfn "Rational: %d/%d" n d
    | F x -> printfn "Float: %f" x


// Print results
printNumber result6
printNumber result7
printNumber result8
printNumber result9
printNumber result10


// Multiply two numbers while ensuring the least precise type in the result
let multiply (a: Number) (b: Number): Number =
    match a, b with
    // Multiplying two integers results in an integer
    | I x, I y -> I (x * y)

    // Multiplying an integer and a rational number results in a rational number
    | I x, R (n, d) -> R (x * n, d)
    | R (n, d), I x -> R (n * x, d)

    // Multiplying two rational numbers results in a rational number
    | R (n1, d1), R (n2, d2) -> R (n1 * n2, d1 * d2)

    // Multiplying an integer and a float results in a float
    | I x, F y -> F (float x * y)
    | F y, I x -> F (y * float x)

    // Multiplying a rational number and a float results in a float
    | R (n, d), F y -> F (float n / float d * y)
    | F y, R (n, d) -> F (y * float n / float d)

    // Multiplying two floats results in a float
    | F x, F y -> F (x * y)

// Test cases for multiplication
let result11 = multiply (I 3) (I 4)         // Integer * Integer
let result12 = multiply (I 3) (R (1, 2))    // Integer * Rational
let result13 = multiply (R (1, 2)) (F 3.5)  // Rational * Float
let result14 = multiply (F 1.5) (I 3)       // Float * Integer
let result15 = multiply (R (1, 2)) (R (2, 3)) // Rational * Rational

// Print results
printNumber result11
printNumber result12
printNumber result13
printNumber result14
printNumber result15

*)

// Divide two numbers while ensuring the least precise type in the result
let divide (a: Number) (b: Number): Number =
    match a, b with
    // Dividing two integers
    | I x, I y when y <> 0 -> I (x / y)
    | I x, I 0 -> failwith "Division by zero"

    // Dividing an integer by a rational number
    | I x, R (n, d) when n <> 0 -> R (x * d, n)
    | I x, R (0, _) -> failwith "Division by zero"

    // Dividing a rational number by an integer
    | R (n, d), I x when x <> 0 -> R (n, d * x)
    | R (_, _), I 0 -> failwith "Division by zero"

    // Dividing two rational numbers
    | R (n1, d1), R (n2, d2) when n2 <> 0 -> R (n1 * d2, d1 * n2)
    | R (_, _), R (0, _) -> failwith "Division by zero"

    // Dividing an integer by a float
    | I x, F y when y <> 0.0 -> F (float x / y)
    | I _, F 0.0 -> failwith "Division by zero"

    // Dividing a rational number by a float
    | R (n, d), F y when y <> 0.0 -> F (float n / float d / y)
    | R (_, _), F 0.0 -> failwith "Division by zero"

    // Dividing two floats
    | F x, F y when y <> 0.0 -> F (x / y)
    | F _, F 0.0 -> failwith "Division by zero"

// Test cases for division
let result16 = divide (I 8) (I 4)           // Integer / Integer
let result17 = divide (I 3) (R (1, 2))      // Integer / Rational
let result18 = divide (R (1, 2)) (F 2.0)    // Rational / Float
let result19 = divide (F 4.5) (I 1)         // Float / Integer
let result20 = divide (R (2, 3)) (R (1, 2)) // Rational / Rational

// Print results
printNumber result16
printNumber result17
printNumber result18
printNumber result19
printNumber result20



let y = 5
let test = id (fun x -> x + y) 5
let add x y = x + y

let test2 = add 5

let test3 = test2 10


let id = fun x -> x
let y = 5
id (fun x -> x + y)
id << id;;
