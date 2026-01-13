namespace ShopifySharp.GraphQL.Parser

open System
open System.IO.Pipelines
open System.Text
open System.Threading.Tasks
open ShopifySharp.GraphQL.Parser.PipeWriter

module Utils =
    let NewLine = Environment.NewLine

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

    /// Fully qualify class names which might collide with System types
    let qualifiedPascalTypeName  className =
        match toCasing Pascal className with
        | "Attribute" -> "ShopifySharp.GraphQL.Attribute"
        | pascalGenericType -> pascalGenericType

    let toBuilderName = function
        | QueryBuilder str -> toCasing Pascal $"{str}QueryBuilder"
        | ArgumentBuilder str -> toCasing Pascal $"{str}ArgumentsBuilder"
        | FieldsBuilder str -> toCasing Pascal $"{str}FieldsBuilder"
        | UnionsBuilder str -> toCasing Pascal $"{str}UnionsBuilder"
        | UnionCasesBuilder str -> toCasing Pascal $"{str}UnionCasesBuilder"

    let toGenericType type' assumeNullability =
        match type' with
        | VisitedTypes.Interface interface' ->
            interface'.DotnetName
        | VisitedTypes.Operation operation ->
            match operation.ReturnType with
            | ReturnType.VisitedType (VisitedTypes.Interface interface') ->
                interface'.DotnetName
            | ReturnType.VisitedType visitedTypes ->
                visitedTypes.Name
            | ReturnType.FieldType fieldType ->
                // Use the wrapper function to ensure primitives are wrapped in GraphQLValue<T> or GraphQLCollection<T>
                AstNodeMapper.mapFieldTypeToStringWithPrimitiveWrapper assumeNullability fieldType
        | x -> x.Name

    let sanitizeString (str: string): string =
        str.ReplaceLineEndings("")
           .Replace("\"", "", StringComparison.OrdinalIgnoreCase)
           .Replace("'", "", StringComparison.OrdinalIgnoreCase)

    /// <summary>
    /// Sanitizes the value, replacing reserved C# keywords with <c>$"@{value}"</c>
    /// </summary>
    let sanitizeFieldOrOperationName (parentType: NamedType) (fieldName: string): string =
        // Protected members from base builder classes that would cause collisions
        let builderBaseMembers = Set.ofList ["Query"; "Build"; "Alias"; "Arguments"; "Name"]

        if fieldName.Equals(parentType.ToString(), StringComparison.OrdinalIgnoreCase) then
            // The C# compiler will not allow the @ prefix for members that have the same name as their enclosing type
            fieldName + "_"
        elif Set.contains (toCasing Pascal fieldName) builderBaseMembers then
            // Collision with GraphQueryBuilder or builder base class properties/methods
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
