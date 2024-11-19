module StandardIO

open System // System is module and can be opened
            // System.Console is a class; it cannot be opened.

let fahrenheit (c: float) : unit =
  if c < -273.15 then failwith "input too small"
  else printfn "Fahrenheit: %f" (9.0 / 5.0 * c + 32.0)

// Interactively convert Celsius to Fahrenheit on terminal
let convert () = 
    do Console.Write "Temperature in degrees Celcius: "
    let s = Console.ReadLine()
    do try fahrenheit (float s) with 
         Failure s -> Console.Error.WriteLine s
       | _ -> Console.Error.WriteLine "Expecting number"

// [<EntryPoint>]
let main (args: string array) : int =
    for a in args do printfn "%s" a
    0                                // status code "ok"

// Summing numbers with repeated input prompting of summands
let sumIO () = 
    let rec loop (a: float) : float =
        match Console.ReadLine() with "" -> a
                                    | s -> loop (a + float s)
    do Console.WriteLine "Enter numbers (end with empty line):"
    try printfn "Sum: %f" (loop 0.0) 
    with _ -> Console.Error.WriteLine "Expecting numbers"


let convertBack () =
    printf "Enter temperature in Fahrenheit: "
    let input = System.Console.ReadLine()
    match System.Double.TryParse(input) with
    | true, fahrenheit ->
        let celsius = (fahrenheit - 32.0) * 5.0 / 9.0
        printfn "The temperature in Celsius is: %.2f" celsius
    | _ ->
        printfn "Invalid input. Please enter a valid number."

// Call the function to run it
convertBack ()


let sumIOLog () =
    let rec loop currentSum =
        printf "Enter a number (or press Enter to quit): "
        let input = System.Console.ReadLine()
        match input with
        | "" -> 
            printfn "Final sum: %d" currentSum
        | _ ->
            match System.Int32.TryParse(input) with
            | true, number ->
                let newSum = currentSum + number
                printfn "Current sum: %d" newSum
                loop newSum
            | _ ->
                printfn "Invalid input. Please enter a valid number."
                loop currentSum
    loop 0

// Call the function to run it
sumIOLog ()