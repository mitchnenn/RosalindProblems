namespace DefaultNamespace 

module FileHandling = 
    open StringHelpers
    
    let readTextFromFile (filePath: string) : string =
        let contents = System.IO.File.ReadAllText(filePath)
        contents.Trim()
    
    let readFileAndStripCR (filePath: string) =
        let fileContent = readTextFromFile filePath
        stripCR fileContent
        
    let readFromFileAndConvertToChars path = readFileAndStripCR path
                                             |> toChars

