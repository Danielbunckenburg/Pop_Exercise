//thursdag_worksheet_week_5

(*
let rec binary_search (target:int) (a:int array):bool = 
    if a = Array.empty then false
    else
        let mid = a.length /2
        if a[mid] = target then
            true
        elif a[mid] < target then
            binary_search target a[(mid+1)..]
        else
            binary_search target a[..(mid-1)]

let a =[|1;3;4;7;10;11;13;17;18|]

printfn"Is 17 in the arry %A"(binary_search 17 a) 


let a =[|1;3;4;7;10;11;13;17;18|]
let binary_search_while (target:int) (a:int array) = 
    let mutable i = 0
    while target <> a[i] do 
        i <- i + 1
    i

printfn"Is 17 in the arry %A"(binary_search_while 17 a) 
 


let left =[|1;3;4|]
let right =[|2;4;5|]



let merge (left:int[]) (right:int[]):int[] = 
    let result: int array = Array.zeroCreate (Array.length left + Array.length right)
    let mutable i = 0
    let mutable j = 0
    let mutable k = 0

    while i < Array.length left && j < Array.length right do
        if left[i] <= right[j] then
            result[k] <- left[i]
            i <- i + 1
        else
            result[k] <- right[j]
            j <- j + 1
        k <- k + 1

    while i < Array.length left do 
        result[k] <- left[i]
        i <- i + 1
        k <- k + 1
    while j < Array.length right do 
        result[k] <- right[j]
        j <- j + 1
        k <- k + 1
    result

printfn "%A" (merge left right)




*)

let vector =[|1;3;4;5;13;4;5|]

let merge_sort (arraya:int[]) =
    let middel = (Array.length arraya)/2
    let left:int[]  = arraya|0..middel-1|
    let right:int[] = [middel..|
    
    let result: int array = Array.zeroCreate (Array.length left + Array.length right)
    let mutable i = 0
    let mutable j = 0
    let mutable k = 0

    while i < Array.length left && j < Array.length right do
        if left[i] <= right[j] then
            result[k] <- left[i]
            i <- i + 1
        else
            result[k] <- right[j]
            j <- j + 1
        k <- k + 1

    while i < Array.length left do 
        result[k] <- left[i]
        i <- i + 1
        k <- k + 1
    while j < Array.length right do 
        result[k] <- right[j]
        j <- j + 1
        k <- k + 1
    result

printfn "%A" (merge_sort vector)
