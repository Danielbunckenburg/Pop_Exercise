#load "Vec.fs"
open VecApp.Vec

[<EntryPoint>]
let main argv =
    let v1 = create 3.0 4.0
    let v2 = create 1.0 2.0
    
    let added = add v1 v2
    let subtracted = subtract v1 v2
    let dotProduct = dot v1 v2
    let lengthV1 = length v1

    printfn "Vector 1: %s" (toString v1)
    printfn "Vector 2: %s" (toString v2)
    printfn "Added: %s" (toString added)
    printfn "Subtracted: %s" (toString subtracted)
    printfn "Dot Product: %f" dotProduct
    printfn "Length of Vector 1: %f" lengthV1

    0 // Return an integer exit code
