open DefaultNamespace.FileHandling
open DefaultNamespace.NucleoBase

let filePath = "input.txt"
nucleoBaseCounts filePath |> Array.iter (printf "%s")
printfn ""
