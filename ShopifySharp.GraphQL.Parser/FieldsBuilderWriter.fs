namespace ShopifySharp.GraphQL.Parser

open System.Threading.Tasks
open ShopifySharp.GraphQL.Parser
open ShopifySharp.GraphQL.Parser.PipeWriter
open ShopifySharp.GraphQL.Parser.Utils

type FieldsBuilderWriter(type': VisitedTypes, context: IParsedContext) =
    let pascalClassName = toBuilderName (FieldsBuilder type'.Name)
    let genericTypeName =
        toGenericType type' context.AssumeNullability
        |> qualifiedPascalTypeName
    let queryType = $$"""IQuery<ShopifySharp.GraphQL.{{genericTypeName}}>"""

    let writeQueryBuilderAddFieldMethod (fieldName: string)
                                        (fieldType: FieldType)
                                        (deprecationWarning: string option)
                                        writer =
        let pascalFieldName = toCasing Pascal fieldName
        let camelFieldName = toCasing Camel fieldName

        pipeWriter writer {
            match AstNodeMapper.unwrapFieldType fieldType with
            | FieldValueType.GraphObjectType (NamedType.UnionType _) ->
                // Handled by the UnionsBuilderWriter
                ()
            | FieldValueType.GraphObjectType (NamedType.Class graphObjectTypeName as namedType)
            | FieldValueType.GraphObjectType (NamedType.Interface graphObjectTypeName as namedType)
            | FieldValueType.GraphObjectType (NamedType.InputObject graphObjectTypeName as namedType) ->
                let pascalTypeName =
                    if namedType.IsInterface
                    then toCasing Pascal $"I{graphObjectTypeName}"
                    else qualifiedPascalTypeName graphObjectTypeName
                let queryBuilderName = $"{toCasing Pascal graphObjectTypeName}QueryBuilder"

                // TODO: if this is a collection type (not fieldType.IsFieldValueType), use the AddField collection overload

                yield! writeDeprecationAttribute Indented None
                do! Indented + $"public {pascalClassName} {pascalFieldName}(Func<{queryBuilderName}, {queryBuilderName}> build)"
                do! NewLine
                do! DoubleIndented + "{"
                do! NewLine
                do! TripleIndented + $"AddField<{pascalTypeName}, {queryBuilderName}>(\"{camelFieldName}\", build);"
                do! NewLine
                do! TripleIndented + "return this;"
                do! NewLine
                do! DoubleIndented + "}"
                do! NewLine
            | _ ->
                // TODO: if this is a collection type (not fieldType.IsFieldValueType), use the AddField collection overload

                yield! writeDeprecationAttribute Indented deprecationWarning
                do! Indented + $"public {pascalClassName} {pascalFieldName}()"
                do! NewLine
                do! DoubleIndented + "{"
                do! NewLine
                do! DoubleIndented + $"AddField(\"{camelFieldName}\");"
                do! NewLine
                do! TripleIndented + "return this;"
                do! NewLine
                do! DoubleIndented + "}"
                do! NewLine
        }

    let writeAddFieldMethods writer: ValueTask =
        let writeAddReturnValue (_: FieldType): ValueTask =
            pipeWriter writer {
                do! Indented + $"public {pascalClassName} ReturnValue()"
                do! NewLine
                do! DoubleIndented + "{"
                do! NewLine
                do! DoubleIndented + "// This method is a no-op – the value will be included automatically by virtue of this QueryBuilder being included"
                do! NewLine
                do! TripleIndented + "return this;"
                do! NewLine
                do! DoubleIndented + "}"
                do! NewLine
            }

        let writeForVisitedType (visitedType: VisitedTypes): ValueTask =
            pipeWriter writer {
                match visitedType with
                | VisitedTypes.UnionType _ ->
                    // Handled by the UnionsBuilderWriter
                    ()
                | visitedType ->
                    let fields =
                        match visitedType with
                        | VisitedTypes.Class class' ->
                            class'.Fields
                        | VisitedTypes.Interface interface' ->
                            interface'.Fields
                        | VisitedTypes.InputObject inputObject ->
                            inputObject.Fields
                        | _ ->
                            failwith $"The VisitedType %A{visitedType.Name} is not supported here."

                    for field in fields do
                        yield! writeQueryBuilderAddFieldMethod field.Name field.ValueType field.Deprecation
            }

        pipeWriter writer {
            match type' with
            | VisitedTypes.Operation operation ->
                match operation.ReturnType with
                | ReturnType.FieldType (FieldType.ValueType (FieldValueType.GraphObjectType graphValueType)) ->
                    let fieldType = FieldType.ValueType (FieldValueType.GraphObjectType graphValueType)
                    let fieldName = graphValueType.ToString()
                    yield! writeQueryBuilderAddFieldMethod fieldName fieldType None
                | ReturnType.FieldType fieldType ->
                    do! writeAddReturnValue fieldType
                | ReturnType.VisitedType visitedTypes ->
                    do! writeForVisitedType visitedTypes
            | visitedType ->
                do! writeForVisitedType visitedType
        }

    let writeConstructor writer: ValueTask =
        pipeWriter writer {
            do! Indented + $$"""public {{pascalClassName}}({{queryType}} query)"""
            do! NewLine
            do! Indented + "{"
            do! NewLine
            do! DoubleIndented + "Query = query;"
            do! NewLine
            do! Indented + "}"
            do! NewLine
        }

    static member CanAddFields type' =
        // TODO: improve this by checking if the type actually has fields available
        match type' with
        | VisitedTypes.Class _ -> true
        | VisitedTypes.Interface _ -> true
        | VisitedTypes.Enum _ -> false
        | VisitedTypes.InputObject _ -> true
        | VisitedTypes.UnionType _ -> false
        | VisitedTypes.Operation operation ->
            match operation.ReturnType with
            | ReturnType.FieldType _ -> true
            | ReturnType.VisitedType type' -> FieldsBuilderWriter.CanAddFields type'

    member _.WriteToPipewriter writer: ValueTask =
        if not (FieldsBuilderWriter.CanAddFields type') then
            ValueTask.CompletedTask
        else
            pipeWriter writer {
                do! $$"""public sealed class {{pascalClassName}}"""
                do! NewLine
                do! "{"
                do! NewLine
                do! Indented + $$"""private {{queryType}} Query { get; }"""
                do! NewLine + NewLine
                yield! writeConstructor
                do! NewLine + NewLine
                yield! writeAddFieldMethods
                do! "}"
            }
