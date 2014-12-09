open System

let drop i l =
    match l  with
    | [] -> []
    | h :: t -> drop' i l 0 []
    
let rec drop' i l ii ll = 
    match l with
    | [] -> []  
    | h :: t -> if List.length ll = List.length l - 1 then ll
                else
                   let iii = if ii = i-1 then ii+2 else ii+1 
                   let ll = List.append ll [l.Item iii-1]
                   drop' i l iii ll 
     
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
    Console.WriteLine(drop 1 v)
    Console.WriteLine(List.length v)
    
main()
