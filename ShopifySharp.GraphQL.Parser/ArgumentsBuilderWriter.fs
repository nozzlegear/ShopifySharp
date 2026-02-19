namespace ShopifySharp.GraphQL.Parser

open System.Threading.Tasks
open ShopifySharp.GraphQL.Parser
open ShopifySharp.GraphQL.Parser.PipeWriter
open ShopifySharp.GraphQL.Parser.Utils

type ArgumentsBuilderWriter(type': VisitedTypes, context: IParsedContext) =
    let builderClassName = toBuilderName (ArgumentBuilder type'.Name)
    let genericTypeName =
        toGenericType type' context.AssumeNullability
        |> qualifiedPascalTypeName
    let queryType = $$"""IQuery<{{genericTypeName}}>"""

    let writeAddArgumentMethods writer: ValueTask =
        let arguments = ArgumentsBuilderWriter.CollectArgumentsForType type' context

        pipeWriter writer {
            let sanitizeArgumentName casing argName =
                sanitizeFieldOrOperationName (NamedType.Class builderClassName) argName
                |> toCasing casing

            for argument in arguments do
                let valueType =
                    AstNodeMapper.mapFieldTypeToString context.AssumeNullability argument.ValueType FieldTypeCollectionHandling.KeepCollection
                let camelArgumentName =
                    sanitizeArgumentName Camel argument.Name
                let pascalArgumentName =
                    toCasing Pascal argument.Name

                yield! writeDeprecationAttribute Indented argument.Deprecation
                do! $"public {builderClassName} {pascalArgumentName}({valueType} {camelArgumentName})"
                do! NewLine
                do! DoubleIndented + "{"
                do! NewLine
                do! TripleIndented + $$"""base.InnerQuery.AddArgument("{{argument.Name}}", {{camelArgumentName}});"""
                do! NewLine
                do! TripleIndented + "return this;"
                do! NewLine
                do! DoubleIndented + "}"
                do! NewLine
                do! NewLine
        }

    let writeConstructor writer: ValueTask =
        pipeWriter writer {
            do! Indented + $$"""public {{ builderClassName }}({{queryType}} query) : base(query)"""
            do! NewLine
            do! Indented + "{"
            do! NewLine
            do! Indented + "}"
            do! NewLine
        }

    let writeOverrideProperties writer: ValueTask =
        pipeWriter writer {
            do! Indented + $"protected override {builderClassName} Self => this;"
            do! NewLine + NewLine
        }

    /// Collects all unique arguments from fields that use this type as a return type.
    /// For operations, returns the operation's arguments directly.
    static member private CollectArgumentsForType (type': VisitedTypes) (context: IParsedContext) : FieldOrOperationArgument[] =
        match type' with
        | Operation operation ->
            // Operations have their own arguments
            operation.Arguments
        | _ ->
            // For other types, collect arguments from all fields that return this type
            let rec getReturnTypeName (fieldType: FieldType) =
                match AstNodeMapper.unwrapFieldType fieldType with
                | FieldValueType.GraphObjectType namedType -> Some namedType.Name
                | _ -> None

            let collectFieldArguments (fields: Field[]): FieldOrOperationArgument[] =
                fields
                |> Array.filter (fun field ->
                    match getReturnTypeName field.ValueType with
                    | Some name -> name = type'.Name && field.Arguments.Length > 0
                    | None -> false
                )
                |> Array.collect (fun field -> field.Arguments)

            // Grab the arguments from all types
            context.GetVisitedTypes()
            |> Array.collect (fun visitedType ->
                match visitedType with
                | VisitedTypes.Class class' -> collectFieldArguments class'.Fields
                | VisitedTypes.Interface interface' -> collectFieldArguments interface'.Fields
                | _ -> Array.empty
            )
            // Remove duplicates by argument name
            |> Array.distinctBy (fun arg -> arg.Name)

    /// Checks if a type name is used as a return type for any field that has arguments.
    /// If true, the query builder for this type should have a `.Arguments` property.
    static member HasFieldsWithArguments (typeName: string) (context: IParsedContext) =
        let rec getReturnTypeName (fieldType: FieldType) =
            match AstNodeMapper.unwrapFieldType fieldType with
            | FieldValueType.GraphObjectType namedType -> Some namedType.Name
            | _ -> None

        let checkFields (fields: Field[]) =
            fields
            |> Array.exists (fun field ->
                match getReturnTypeName field.ValueType with
                | Some name -> name = typeName && field.Arguments.Length > 0
                | None -> false
            )

        // Check all types in the context for fields that return this type with arguments
        context.GetVisitedTypes()
        |> Array.exists (fun visitedType ->
            match visitedType with
            | VisitedTypes.Class class' -> checkFields class'.Fields
            | VisitedTypes.Interface interface' -> checkFields interface'.Fields
            | _ -> false
        )

    static member CanAddArguments (type': VisitedTypes) (context: IParsedContext) =
        let arguments = ArgumentsBuilderWriter.CollectArgumentsForType type' context
        arguments.Length > 0

    member _.WriteToPipewriter writer: ValueTask =
        if ArgumentsBuilderWriter.CanAddArguments type' context then
            pipeWriter writer {
                do! $"""public sealed class { builderClassName } : ArgumentsBuilderBase<{genericTypeName}, {builderClassName}>"""
                do! NewLine
                do! "{"
                do! NewLine
                yield! writeOverrideProperties
                yield! writeConstructor
                do! NewLine + NewLine
                yield! writeAddArgumentMethods
                do! "}"
            }
        else
            ValueTask.CompletedTask
