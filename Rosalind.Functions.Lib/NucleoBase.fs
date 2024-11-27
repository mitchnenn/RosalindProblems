namespace DefaultNamespace

module NucleoBase =
    open StringHelpers
    open FileHandling
    
    let nucleoBaseNames = [|'A'; 'C'; 'G'; 'T' |]

    let nucleoBaseCounts path = nucleoBaseNames
                                |> Array.map (fun baseName -> sprintf "%d " (countCharsByValue (readFromFileAndConvertToChars path) baseName))
