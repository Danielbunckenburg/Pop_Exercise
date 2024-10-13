//Deliberate practice - week 4

//Part 1

let multiplyByFive = fun x -> x * 5

let firstelementlist =  (fun vector -> List.head vector) [10; 20; 30]

let onlystringelement = (fun (x,y) -> y) (10,"ten")

let avargefuntion = (fun (x,y)-> ((x+y)/2)) (10,20)

let twolists = fun (list1, list2) -> (List.head list1,List.head list2)

//printfn "%A" (twolists ([10;20;30], [40;50;60]))

//Part 2

//Define a let binding for a tuple composed of a string and an integer

let firsttuple = ("Daniel",30)



//Define a let binding for a tuple composed of a string and four integers

let secoundtuple = ("Daniel",30,40,50,60)


//printfn "%A" (secoundtuple)

//Define a let binding for a tuple composed of a string and a list

let thirdtuple = ("Daniel",[30;40;50;60])

//printfn "%A" (thirdtuple)
//Define a let binding for a list of tuples composed of a string and a list of integers
//Define a function that takes as input a list of tuples composed of a string and an integer and returns a list composed of the strings extracted from the input tuples
//Define a function that takes as input a list of tuples composed of a string and an integer and returns a list composed of the integer extracted from the input tuples
//Define a let binding for a list of 4 lists of integers
//Define a function that takes as input a list of list of integers and returns a list containing all the integers in the input



//part 3
//Define a let binding s for the string "Hello World!"
let s = "Hello World"
//Define a let binding for the first character of s
let shead = s[0]
//Define a let binding for a string containing the first 5 characters of s
let sfirst5 = s.Substring(0,5)
//Define a let binding for the length of the string s
let length = String.length s
//printfn "%A" length

//Define a let binding for the last character of s
let lastelement = s.[length-1]
printfn "%A" lastelement


//Define a function that takes as input a list of strings and returns the contatenation of these strings


