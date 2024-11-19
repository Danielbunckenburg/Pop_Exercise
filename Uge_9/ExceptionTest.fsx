// ExceptionTest.fsx
#load "Exception.fs"

// Reference the function
open Exception

// Helper function for running tests
let testFloatDiv x y expected =
    let result = floatDiv x y
    if result = expected then
        printfn "Test Passed: floatDiv %f %f = %A" x y result
    else
        printfn "Test Failed: floatDiv %f %f, Expected: %A, Got: %A" x y expected result

// Test cases
let testCases = [
    (10.0, 2.0, Some 5.0);       // Normal case
    (-10.0, 2.0, Some -5.0);     // Negative dividend
    (10.0, -2.0, Some -5.0);     // Negative divisor
    (-10.0, -2.0, Some 5.0);     // Both negative
    (0.0, 2.0, Some 0.0);        // Zero dividend
    (10.0, 0.0, None);           // Zero divisor
    (0.0, 0.0, None);            // Both zero
    (1.0e10, 1.0e-10, Some 1.0e20); // Very large result
    (1.0e-10, 1.0e10, Some 1.0e-20); // Very small result
]

// Execute the tests
printfn "Running Tests for floatDiv"
testCases |> List.iter (fun (x, y, expected) -> testFloatDiv x y expected)