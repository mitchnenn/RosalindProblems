namespace Rosalind.Functions

open System

module StringHelpers =
    let toChars (input: string) = input.ToCharArray()

    let stripCR (input: string) = input.Replace(Environment.NewLine, "").Trim()

    let countCharsByValue inputCharArray charValue = inputCharArray
                                                     |> Array.filter (fun ch -> ch = charValue)
                                                     |> Array.length