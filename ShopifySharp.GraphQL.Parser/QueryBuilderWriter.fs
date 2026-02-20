namespace ShopifySharp.GraphQL.Parser

open System.Threading.Tasks
open GraphQLParser.AST
open ShopifySharp.GraphQL.Parser
open ShopifySharp.GraphQL.Parser.PipeWriter
open Utils

type QueryBuilderWriter(type': VisitedTypes, context: IParsedContext) =
    static let [<Literal>] QueryRootObjectName = "QueryRoot"
    static let [<Literal>] MutationRootObjectName = "Mutation"

    let builderClassName =
        if type'.IsOperation then toBuilderName (OperationQueryBuilder type'.Name)
        else toBuilderName (QueryBuilder type'.Name)
    let genericTypeName =
        toGenericType type' context.AssumeNullability
        |> qualifiedPascalTypeName
    let queryType = $$"""IQuery<{{genericTypeName}}>"""

    let writeClassNameAndInheritedType writer: ValueTask =
        let baseBuilderClassName =
            if FieldsBuilderWriter.CanAddFields type' || UnionsBuilderWriter.CanAddUnions type' then
                "FieldsQueryBuilderBase"
            else
                "QueryBuilderBase"

        pipeWriter writer {
            do! $"public sealed class {builderClassName}: {baseBuilderClassName}<{genericTypeName}, {builderClassName}>"

            if type'.IsOperation then
                do! $", IGraphOperationQueryBuilder<{genericTypeName}>"

            if ArgumentsBuilderWriter.CanAddArguments type' context then
                let argBuilderName = toBuilderName (ArgumentBuilder type'.Name)
                do! $", IHasArguments<{argBuilderName}>"

            do! NewLine
        }

    let writeOperationTypeProperty (operationType: OperationType) writer: ValueTask =
        pipeWriter writer {
            do! Indented + "public OperationType OperationType { get; } = "
            match operationType with
            | OperationType.Query -> do! "OperationType.Query;"
            | OperationType.Mutation -> do! "OperationType.Mutation;"
            | value -> failwith $"Operation type \"{value}\" is not supported."
            do! NewLine
        }

    let writeSubQueryBuilderProperties writer: ValueTask =
        pipeWriter writer {
            if ArgumentsBuilderWriter.CanAddArguments type' context then
                do! Indented + $$"""public {{ toBuilderName (ArgumentBuilder type'.Name)}} Arguments { get; }"""
                do! NewLine
        }

    let writeOverrideProperties writer: ValueTask =
        pipeWriter writer {
            do! Indented + $"protected override {builderClassName} Self => this;"
            do! NewLine
        }

    let writeConstructor writer: ValueTask =
        let defaultQueryName =
            match type' with
            | VisitedTypes.Operation operation -> operation.Name
            | _ -> type'.Name

        pipeWriter writer {
            // Public parameterless constructor
            do! Indented + $"""public {builderClassName}(): this("{toCasing Camel defaultQueryName}")"""
            do! NewLine + "{}"
            do! NewLine + NewLine

            // Public constructor with name
            do! Indented + $"""public {builderClassName}(string name): base(new Query<{genericTypeName}>(name))"""
            do! NewLine + "{"

            if ArgumentsBuilderWriter.CanAddArguments type' context then
                do! NewLine
                do! DoubleIndented + $$"""Arguments = new {{toBuilderName (ArgumentBuilder type'.Name)}}(base.InnerQuery);"""
                do! NewLine

            do! NewLine + "}"
            do! NewLine + NewLine

            do! Indented + $"""public {builderClassName}({queryType} query): base(query)"""
            do! NewLine + "{"

            if ArgumentsBuilderWriter.CanAddArguments type' context then
                do! DoubleIndented + $$"""Arguments = new {{toBuilderName (ArgumentBuilder type'.Name)}}(base.InnerQuery);"""
                do! NewLine

            do! NewLine + "}"
            do! NewLine
        }

    let writeNamespaceStart (namespaceName: string) writer: ValueTask =
        pipeWriter writer {
            do! $"namespace {namespaceName}"
            do! NewLine
            do! "{"
            do! NewLine
        }

    let writeNamespaceEnd writer: ValueTask =
        pipeWriter writer {
            do! "}"
            do! NewLine
        }

    static let writeUsingsOnce writer: ValueTask =
        pipeWriter writer {
            // Write using directives once at the top level
            // FileSystem.fs will extract these and add them to each generated file
            do! "#nullable enable"
            do! NewLine
            do! "using System;"
            do! NewLine
            do! "using System.Threading.Tasks;"
            do! NewLine
            do! "using System.Text.Json.Serialization;"
            do! NewLine
            do! "using System.Collections.Generic;"
            do! NewLine
            do! "using System.Linq.Expressions;"
            do! NewLine
            do! "using ShopifySharp.Credentials;"
            do! NewLine
            do! "using ShopifySharp.GraphQL;"
            do! NewLine
            do! "using ShopifySharp.GraphQL.QueryBuilders;"
            do! NewLine
            do! "using ShopifySharp.Infrastructure;"
            do! NewLine
            do! "using ShopifySharp.Infrastructure.Serialization.Json;"
            do! NewLine
            // Add using directives for generated namespaces so they can reference each other
            do! "using " + getQueryBuilderNamespace true + ";"
            do! NewLine
            do! "using " + getQueryBuilderNamespace false + ";"
            do! NewLine
            do! NewLine
        }

    // TODO: move this to the FieldsBuilderWriter
    let writeFieldSpecificQueryBuilderWrapper (fieldInfo: FieldArgumentsBuilderInfo) writer: ValueTask =
        // Generate a standalone QueryBuilder for this field: {ParentType}{PascalField}QueryBuilder
        // This is a complete QueryBuilder that inherits directly from FieldsQueryBuilderBase,
        // NOT from the base type's QueryBuilder. This allows all generated classes to be sealed.
        let pascalParentType = toCasing Pascal fieldInfo.ParentTypeName
        let pascalFieldName = toCasing Pascal fieldInfo.FieldName
        let wrapperClassName = $"{pascalParentType}{pascalFieldName}QueryBuilder"
        let argBuilderClassName = $"{pascalParentType}{pascalFieldName}ArgumentsBuilder"

        // The base query builder and field builder classes both require
        // non-nullable reference types for the T parameter
        let unwrappedFieldValueType = AstNodeMapper.unwrapFieldType fieldInfo.ReturnType
        let nonNullableTypeName =
            AstNodeMapper.mapValueTypeToString unwrappedFieldValueType
            |> qualifiedPascalTypeName
        let queryType = $"IQuery<{nonNullableTypeName}>"

        // Look up the return type to get its fields
        let baseTypeName =
            match unwrappedFieldValueType with
            | FieldValueType.GraphObjectType namedType -> namedType.Name
            | _ -> failwith "Field return type must be a GraphObjectType"

        // Look up the return type to get its fields
        let returnType = context.TryFindGraphObjectType baseTypeName

        ValueTask(task {
            do! pipeWriter writer {
                do! $"public sealed class {wrapperClassName} : FieldsQueryBuilderBase<{nonNullableTypeName}, {wrapperClassName}>, IHasArguments<{argBuilderClassName}>"
                do! NewLine
                do! "{"
                do! NewLine

                // Arguments property
                do! Indented + $"public {argBuilderClassName} Arguments {{ get; }}"
                do! NewLine + NewLine

                // Self property override
                do! Indented + $"protected override {wrapperClassName} Self => this;"
                do! NewLine + NewLine

                // Constructor that takes a query name
                do! Indented + $"public {wrapperClassName}(string name) : base(new Query<{nonNullableTypeName}>(name))"
                do! NewLine
                do! Indented + "{"
                do! NewLine
                do! DoubleIndented + $"Arguments = new {argBuilderClassName}(base.InnerQuery);"
                do! NewLine
                do! Indented + "}"
                do! NewLine + NewLine

                // Constructor that takes an IQuery (for internal use)
                do! Indented + $"public {wrapperClassName}({queryType} query) : base(query)"
                do! NewLine
                do! Indented + "{"
                do! NewLine
                do! DoubleIndented + $"Arguments = new {argBuilderClassName}(base.InnerQuery);"
                do! NewLine
                do! Indented + "}"
                do! NewLine + NewLine

                // Add instance SetArguments method for fluent configuration API
                yield! writeArgumentsMethod wrapperClassName argBuilderClassName

                do! NewLine
            }

            // Generate field methods for the return type
            match returnType with
            | Some visitedType ->
                let fieldsWriter = FieldsBuilderWriter(visitedType, wrapperClassName, context)
                let unionsWriter = UnionsBuilderWriter(visitedType, context)

                if FieldsBuilderWriter.CanAddFields visitedType || UnionsBuilderWriter.CanAddUnions visitedType then
                    // Generate field methods but ignore the returned FieldArgumentsBuilderInfo
                    // (nested wrappers are already generated from the base type's generation)
                    let! _ = fieldsWriter.WriteFieldMethodsForQueryBuilder unionsWriter.UnionFieldBuilders writer
                    ()
            | None ->
                printfn $"Warning: Could not find return type {baseTypeName} for field-specific QueryBuilder {wrapperClassName}"

            do! pipeWriter writer {
                do! "}"
                do! NewLine + NewLine
            }
        })

    member _.WriteToPipe writer: ValueTask =
        if type'.IsEnum || type'.IsInputObject then
            failwithf $"The {type'.GetType().Name} type is not supported."

        let argumentsBuilder = ArgumentsBuilderWriter(type', context)
        let unionsBuilder = UnionsBuilderWriter(type', context)
        let namespaceName = getQueryBuilderNamespace type'.IsOperation

        ValueTask(task {
            let fieldsWriter = FieldsBuilderWriter(type', builderClassName, context)

            // First, write the main QueryBuilder class
            do! pipeWriter writer {
                // Write namespace start for this builder
                yield! writeNamespaceStart namespaceName

                yield! writeDeprecationAttribute Outdented type'.Deprecation
                yield! writeClassNameAndInheritedType
                do! "{"
                do! NewLine

                match type' with
                | Operation operation ->
                    yield! writeOperationTypeProperty operation.Type
                | _ ->
                    ()

                yield! writeSubQueryBuilderProperties
                yield! writeOverrideProperties
                yield! writeConstructor

                do! NewLine
            }

            // Add field methods directly to QueryBuilder and collect field-specific ArgumentsBuilder info
            if FieldsBuilderWriter.CanAddFields type' || UnionsBuilderWriter.CanAddUnions type' then
                do! fieldsWriter.WriteFieldMethodsForQueryBuilder unionsBuilder.UnionFieldBuilders writer

            let mappedFieldArgumentsInfo = FieldsBuilderWriter.MapFieldArgumentsToArgumentBuildersInfo type'

            do! pipeWriter writer {
                do! "}"
                do! NewLine

                // Keep ArgumentsBuilder and UnionCasesBuilder as separate classes
                yield! argumentsBuilder.WriteToPipewriter
                yield! unionsBuilder.WriteToPipewriter

                // Generate field-specific ArgumentsBuilders and QueryBuilders only for non-Operation types
                // Operations already have their own unique query builders, so we don't need field-specific ones
                if not type'.IsOperation then
                    // Generate field-specific ArgumentsBuilders for fields with arguments
                    for fieldArgs in mappedFieldArgumentsInfo do
                        let builder = ArgumentsBuilderWriter(fieldArgs, context)
                        yield! builder.WriteToPipewriter

                    // Generate wrapper QueryBuilders for fields with arguments
                    for fieldArgBuilder in mappedFieldArgumentsInfo do
                        yield! writeFieldSpecificQueryBuilderWrapper fieldArgBuilder

                // Close namespace
                yield! writeNamespaceEnd
            }
        })

    static member WriteQueryBuildersToPipe (context: ParserContext) writer: ValueTask =
        let parsedContext = context :> IParsedContext

        // Step 1: Collect all operations
        let operations: Operation list =
            parsedContext.Document.Definitions
            |> Seq.collect (function
            | :? GraphQLObjectTypeDefinition as objDef when
                objDef.Name.StringValue = QueryRootObjectName || objDef.Name.StringValue = MutationRootObjectName ->

                let operationType =
                    match objDef.Name.StringValue with
                    | "QueryRoot" -> OperationType.Query
                    | "Mutation" -> OperationType.Mutation
                    | value -> failwith $"{value} is not a supported operation type"

                // Collect each operation
                objDef.Fields
                |> Seq.map (AstNodeMapper.mapRootFieldDefinition context operationType)
            | _ ->
                []
            )
            |>  List.ofSeq

        printfn $"Collected {operations.Length} operations for reachability analysis"

        // Step 2: Use the ReachabilityAnalyzer to map the types that are reachable from the collectd operations
        let reachabilityTracker = ReachabilityAnalyzer.analyzeReachabilityFromOperations operations parsedContext

        let tryMapQueryBuilder node writer: ValueTask =
            pipeWriter writer {
                match AstNodeMapper.tryMap context node with
                | None ->
                    printfn $"No mapping for type %A{node.GetType()}"
                | Some (VisitedTypes.InputObject _)
                | Some (VisitedTypes.Enum _) ->
                    // InputObjects and Enums do not need a QueryBuilder and are not supported
                    ()
                | Some mappedType ->
                    if mappedType.Name.EndsWith("Payload") then
                        // Payload types do not need a query builder (it doesn't make sense to
                        // create a graphql string representation of the input data being sent
                        // to Shopify, we use "real" .NET types for that)
                        ()
                    elif not (reachabilityTracker.Contains(mappedType.Name)) then
                        // Skip types that are not reachable from any operation
                        ()
                    else
                        let queryBuilderWriter = QueryBuilderWriter(mappedType, parsedContext)
                        yield! queryBuilderWriter.WriteToPipe
            }

        pipeWriter writer {
            // Write using directives once at the top; the FileSystem module will extract and reuse them
            yield! writeUsingsOnce

            for node in parsedContext.Document.Definitions do
                match node with
                | :? GraphQLObjectTypeDefinition as objDef when
                    objDef.Name.StringValue = QueryRootObjectName || objDef.Name.StringValue = MutationRootObjectName ->

                    let operationType =
                        match objDef.Name.StringValue with
                        | "QueryRoot" -> OperationType.Query
                        | "Mutation" -> OperationType.Mutation
                        | value -> failwith $"{value} is not a supported operation type"

                    // Each field in this object is an operation and will always be generated regardless of reachability
                    for field in objDef.Fields do
                        let operation = AstNodeMapper.mapRootFieldDefinition context operationType field
                        let queryBuilderWriter = QueryBuilderWriter(Operation operation, parsedContext)
                        yield! queryBuilderWriter.WriteToPipe

                    // If this is the QueryRoot operation, write it to the pipe as well (some users like to have the
                    // QueryRoot available as a deserialization target)
                    if operationType = OperationType.Query then
                        yield! tryMapQueryBuilder node
                | _ ->
                    yield! tryMapQueryBuilder node
        }
