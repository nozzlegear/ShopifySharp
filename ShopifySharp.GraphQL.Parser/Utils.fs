namespace ShopifySharp.GraphQL.Parser

open System
open System.IO.Pipelines
open System.Text
open System.Threading.Tasks
open ShopifySharp.GraphQL.Parser.PipeWriter

module Utils =
    let NewLine = Environment.NewLine

    let mapStrToInterfaceName =
        sprintf "I%s"

    let toUnionCaseWrapperName (unionTypeName: string) unionCaseName =
        unionTypeName + unionCaseName

    let toTab (indentation: Indentation) =
        indentation.ToString()

    let toCasing casing (str: string): string =
        let first = str[0]
        let rest  = str[1..]
        match casing with
        | Pascal -> Char.ToUpper(first).ToString() + rest
        | Camel -> Char.ToLower(first).ToString() + rest

    let sanitizeString (str: string): string =
        str.ReplaceLineEndings("")
           .Replace("\"", "", StringComparison.OrdinalIgnoreCase)
           .Replace("'", "", StringComparison.OrdinalIgnoreCase)

    /// <summary>
    /// Sanitizes the value, replacing reserved C# keywords with <c>$"@{value}"</c>
    /// </summary>
    let sanitizeFieldOrOperationName (parentType: NamedType) (fieldName: string): string =
        if fieldName.Equals(parentType.ToString(), StringComparison.OrdinalIgnoreCase) then
            // The C# compiler will not allow the @ prefix for members that have the same name as their enclosing type
            fieldName + "_"
        elif Set.contains fieldName Reserved.csharpKeywords then
            "@" + fieldName
        else
            fieldName

    let writeDeprecationAttribute indentation (deprecationWarning: string option) writer : ValueTask =
        let indentation = toTab indentation
        pipeWriter writer {
            match deprecationWarning with
            | Some x when String.IsNullOrWhiteSpace x ->
                do! indentation
                do! "[Obsolete]"
                do! NewLine
            | Some x ->
                do! indentation
                do! $"[Obsolete(\"{sanitizeString x}\")]"
                do! NewLine
            | None ->
                ()
        }

    let readPipe (reader: PipeReader) cancellationToken: ValueTask<StringBuilder> =
        let sb = StringBuilder()
        let rec loop () = task {
            let! result = reader.ReadAsync(cancellationToken).ConfigureAwait(false)

            let mutable enumerator = result.Buffer.GetEnumerator()
            while enumerator.MoveNext() do
                sb.Append(Encoding.UTF8.GetString(enumerator.Current.Span))
                |> ignore

            reader.AdvanceTo(result.Buffer.End)

            if not (result.IsCompleted || result.IsCanceled) then
                do! loop()
        }

        ValueTask<StringBuilder>(task {
            do! loop()
            do! reader.CompleteAsync().ConfigureAwait(false)
            return sb
        })
