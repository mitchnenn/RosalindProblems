namespace Rosalind.Functions

open System

module StringHelpers =
    let toChars (input: string) = input.ToCharArray()

    let stripCR (input: string) = input.Replace(Environment.NewLine, "").Trim()

    let countCharacters (charToCount: char) (input: string) : int =
        input
        |> Seq.filter ((=) charToCount)
        |> Seq.length
      
    let formatFloat (value: float) = $"%.6f{value}"
                                               