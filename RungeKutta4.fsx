open System

// -- | ODE, y = e ^ x
let mydydx1 x y = 
    exp(x)
    
// -- | ODE, y = e ^ x
let mydydx2 x y = 
    x * exp (3.0 * x) - 2.0 * y
    
//-- | ODE, y = r * y
let mydydx3 x y = 
    let r = 0.5
    r * y    

// -- | Fourth order runge-kutta algorithm calculations
let rungekutta4' x y h f = 
    let k1 = h * f x y
    let k2 = h * f (x + 0.5 * h) (y + k1 * 0.5)
    let k3 = h * f (x + 0.5 * h) (y + k2 * 0.5)
    let k4 = h * f (x + h) (y + k3)
    y + 1.0/6.0 * (k1 + 2.0 * k2 + 2.0 * k3 + k4)

// -- | Fourth order runge-kutta solver
let rec rungekutta4 x y h n f xx yy = 
    let y' = rungekutta4' x y h f
    if (x >= n) then (xx,yy)
    else rungekutta4 (x+h) y' h n f (List.append xx [x+h]) (List.append yy [y'])


// -- | The main entry point.
let main() =
    Console.WriteLine("Welcome to fourth order Runge-Kutta ODE solver!")
    let v = rungekutta4 0.0 1.0 0.01 1.0 mydydx1 [] []
    printfn "%A" ( (snd v).Item ((List.length (snd v)) - 1))
    let v = rungekutta4 0.0 0.0 0.01 1.0 mydydx2 [] []
    printfn "%A" ( (snd v).Item ((List.length (snd v)) - 1))
    let v = rungekutta4 0.0 2.0 0.01 3.0 mydydx3 [] []
    printfn "%A" ( (snd v).Item ((List.length (snd v)) - 1))

main()
