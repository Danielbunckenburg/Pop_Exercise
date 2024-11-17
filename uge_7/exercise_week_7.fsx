//week 7


//Numbers.fs
(*
type Number = I of int | F of float


let multiply (v: Number) (w: Number) : Number =
match v, w with
| I x, I y -> I (x * y)                // If both are integers, return an integer-tagged result
| I x, F y -> F (float x * y)          // If one is an integer and the other is a float, return a float-tagged result
| F x, I y -> F (x * float y)          // Same as above
| F x, F y -> F (x * y)                // If both are floats, return a float-tagged result


// Example usage:
let result1 = multiply (I 3) (I 4)  // Result: I 12
let result2 = multiply (I 3) (F 4.5)  // Result: F 13.5
let result3 = multiply (F 2.5) (I 4)  // Result: F 10.0
let result4 = multiply (F 2.5) (F 4.0)  // Result: F 10.0

printfn"%A %A" (result1) (result2)
*)


let k: int = 14
let addk (l: int): int = k + l
let twice (m: int): int = 2 * m
let (<<) g f = fun x -> g (f x) // built-in
let h = twice << addk