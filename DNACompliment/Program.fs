open DefaultNamespace.FileHandling
open DefaultNamespace.NucleoBase

let reverseSampleInput = readFileCharsInReverse "sample_input.txt"
printfn "Reverse sample input: %s" (System.String(reverseSampleInput))
let sampleResult = complimentDna reverseSampleInput
printfn "Compliment sample result: %s" (System.String(sampleResult))
printfn "Expected sample result: %s" (readTextFromFile "sample_output.txt")

let reverseProblemInput = readFileCharsInReverse "problem_input.txt"
let problemResult = complimentDna reverseProblemInput
printfn "Problem result:"
printfn "%s" (System.String(problemResult))
