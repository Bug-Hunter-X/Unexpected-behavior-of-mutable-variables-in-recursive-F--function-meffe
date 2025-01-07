let rec gcd a b =
    if b = 0 then a
    else gcd b (a % b)

let calculateGCD a b =
    let result = gcd a b
    printf "%d %d %d" a b result

let result = calculateGCD 10 20
printf "%d" result