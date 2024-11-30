namespace Rosalind.Functions

module FileHandling = 
    open StringHelpers
    
    let readTextFromFile (filePath: string) : string =
        let contents = System.IO.File.ReadAllText(filePath)
        contents.Trim()
    
    let readFileAndStripCR (filePath: string) =
        let fileContent = readTextFromFile filePath
        let stripped = stripCR fileContent
        stripped.Trim()
        
    let readFromFileAndConvertToChars path = readFileAndStripCR path
                                             |> toChars


    let readFileCharsInReverse path = readFileAndStripCR path
                                      |> toChars
                                      |> Array.rev
                                      