open Rosalind.Functions.DynamicSupport

// 1. The population begins in the first month with a pair of newborn rabbits.
// 2. Rabbits reach reproductive age after one month.
// 3. In any given month, every rabbit of reproductive age mates with another rabbit of reproductive age.
// 4. Exactly one month after two rabbits mate, they produce one male and one female rabbit (k rabbit pairs).
// 5. Rabbits never die or stop reproducing.

// Any given month (n) will contain the rabbits that were alive the previous month, plus any new offspring
// The number of offspring in any month is equal to the number of rabbits that were alive two months prior.

let totalPopulationPairs month litterPairCount =
  let rec inner n k =
      match n with
      | _ when n <= 0 -> bigint 0
      | _ when n <= 2 -> bigint 1
      | n ->
        let offspring =  (memoize inner (n - 2) k)
        let adults = (memoize inner (n - 1) k)
        (offspring * k) + adults
  inner month litterPairCount

let month = 32
let litterPairCount = bigint 3
printfn $"%A{(totalPopulationPairs month litterPairCount)}"
