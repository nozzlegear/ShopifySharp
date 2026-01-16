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

    /// Gets the namespace for query builders
    let getQueryBuilderNamespace (isOperation: bool): string =
        // Operations go in QueryBuilders.Operations namespace, everything else in QueryBuilders.Types
        // ArgumentsBuilder and UnionCasesBuilder are written with their parent QueryBuilder
        // so they'll be in the same namespace
        if isOperation then
            "ShopifySharp.GraphQL.Generated.QueryBuilders.Operations"
        else
            "ShopifySharp.GraphQL.Generated.QueryBuilders.Types"

    /// Fully qualify class names which might collide with System types
    let qualifiedPascalTypeName  className =
        match toCasing Pascal className with
        | "Attribute" -> "ShopifySharp.GraphQL.Attribute"
        | pascalGenericType -> pascalGenericType

    let toBuilderName = function
        | QueryBuilder str -> toCasing Pascal $"{str}QueryBuilder"
        | OperationQueryBuilder str -> toCasing Pascal $"{str}OperationQueryBuilder"
        | ArgumentBuilder str -> toCasing Pascal $"{str}ArgumentsBuilder"
        | UnionCasesBuilder str -> toCasing Pascal $"{str}UnionCasesBuilder"

    /// Fully qualifies builder class names which might collide with each other
    let qualifiedBuilderTypeName = function
        | QueryBuilder str -> toCasing Pascal $"{getQueryBuilderNamespace false}.{toBuilderName (QueryBuilder str)}"
        | OperationQueryBuilder str -> toCasing Pascal $"{getQueryBuilderNamespace true}.{toBuilderName (OperationQueryBuilder str)}"
        | x -> failwith $"Qualified builder type names are not implemented for builder type {x}"

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
    /// Sanitizes the value, replacing reserved C# keywords with <c>$"@{value}"</c>, and any word that collides with
    /// protected builder members with <c>$"{value}_"</c>.
    /// </summary>
    let sanitizeFieldOrOperationName (parentType: NamedType) (fieldName: string): string =
        // Public members from base builder classes that would cause collisions
        // Note: "Query" is protected and doesn't collide with public Query() methods
        let builderBaseMembers = Set.ofList ["Build"; "Alias"; "Arguments"; "Name"]

        if fieldName.Equals(string parentType, StringComparison.OrdinalIgnoreCase) then
            // The C# compiler will not allow the @ prefix for members that have the same name as their enclosing type
            fieldName + "_"
        elif Set.contains (toCasing Pascal fieldName) builderBaseMembers then
            // Collision with GraphQueryBuilder public properties/methods
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
