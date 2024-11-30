namespace Rosalind.Functions

open System.Collections.Generic

module DynamicSupport =
    let memoize(f) =
        // Create a (mutable) cache for storing results of function
        // arguments that were already calculated.
        let cache = Dictionary<_,_>()
        (fun x ->
            // The returned function performs a lookup)
            let succ, v = cache.TryGetValue(x)
            if succ then v else
                // If not found calculate and cache the value
                let v = f(x)
                cache.Add(x, v)
                v) // return the value
    
    