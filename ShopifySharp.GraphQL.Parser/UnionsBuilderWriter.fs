namespace ShopifySharp.GraphQL.Parser

open System.Threading.Tasks
open ShopifySharp.GraphQL.Parser.PipeWriter
open ShopifySharp.GraphQL.Parser.Utils

type UnionsBuilderWriter(type': VisitedTypes, context: IParsedContext) =
    let pascalClassName = toBuilderName (UnionsBuilder type'.Name)
    let genericTypeName =
        toGenericType type' context.AssumeNullability
        |> qualifiedPascalTypeName
    let queryType = $$"""IQuery<{{genericTypeName}}>"""

    let writeConstructor writer: ValueTask =
        pipeWriter writer {
            do! Indented + $$"""public {{pascalClassName}}({{queryType}} query)"""
            do! NewLine
            do! Indented + "{"
            do! NewLine
            do! DoubleIndented + "_query = query;"
            do! NewLine
            do! Indented + "}"
            do! NewLine
        }

    let rec collectUnionFields (visitedType: VisitedTypes): UnionCasesBuilderWriter array =
        let fields =
            match visitedType with
            | Class class' -> class'.Fields
            | Interface interface' -> interface'.Fields
            | InputObject inputObject -> inputObject.Fields
            | UnionType _
            | Operation _ ->
                Array.empty
            | _ ->
                Array.empty

        fields
        |> Array.choose (fun field ->
            match AstNodeMapper.unwrapFieldType field.ValueType with
            | FieldValueType.GraphObjectType (NamedType.UnionType (_, unionCaseNames)) ->
                Some (UnionCasesBuilderWriter(type', field.Name, unionCaseNames, field.Deprecation, context))
            | _ -> None)

    let unionFieldBuilders =
        match type' with
        | VisitedTypes.Operation operation ->
            match operation.ReturnType with
            | ReturnType.VisitedType visitedType ->
                collectUnionFields visitedType
            | ReturnType.FieldType (FieldType.ValueType (FieldValueType.GraphObjectType fieldValueType) as fieldType) ->
                match AstNodeMapper.unwrapFieldType fieldType with
                | FieldValueType.GraphObjectType (NamedType.UnionType (_, unionCaseNames)) ->
                    // TODO: naming is probably janky here
                    [| UnionCasesBuilderWriter(type', fieldValueType.Name, unionCaseNames, None, context)|]
                | _ ->
                    Array.empty
            | _ ->
                Array.empty
        | VisitedTypes.UnionType unionType ->
            // TODO: naming is probably janky here
            [| UnionCasesBuilderWriter(type', unionType.Name, Array.map (fun (x: VisitedTypes) -> x.Name) unionType.Cases, unionType.Deprecation, context)|]
        | visitedType ->
            collectUnionFields visitedType

    static member CanAddUnions type' =
        // TODO: improve this by checking if the type actually has unions available
        match type' with
        | VisitedTypes.Class _ -> true
        | Interface _ -> true
        | InputObject _-> false
        | UnionType _-> true
        | Enum _ -> false
        | Operation operation->
            match operation.ReturnType with
            | ReturnType.FieldType _ -> false
            | ReturnType.VisitedType type' -> UnionsBuilderWriter.CanAddUnions type'

    member _.UnionFieldBuilders = unionFieldBuilders

    member _.WriteToPipewriter writer: ValueTask =
        if not (UnionsBuilderWriter.CanAddUnions type') then
            ValueTask.CompletedTask
        else
            pipeWriter writer {
                // do! $$"""public sealed class {{pascalClassName}}"""
                // do! NewLine
                // do! "{"
                // do! NewLine
                // do! Indented + $$"""private readonly {{queryType}} _query;"""
                // do! NewLine + NewLine
                // yield! writeConstructor
                // do! NewLine + NewLine
                // // Iterate over the union field builders and instantiate them on this union builder
                // for builder in unionFieldBuilders do
                //     yield! writeDeprecationAttribute Indented builder.Deprecation
                //     do! Indented + $$"""public readonly {{builder.ClassName}} {{builder.FieldName}} = new(_query, "{{toCasing Camel builder.FieldName}}");"""
                //     do! NewLine + NewLine
                // do! "}"

                for builder in unionFieldBuilders do
                    yield! builder.WriteToPipewriter
                    do! NewLine + NewLine
            }
