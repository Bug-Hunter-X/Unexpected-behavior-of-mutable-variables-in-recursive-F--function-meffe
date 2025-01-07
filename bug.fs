let mutable x = 0
let mutable y = 1

let rec gcd a b =
    if b = 0 then a
    else gcd b (a % b)

let calculateGCD a b =
    x <- a
    y <- b
    gcd a b

let result = calculateGCD 10 20
printf "%d %d %d" x y result