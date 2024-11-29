open DefaultNamespace.FileHandling
open DefaultNamespace.NucleoBase

let sampleInput = readTextFromFile "sample_input.txt"
printfn "Sample input: %s" sampleInput
let sampleResult = transcribeDnaSeqToRnaSeq sampleInput
printfn "Sample result: %s" sampleResult
let expectedSampleResult = readTextFromFile "sample_output.txt"
printfn "Expected sample output: %s" expectedSampleResult

let problemInput = readTextFromFile "problem_input.txt"
let problemResult = transcribeDnaSeqToRnaSeq problemInput
printfn "Problem result:"
printfn "%s" problemResult