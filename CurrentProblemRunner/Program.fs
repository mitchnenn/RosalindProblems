let baseNames = [|'A'; 'C'; 'G'; 'T' |]

let toChars (input:string) = input.ToCharArray()
let stripCR (input:string) = input.Replace("\r\n", "").Trim()
let readFileAndStripCR (filePath: string) =
    let fileContent = System.IO.File.ReadAllText(filePath)
    stripCR fileContent

let sampleData path = readFileAndStripCR path
                      |> toChars

// Function to count bases in the sample data
let countNucleoBases data baseName = data
                                     |> Array.filter (fun ch -> ch = baseName)
                                     |> Array.length

// Iterating over base names and using sprintf for each of them
let baseCounts path = baseNames
                      |> Array.map (fun baseName -> sprintf "%d " (countNucleoBases (sampleData path) baseName))

// Printing the results
let filePath = "input.txt"
baseCounts filePath |> Array.iter (printf "%s")
printfn ""
