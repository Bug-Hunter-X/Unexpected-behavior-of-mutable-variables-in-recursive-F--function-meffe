# F# Mutable Variable Bug

This repository demonstrates a subtle bug involving mutable variables in a recursive function in F#.

The `gcd` function calculates the greatest common divisor using Euclid's algorithm.  However, the mutable variables `x` and `y` intended to track the input values are not updated as expected within the recursive calls, leading to incorrect results or unexpected behavior.

## Bug Description

The issue stems from how mutable variables behave within recursive function calls.  While the function correctly calculates the GCD, the values assigned to `x` and `y` using `<-` are not reflected consistently across recursive calls, producing unexpected values after the function completes.

## Solution

The solution avoids mutable variables.  By using immutable variables and passing the required values directly to the recursive calls, we ensure correct behavior and avoid unintended side effects.