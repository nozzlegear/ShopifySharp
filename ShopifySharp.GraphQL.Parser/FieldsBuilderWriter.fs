namespace ShopifySharp.GraphQL.Parser

open System.Threading.Tasks
open ShopifySharp.GraphQL.Parser
open ShopifySharp.GraphQL.Parser.PipeWriter
open ShopifySharp.GraphQL.Parser.Utils

type FieldsBuilderWriter(type': VisitedTypes, builderClassName: string, _context: IParsedContext) =

    let writeQueryBuilderFieldMethod (fieldName: string)
                                     (fieldType: FieldType)
                                     (deprecationWarning: string option)
                                     writer =
        let pascalFieldName =
            toCasing Pascal fieldName
            |> sanitizeFieldOrOperationName (NamedType.Class type'.Name)
         // Use original field name for GraphQL
        let camelFieldName = toCasing Camel fieldName

        pipeWriter writer {
            match AstNodeMapper.unwrapFieldType fieldType with
            | FieldValueType.GraphObjectType (NamedType.UnionType _) ->
                // Handled by union case builder methods
                ()
            | FieldValueType.GraphObjectType (NamedType.Class graphObjectTypeName as namedType)
            | FieldValueType.GraphObjectType (NamedType.Interface graphObjectTypeName as namedType)
            | FieldValueType.GraphObjectType (NamedType.InputObject graphObjectTypeName as namedType) ->
                let pascalTypeName =
                    if namedType.IsInterface
                    then toCasing Pascal $"I{graphObjectTypeName}"
                    else qualifiedPascalTypeName graphObjectTypeName
                let nestedQueryBuilderName =
                    // Note: using QueryBuilder here ensures the OperationQueryBuilders are never unintentionally used in the AddField methods
                    qualifiedBuilderTypeName (QueryBuilder graphObjectTypeName)

                yield! writeDeprecationAttribute Indented None
                do! Indented + $"public {builderClassName} {pascalFieldName}(Action<{nestedQueryBuilderName}> build)"
                do! NewLine
                do! Indented + "{"
                do! NewLine
                do! DoubleIndented + $"var query = new Query<{pascalTypeName}>(\"{camelFieldName}\");"
                do! NewLine
                do! DoubleIndented + $"var queryBuilder = new {nestedQueryBuilderName}(query);"
                do! NewLine + NewLine
                do! DoubleIndented + "build.Invoke(queryBuilder);"
                do! NewLine
                do! DoubleIndented + $"base.InnerQuery.AddField<{pascalTypeName}>(query);"
                do! NewLine + NewLine
                do! DoubleIndented + "return this;"
                do! NewLine
                do! Indented + "}"
                do! NewLine
            | _ ->
                yield! writeDeprecationAttribute Indented deprecationWarning
                do! Indented + $"public {builderClassName} {pascalFieldName}()"
                do! NewLine
                do! Indented + "{"
                do! NewLine
                do! DoubleIndented + $"base.InnerQuery.AddField(\"{camelFieldName}\");"
                do! NewLine
                do! DoubleIndented + $"return this;"
                do! NewLine
                do! Indented + "}"
                do! NewLine
        }

    let writeQueryBuilderReturnValueMethod writer =
        pipeWriter writer {
            do! Indented + $"public {builderClassName} ReturnValue()"
            do! NewLine
            do! Indented + "{"
            do! NewLine
            do! DoubleIndented + "// This method is a no-op – the value will be included automatically by virtue of this QueryBuilder being used in a query"
            do! NewLine
            do! DoubleIndented + "return this;"
            do! NewLine
            do! Indented + "}"
            do! NewLine
        }

    let writeQueryBuilderUnionCaseMethods (builders: UnionCasesBuilderWriter array) writer: ValueTask =
        pipeWriter writer {
            for builder in builders do
                yield! writeDeprecationAttribute Indented builder.DeprecationWarning
                do! Indented + $$"""public {{builderClassName}} {{builder.PascalFieldName}}(Action<{{builder.BuilderClassName}}> build)"""
                do! NewLine
                do! Indented + "{"
                do! NewLine
                do! DoubleIndented + $$"""var query = new Query<{{builder.GenericTypeName}}>("{{builder.CamelFieldName}}", base.InnerQuery.Options);"""
                do! NewLine
                do! DoubleIndented + $$"""var unionBuilder = new {{builder.BuilderClassName}}(query);"""
                do! NewLine + NewLine
                do! DoubleIndented + "build.Invoke(unionBuilder);"
                do! NewLine
                do! DoubleIndented + "base.InnerQuery.AddUnionCase(query);"
                do! NewLine + NewLine
                do! DoubleIndented + "return this;"
                do! NewLine
                do! Indented + "}"
                do! NewLine + NewLine
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

    /// Writes the field methods for the writer's type to the <paramref name="writer"/>
    member _.WriteFieldMethodsForQueryBuilder (unionFieldBuilders: UnionCasesBuilderWriter array)
                                              writer: ValueTask =

        pipeWriter writer {
            match type' with
            | VisitedTypes.Operation operation ->
                match operation.ReturnType with
                | ReturnType.FieldType (FieldType.ValueType (FieldValueType.GraphObjectType graphValueType)) ->
                    let fieldType = FieldType.ValueType (FieldValueType.GraphObjectType graphValueType)
                    let fieldName = graphValueType.ToString()
                    yield! writeQueryBuilderFieldMethod fieldName fieldType None
                | ReturnType.FieldType _ ->
                    yield! writeQueryBuilderReturnValueMethod
                | ReturnType.VisitedType visitedType ->
                    // Write the field methods for this type
                    match visitedType with
                    | VisitedTypes.UnionType _ ->
                        // Union cases will be added below
                        ()
                    | visitedType ->
                        let fields =
                            match visitedType with
                            | VisitedTypes.Class class' -> class'.Fields
                            | VisitedTypes.Interface interface' -> interface'.Fields
                            | VisitedTypes.InputObject inputObject -> inputObject.Fields
                            | _ -> failwith $"The VisitedType %A{visitedType.Name} is not supported here."

                        for field in fields do
                            yield! writeQueryBuilderFieldMethod field.Name field.ValueType field.Deprecation
            | visitedType ->
                match visitedType with
                | VisitedTypes.UnionType _ ->
                    // Union cases will be added below
                    ()
                | visitedType ->
                    let fields =
                        match visitedType with
                        | VisitedTypes.Class class' -> class'.Fields
                        | VisitedTypes.Interface interface' -> interface'.Fields
                        | VisitedTypes.InputObject inputObject -> inputObject.Fields
                        | _ -> failwith $"The VisitedType %A{visitedType.Name} is not supported here."

                    for field in fields do
                        yield! writeQueryBuilderFieldMethod field.Name field.ValueType field.Deprecation

            // Add union case methods
            yield! writeQueryBuilderUnionCaseMethods unionFieldBuilders
        }
