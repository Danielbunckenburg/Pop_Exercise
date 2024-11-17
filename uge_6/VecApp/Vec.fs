namespace VecApp

module Vec =
    type Vector = { X: float; Y: float }

    let create x y = { X = x; Y = y }

    let add v1 v2 = 
        { X = v1.X + v2.X; Y = v1.Y + v2.Y }

    let subtract v1 v2 = 
        { X = v1.X - v2.X; Y = v1.Y - v2.Y }

    let dot v1 v2 = 
        v1.X * v2.X + v1.Y * v2.Y

    let length v = 
        sqrt (v.X * v.X + v.Y * v.Y)

    let toString v = 
        sprintf "(%f, %f)" v.X v.Y
