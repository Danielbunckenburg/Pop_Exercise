module FileIO

open System.IO // module containing classes File, StreamReader, StreamWriter, FileStream etc.

// [<EntryPoint>]
// possible entry point since function has type string array -> int
let main (args: string array): int =
  let rec loop n (r: StreamReader) =
    if r.EndOfStream 
    then n
    else ignore (r.ReadLine())
         loop (n+1) r
  try 
    if Array.length args > 0 
    then do printfn "Number of lines: %d" 
                    (loop 0 (File.OpenText (args[0])))
         0  // exit code: success
    else do eprintfn "Expects a file name as argument" 
         1  // exit code: failure
  with ex -> do eprintfn "%s" ex.Message;
             1 // exit code: failure

// Recursive specification of fib -- extremely inefficient!
let rec fib n = 
    if n <= 2 
    then 1 
    else fib (n-1) + fib (n-2)
// Output Fibonacci numbers i to n on stdout
let rec loop n i (w: StreamWriter) =
        if i > n 
        then w.Close() // close stream 
        else w.WriteLine (string (fib i))
             loop n (i+1) w

// Store first Fibonacci numbers in out.txt
let main' (args: string array): int =
    try
        loop 40 1 (File.CreateText "out.txt")
        0
    with
        ex -> eprintf "%s" ex.Message
              1


(*

open System
open System.IO

let cp f1 f2 =
    if String.IsNullOrWhiteSpace(f1) then
        raise (ArgumentException("Source file path cannot be empty.", "f1"))
    elif String.IsNullOrWhiteSpace(f2) then
        raise (ArgumentException("Destination file path cannot be empty.", "f2"))
    elif not (File.Exists(f1)) then
        raise (FileNotFoundException($"The source file '{f1}' does not exist.", f1))
    else
        try
            File.Copy(f1, f2, true) // Overwrite the file if it exists
            printfn "File copied from '%s' to '%s'." f1 f2
        with
        | :? UnauthorizedAccessException as ex ->
            printfn "Access denied: %s" ex.Message
            raise ex
        | ex ->
            printfn "An error occurred: %s" ex.Message
            raise ex


let runTests () =
    // Setup temporary files
    let inputFile = "test_input.txt"
    let outputFile = "test_output.txt"
    let nonexistentFile = "nonexistent.txt"

    // Test 1: Empty strings
    try
        cp "" outputFile
        failwith "Test failed: Empty source path did not raise an exception."
    with
    | :? ArgumentException -> printfn "Test passed: Empty source path."

    try
        cp inputFile ""
        failwith "Test failed: Empty destination path did not raise an exception."
    with
    | :? ArgumentException -> printfn "Test passed: Empty destination path."

    // Test 2: Nonexistent source file
    try
        cp nonexistentFile outputFile
        failwith "Test failed: Nonexistent source file did not raise an exception."
    with
    | :? FileNotFoundException -> printfn "Test passed: Nonexistent source file."

    // Test 3: Successful copy
    File.WriteAllText(inputFile, "Hello, World!") // Create the input file
    cp inputFile outputFile
    let content = File.ReadAllText(outputFile)
    assert (content = "Hello, World!")
    printfn "Test passed: Successful file copy."

    // Test 4: Overwrite destination file
    File.WriteAllText(outputFile, "Old Data")
    cp inputFile outputFile
    let overwrittenContent = File.ReadAllText(outputFile)
    assert (overwrittenContent = "Hello, World!")
    printfn "Test passed: Overwrite destination file."

    // Cleanup
    File.Delete(inputFile)
    File.Delete(outputFile)

// Run the tests
runTests ()

*)

open System
open System.IO

let cpUp f1 f2 =
    if String.IsNullOrWhiteSpace(f1) then
        raise (ArgumentException("Source file path cannot be empty.", "f1"))
    elif String.IsNullOrWhiteSpace(f2) then
        raise (ArgumentException("Destination file path cannot be empty.", "f2"))
    elif not (File.Exists(f1)) then
        raise (FileNotFoundException($"The source file '{f1}' does not exist.", f1))
    else
        try
            let content = File.ReadAllText(f1) // Read the content of the source file
            let upperContent = content.ToUpper() // Convert content to uppercase
            File.WriteAllText(f2, upperContent) // Write the uppercase content to the destination file
            printfn "File copied from '%s' to '%s' with content converted to uppercase." f1 f2
        with
        | :? UnauthorizedAccessException as ex ->
            printfn "Access denied: %s" ex.Message
            raise ex
        | ex ->
            printfn "An error occurred: %s" ex.Message
            raise ex


let runCpUpTests () =
    // Setup temporary files
    let inputFile = "test_input.txt"
    let outputFile = "test_output_upper.txt"
    let nonexistentFile = "nonexistent.txt"

    // Test 1: Empty strings
    try
        cpUp "" outputFile
        failwith "Test failed: Empty source path did not raise an exception."
    with
    | :? ArgumentException -> printfn "Test passed: Empty source path."

    try
        cpUp inputFile ""
        failwith "Test failed: Empty destination path did not raise an exception."
    with
    | :? ArgumentException -> printfn "Test passed: Empty destination path."

    // Test 2: Nonexistent source file
    try
        cpUp nonexistentFile outputFile
        failwith "Test failed: Nonexistent source file did not raise an exception."
    with
    | :? FileNotFoundException -> printfn "Test passed: Nonexistent source file."

    // Test 3: Successful copy with uppercase
    File.WriteAllText(inputFile, "Hello, World!") // Create the input file
    cpUp inputFile outputFile
    let content = File.ReadAllText(outputFile)
    assert (content = "HELLO, WORLD!")
    printfn "Test passed: Successful file copy with uppercase conversion."

    // Test 4: Overwrite destination file
    File.WriteAllText(outputFile, "Old Data")
    cpUp inputFile outputFile
    let overwrittenContent = File.ReadAllText(outputFile)
    assert (overwrittenContent = "HELLO, WORLD!")
    printfn "Test passed: Overwrite destination file with uppercase conversion."

    // Cleanup
    File.Delete(inputFile)
    File.Delete(outputFile)

// Run the tests
runCpUpTests ()