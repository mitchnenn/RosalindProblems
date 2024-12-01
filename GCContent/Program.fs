open Rosalind.Functions.FileHandling
open Rosalind.Functions.NucleoBase
open Rosalind.Functions.ParseFasta
open Rosalind.Functions.StringHelpers

let sampleContent = readTextFromFile "sample_input.fasta"
let sampleRecords =
    match parseFastaFile sampleContent with
        | Result.Ok(records) -> records 
        | Result.Error(errorMsg) -> printfn $"Fasta parse error: %s{errorMsg}"; []
let maxSampleRecord = fastaPercentageGC sampleRecords

printfn $"Max Sample Label: %s{fst maxSampleRecord}"
printfn $"Max Sample GC Content: %s{formatFloat (snd maxSampleRecord)} %%"

let problemContent = readTextFromFile "problem_input.fasta"
let problemRecords = 
    match parseFastaFile problemContent with
    | Result.Ok(records) -> records 
    | Result.Error(errorMsg) -> printfn $"Fasta parse error: %s{errorMsg}"; []
let maxProblemRecord = fastaPercentageGC problemRecords

printfn $"Max Problem Label: %s{fst maxProblemRecord}"
printfn $"Max Problem GC Content: %s{formatFloat (snd maxProblemRecord)} %%"
