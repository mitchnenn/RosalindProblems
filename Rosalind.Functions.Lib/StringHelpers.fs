namespace Rosalind.Functions

module StringHelpers =
    let toChars (input: string) = input.ToCharArray()

    let stripCR (input: string) = input.Replace("\r\n", "").Trim()

    let countCharsByValue inputCharArray charValue = inputCharArray
                                                     |> Array.filter (fun ch -> ch = charValue)
                                                     |> Array.length