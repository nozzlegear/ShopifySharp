namespace ShopifySharp.GraphQL.Parser

open System.Threading.Tasks
open ShopifySharp.GraphQL.Parser
open ShopifySharp.GraphQL.Parser.PipeWriter
open ShopifySharp.GraphQL.Parser.Utils

type ArgumentsBuilderWriter private (input: Choice<VisitedTypes, FieldArgumentsBuilderInfo>, context: IParsedContext) =
    let canAddArguments, arguments =
        match input with
        | Choice1Of2 type' -> ArgumentsBuilderWriter.CanAddArguments type' context, ArgumentsBuilderWriter.CollectArgumentsForType type' context
        | Choice2Of2 field -> not (Array.isEmpty field.Arguments), field.Arguments

    let builderClassName, genericTypeName =
            match input with
            | Choice1Of2 type' ->
                let genericTypeName =
                    toGenericType type' context.AssumeNullability
                    |> qualifiedPascalTypeName
                toBuilderName (ArgumentBuilder type'.Name), genericTypeName
            | Choice2Of2 field ->
                let returnTypeName =
                    AstNodeMapper.mapFieldTypeToString context.AssumeNullability field.ReturnType FieldTypeCollectionHandling.UnwrapCollection
                    |> qualifiedPascalTypeName
                toBuilderName (FieldsArgumentBuilder (field.ParentTypeName, field.FieldName)), returnTypeName

    let queryType = $$"""IQuery<{{genericTypeName}}>"""

    let writeAddArgumentMethods writer: ValueTask =
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

    new (type': VisitedTypes, context: IParsedContext) =
        ArgumentsBuilderWriter(Choice1Of2 type', context)

    new (info: FieldArgumentsBuilderInfo, context: IParsedContext) =
        ArgumentsBuilderWriter(Choice2Of2 info, context)

    /// Collects all unique arguments from fields that use this type as a return type.
    /// For operations, returns the operation's arguments directly.
    static member private CollectArgumentsForType (type': VisitedTypes) (context: IParsedContext) : FieldOrOperationArgument[] =
        match type' with
        | Operation operation ->
            // Operations have their own arguments
            operation.Arguments
        | _ ->
            // For other types, collect arguments from all fields that return this type
            // TODO: we can probably improve this by improving the AstNodeMapper itself to parse the
            //       return type on argument functions and store them in a list on the context.

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
                |> Array.collect _.Arguments

            // Grab the arguments from all types
            context.GetVisitedTypes()
            |> Array.collect (fun visitedType ->
                match visitedType with
                | VisitedTypes.Class class' -> collectFieldArguments class'.Fields
                | VisitedTypes.Interface interface' -> collectFieldArguments interface'.Fields
                | _ -> Array.empty
            )
            // Remove duplicates by argument name
            |> Array.distinctBy _.Name

    static member CanAddArguments (type': VisitedTypes) (context: IParsedContext) =
        let arguments = ArgumentsBuilderWriter.CollectArgumentsForType type' context
        arguments.Length > 0

    member _.WriteToPipewriter writer: ValueTask =
        if canAddArguments then
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
