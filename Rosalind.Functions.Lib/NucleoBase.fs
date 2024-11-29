namespace DefaultNamespace

module NucleoBase =
    open StringHelpers
    open FileHandling
    
    let nucleoBaseNames = [|'A'; 'C'; 'G'; 'T' |]

    let nucleoBaseCounts path = nucleoBaseNames
                                |> Array.map (fun baseName -> countCharsByValue (readFromFileAndConvertToChars path) baseName)
                                |> Array.map string
                                |> String.concat " "
