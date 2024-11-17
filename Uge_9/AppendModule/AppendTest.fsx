#load "Append.fs"
open append

/// Helper function to check equality of two ConsLists
let rec equal list1 list2 =
    match list1, list2 with
    | Nil, Nil -> true
    | Cons (h1, t1), Cons (h2, t2) -> h1 = h2 && equal t1 t2
    | _ -> false

/// Helper function to execute a test case
let test name input expected =
    let (xs, xs') = input
    let result = append xs xs'
    if equal result expected then
        printfn "Test '%s' passed." name
    else
        printfn "Test '%s' failed. Expected: %A, Got: %A" name expected result

/// Test suite for the append function
let runTests () =
    // Case 1: Append Nil and Nil
    test "Case 1" (Nil, Nil) Nil

    // Case 2: Append Nil and non-empty list
    test "Case 2" (Nil, Cons (1, Cons (2, Nil))) (Cons (1, Cons (2, Nil)))

    // Case 3: Append non-empty list and Nil
    test "Case 3" (Cons (1, Cons (2, Nil)), Nil) (Cons (1, Cons (2, Nil)))

    // Case 4: Append two non-empty lists
    test "Case 4" 
        (Cons (1, Cons (2, Nil)), Cons (3, Cons (4, Nil))) 
        (Cons (1, Cons (2, Cons (3, Cons (4, Nil)))))

    // Case 5: Append two long lists
    test "Case 5" 
        (Cons (1, Cons (2, Cons (3, Nil))), Cons (4, Cons (5, Cons (6, Nil)))) 
        (Cons (1, Cons (2, Cons (3, Cons (4, Cons (5, Cons (6, Nil)))))))

    // Case 6: Append single-element lists
    test "Case 6" (Cons (1, Nil), Cons (2, Nil)) (Cons (1, Cons (2, Nil)))

    // Case 7: Append nested structure
    test "Case 7" 
        (Cons (1, Cons (2, Cons (3, Nil))), Cons (4, Nil)) 
        (Cons (1, Cons (2, Cons (3, Cons (4, Nil)))))

    // Case 8: Append empty list with a large list
    test "Case 8" 
        (Nil, Cons (1, Cons (2, Cons (3, Cons (4, Nil))))) 
        (Cons (1, Cons (2, Cons (3, Cons (4, Nil)))))

// Run the test suite
runTests ()
