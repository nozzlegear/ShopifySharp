namespace ShopifySharp.GraphQL.Parser

open System.Threading.Tasks
open ShopifySharp.GraphQL.Parser.PipeWriter
open ShopifySharp.GraphQL.Parser.Utils

type UnionsBuilderWriter(type': VisitedTypes, context: IParsedContext) =
    let pascalClassName = toBuilderName (UnionsBuilder type'.Name)
    let genericTypeName =
        toGenericType type' context.AssumeNullability
        |> qualifiedPascalTypeName
    let queryType = $$"""IQuery<ShopifySharp.GraphQL.{{genericTypeName}}>"""

    let writeUnionCaseJoin (pascalParentClassName: string) (unionCaseName: string) (fieldName: string) (_: IParsedContext) writer: ValueTask =
        pipeWriter writer {
            let pascalUnionCaseName = toCasing Pascal unionCaseName
            let pascalFieldName = toCasing Pascal fieldName
            let camelFieldName = toCasing Camel fieldName
            let unionCaseQueryBuilderName = $"{pascalUnionCaseName}QueryBuilder"

            do! Indented + $"public {pascalParentClassName} AddUnionCase{pascalFieldName}(Func<{unionCaseQueryBuilderName}, {unionCaseQueryBuilderName}> build)"
            do! NewLine
            do! Indented + "{"
            do! NewLine
            do! DoubleIndented + $"AddUnionCase<{pascalUnionCaseName}, {unionCaseQueryBuilderName}>(\"{camelFieldName}\", \"{pascalUnionCaseName}\", build);"
            do! NewLine
            do! DoubleIndented + "return this;"
            do! NewLine
            do! Indented + "}"
            do! NewLine
        }

    let writeQueryBuilderAddFieldMethod (fieldName: string)
                                        (fieldType: FieldType)
                                        (deprecationWarning: string option)
                                        writer =
        pipeWriter writer {
            match AstNodeMapper.unwrapFieldType fieldType with
            | FieldValueType.GraphObjectType (NamedType.UnionType (_, unionCaseNames)) ->
                for unionCaseName in unionCaseNames do
                    yield! writeDeprecationAttribute Indented deprecationWarning
                    yield! writeUnionCaseJoin pascalClassName unionCaseName fieldName context
            | _ ->
                do! NewLine
        }

    let writeForVisitedType visitedType writer: ValueTask =
        pipeWriter writer {
            match visitedType with
            | VisitedTypes.UnionType unionType ->
                for unionCase in unionType.Cases do
                    yield! writeUnionCaseJoin pascalClassName unionCase.Name unionCase.Name context
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

    let writeAddUnionMethods writer: ValueTask =
        pipeWriter writer{
            match type' with
            | VisitedTypes.Operation operation ->
                match operation.ReturnType with
                | ReturnType.FieldType (FieldType.ValueType (FieldValueType.GraphObjectType graphValueType)) ->
                    let fieldType = FieldType.ValueType (FieldValueType.GraphObjectType graphValueType)
                    let fieldName = graphValueType.ToString()
                    yield! writeQueryBuilderAddFieldMethod fieldName fieldType None
                | ReturnType.FieldType _ ->
                    ()
                | ReturnType.VisitedType visitedType ->
                    yield! writeForVisitedType visitedType
            | visitedType ->
                yield! writeForVisitedType visitedType
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

    member _.WriteToPipewriter writer: ValueTask =
        if not (UnionsBuilderWriter.CanAddUnions type') then
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
                yield! writeAddUnionMethods
                do! "}"
            }
