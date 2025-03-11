module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
    let rec iter steps (num: int64) =
        if num = 1L then steps
        else if num % 2L = 0L then iter (steps + 1) (num / 2L)
        else iter (steps + 1) (num * 3L + 1L)
    iter 0 (int64 n)
