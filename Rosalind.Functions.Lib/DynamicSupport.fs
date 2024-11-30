namespace Rosalind.Functions

open System.Collections.Generic

module DynamicSupport =
    let memoize(f) =
        // Create a (mutable) cache for storing results of function
        // arguments that were already calculated.
        let cache = Dictionary<_,_>()
        (fun x ->
            // The returned function performs a lookup)
            let success, v = cache.TryGetValue(x)
            if success then v else
                // If not found calculate and cache the value
                let v = f(x)
                cache.Add(x, v)
                v) // return the value
    
    