//SnocList.fs

module SnocList

type SnocList<'T> =
    | Snoc of SnocList<'T> * 'T
    | Empty

// Function to compute the length of a SnocList
let rec length list =
    match list with
    | Empty -> 0
    | Snoc (init, _) -> 1 + length init

// Function to compute the sum of a SnocList of integers
let rec sum list =
    match list with
    | Empty -> 0
    | Snoc (init, last) -> last + sum init

// Function to append two SnocLists
let rec append list1 list2 =
    match list1 with
    | Empty -> list2
    | Snoc (init, last) -> Snoc(append init list2, last)