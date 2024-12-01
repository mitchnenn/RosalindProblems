open System
open Rosalind.Functions
open Rosalind.Functions.ParseFasta
open FParsec
open StringHelpers

// Usage
let fastaContent = """
>label1
ATCG
>label2
GGGGA
"""

test labelParser """>label1
"""

test sequenceParser """CCTGCGGAAGATCGGCACTAGAATAGCCAGAACCGTTTCTCTGAGGCTTCCGGCCTTCCC
TCCCACTAATAATTCTGAGG
>label2"""

test fastaRecordParser """>label1
CCTGCGGAAGATCGGCACTAGAATAGCCAGAACCGTTTCTCTGAGGCTTCCGGCCTTCCC
TCCCACTAATAATTCTGAGG"""

match parseFastaFile fastaContent with
| Result.Ok(records) -> records |> List.iter (fun record -> printfn $"Label: %s{record.Label}\nSequence: %s{record.Sequence}\n")
| Result.Error(errorMsg) -> printfn $"Error parsing FASTA file: %s{errorMsg}"
