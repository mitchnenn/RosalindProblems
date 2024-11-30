open Rosalind.Functions.DynamicSupport

let rec fibs = memoize (fun n ->
  if n < 1 then 1 else
  (fibs (n - 1)) + (fibs (n - 2)))

printfn $"%d{fibs(12)}"
