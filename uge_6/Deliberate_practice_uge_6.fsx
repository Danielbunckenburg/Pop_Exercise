//Deliberate practice - week 6

//Question 1
(*

let f v =
    if v > 0 then Some v
    else None

*)

let exists (x: int option) =
    match x with
    | Some(x) -> true
    | None -> false

printfn "%A" (exists)



//question 2