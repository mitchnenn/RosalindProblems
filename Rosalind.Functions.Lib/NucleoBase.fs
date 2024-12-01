namespace Rosalind.Functions

module NucleoBase =
    open StringHelpers
    open FileHandling
    open ParseFasta
    
    let nucleoBaseNames = [|'A'; 'C'; 'G'; 'T' |]

    let nucleoBaseCounts path = nucleoBaseNames
                                |> Array.map (fun baseName -> countCharacters baseName (readFileAndStripCR path))
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
        
    let complimentDna (inputArray: char array) : char array =
        let mapping =
            dict [
                'A', 'T'
                'C', 'G'
                'G', 'C'
                'T', 'A'
            ]
        inputArray |> Array.map (fun c -> mapping.[c])
        
    let calculateCGPercentage (input: string) =
        let countC = countCharacters 'C' input
        let countG = countCharacters 'G' input
        let totalCGCount = countC + countG
        let totalLength = input.Length
        let percentage = (float totalCGCount / float totalLength) * 100.0
        (totalCGCount, percentage)
        
    let fastaPercentageGC (records: FastaRecord list) =
        records
        |> List.map(fun record -> record.Label, (snd (calculateCGPercentage record.Sequence)))
        |> List.maxBy snd
