namespace DefaultNamespace

module NucleoBase =
    open StringHelpers
    open FileHandling
    
    let nucleoBaseNames = [|'A'; 'C'; 'G'; 'T' |]

    let nucleoBaseCounts path = nucleoBaseNames
                                |> Array.map (fun baseName -> countCharsByValue (readFromFileAndConvertToChars path) baseName)
                                |> Array.map string
                                |> String.concat " "

    let transcribeDnaToRna (inputArray: char array) : char array =
        let mapping =
            dict [
                'A', 'A'
                'T', 'U'
                'C', 'C'
                'G', 'G'
            ]
        inputArray |> Array.map (fun c -> mapping.[c])
        
    let rec transcribeDnaSeqToRnaSeq(inputString: string) : string =
        let result = inputString.ToCharArray() |> transcribeDnaToRna
        System.String(result)