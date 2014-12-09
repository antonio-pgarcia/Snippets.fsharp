open System

// -- | Pop one element from a specific list position
let pop i l =
    1

// -- | Generate random number within interval a-b with seed s
let myrandom a b s =
    let r = System.Random(s)
    r.Next(a, b)

// -- | Shuffle a list
let shuffle l =
    l
   
// -- | The main entry point.
let main() = 
    let v = [1..10]
    Console.WriteLine("List Shuffle!")
    Console.WriteLine(shuffle v)
    
main()
