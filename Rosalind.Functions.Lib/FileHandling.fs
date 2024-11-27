namespace DefaultNamespace 

module FileHandling = 
    open StringHelpers
    
    let readFileAndStripCR (filePath: string) =
        let fileContent = System.IO.File.ReadAllText(filePath)
        stripCR fileContent
        
    let readFromFileAndConvertToChars path = readFileAndStripCR path
                                             |> toChars
