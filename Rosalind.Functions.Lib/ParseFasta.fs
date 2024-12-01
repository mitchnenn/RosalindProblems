namespace Rosalind.Functions

// '>' is the start of a record.
// Text from '>' to the first carriage return is the label.
// All test after the carriage return to the next '>' is DNA string.

module ParseFasta =
    open System
    open FParsec
    
    // Use for testing parsers.
    let test p str =
        match run p str with
        | Success(result, _, _)   -> printfn $"Success: %A{result}"
        | Failure(errorMsg, _, _) -> printfn $"Failure: %s{errorMsg}"
         
    // Define a fasta record
    type FastaRecord = {
        Label: string
        Sequence: string
    }

    // Parse for the Label
    let labelParser: Parser<string, unit> =
        pchar '>' >>. restOfLine true
        
    // Parse the DNA sequence
    let sequenceParser: Parser<string, unit> =
        manyChars (noneOf ">")
        |>> (_.Replace(Environment.NewLine, "").Trim())
    
    // Create a fasta record parser (single record)
    let fastaRecordParser: Parser<FastaRecord, unit> =
        labelParser .>>. sequenceParser
        |>> fun (label, sequence) -> {Label = label; Sequence = sequence}

    // Parser for multiple records.
    let fastaFileParser: Parser<FastaRecord list, unit> =
        many(fastaRecordParser .>> spaces)

    // Parse fasta file contents with result check
    let parseFastaFile (input: string): Result<FastaRecord list, string> =
        let trimmedInput = input.Trim()
        match run fastaFileParser trimmedInput with
        | Success(result, _, _) -> Result.Ok(result)
        | Failure(errorMsg, _, _) -> Result.Error(errorMsg)