//test


//instead of using loop, then using rec 
let rec filterPos (lst : int list) : int list =
  match lst with
  | [] -> []  (* Base case: an empty list returns an empty list *)
  | x :: xs -> 
      if x > 0 then x :: filterPos xs  (* If x is positive, include it in the result *)
      else filterPos xs  (* Otherwise, skip x and continue with the rest of the list *)


//printfn "%A" (filterPos [10;-2;10])

let rec addPos (lst : int list) : int =
  match lst with
  | [] -> 0  (* Base case: an empty list returns an empty list *)
  | x :: xs -> 
      if x > 0 then x + addPos xs 
      else addPos xs  

//printfn "%A" (addPos [-2; 3; -1; 4; 0])


let rec zipAdd (lst1: int list) (lst2: int list) : int list =
    match (lst1,lst2) with
    | ([],_) -> []
    | (_,[]) -> []
    | (x1 :: xs1, x2 :: xs2) -> (x1 + x2) :: zipAdd xs1 xs2 

let lst1 = [1; 2; 3] 
let lst2 = [4; 5; 6]

//printfn "%A" (zipAdd lst1 lst2)


let rec zipWith (f : 'a -> 'b -> 'c) (lst1 : 'a list) (lst2 : 'b list) : 'c list =
  match (lst1, lst2) with
  | ([], _) -> []  (* If the first list is empty, return an empty list *)
  | (_, []) -> []  (* If the second list is empty, return an empty list *)
  | (x1 :: xs1, x2 :: xs2) -> f x1 x2 :: zipWith f xs1 xs2
    (* Apply the function f to the heads of both lists and recursively process the tails *)

//printfn "%A" (zipWith ( + ) [1; 2; 3] [4; 5; 6])

let rec printAll (f : 'a -> string) (lst : 'a list) : unit =
    match lst with
    | [] -> ()  // Base case: Do nothing for an empty list
    | x :: xs ->
        printfn "%s" (f x)  // Apply the function to turn `x` into a string and print it
        printAll f xs  // Recursively process the rest of the list


let intToString (x: int) : string = x.ToString()

let () = printAll intToString [1; 2; 3; 4; 5]


// convert all numbers to string

type Number =
    | Int of int
    | Float of float

let show (num: Number) : string =
    match num with
    | Int value -> value.ToString()  // Convert int to string
    | Float value -> value.ToString("F2")  // Convert float to string with two decimal places


    