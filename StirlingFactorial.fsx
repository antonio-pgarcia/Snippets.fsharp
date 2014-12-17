open System

// -- | Stirling approximation to factorial of n!
let factorial n = 
    match n with
    | n when n = 0.0 -> 1.0
    | n when n > 0.0 -> sqrt (2.0 * Math.PI * n) * (n/exp(1.0)) ** n
    | _ -> 0.0 

// -- | The main entry point.
let main() =
    Console.WriteLine("Welcome to Stirling Factorial Calculator!")
    printfn "%A" (factorial 10.0)
    
main()    
