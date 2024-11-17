// SeachTree.fs


type BTree<'a> =
 Empty
 | Branch of BTree <'a> * 'a * BTree <'a>

let t1 = Branch (Empty, 1, Empty)
let t3 = Branch (Empty, 3, Empty)
let t2 = Branch (t1, 2, t3)
let t5 = Branch (Empty, 5, Empty)
let t7 = Branch (Empty, 7, Empty)
let t6 = Branch (t5, 6, t7)
let t4 = Branch (t2, 4, t6)



let rec contains t x =
    match t with
    Empty -> false
    | Branch (t1, v, t2) -> 
        if x < v then contains t1 x
        else if x = v then true
        else (* x > v *) contains t2 x
