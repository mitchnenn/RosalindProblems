open DefaultNamespace.FileHandling
open DefaultNamespace.NucleoBase

let sampleResult = nucleoBaseCounts "sample_input.txt"
let expecteSampleResult = readTextFromFile "sample_output.txt"
printfn "Sample input result: %s; Expected sample result %s" (sampleResult.Trim()) expecteSampleResult

let problemInputPath = "problem_input.txt"
printfn "Problem answer: %s" (nucleoBaseCounts problemInputPath)