let baseNames = [|'A'; 'C'; 'G'; 'T' |]

let toChars (aString:string) = aString.ToCharArray()
let stripCR (aString:string) = aString.Replace("\r\n", "").Trim()

let sampleData = System.IO.File.ReadAllText("input.txt")
                 |> stripCR
                 |> toChars

// Function to count bases in the sample data
let countBases data baseCh = data
                             |> Array.filter (fun ch -> ch = baseCh)
                             |> Array.length

// Iterating over base names and using sprintf for each of them
let baseCounts = baseNames
                 |> Array.map (fun baseCh -> sprintf "%d " (countBases sampleData baseCh))

// Printing the results
baseCounts |> Array.iter (printf "%s")
printfn ""
