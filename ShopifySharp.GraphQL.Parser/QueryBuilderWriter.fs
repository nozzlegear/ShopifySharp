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
            if ArgumentsBuilderWriter.CanAddArguments type' then
                do! Indented + $$"""public {{ toBuilderName (QueryBuilderTypes.ArgumentBuilder type'.Name)}} Arguments { get; }"""
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

            if ArgumentsBuilderWriter.CanAddArguments type' then
                do! DoubleIndented + $$"""Arguments = new {{toBuilderName (ArgumentBuilder type'.Name)}}(base.InnerQuery);"""
                do! NewLine

            do! NewLine + "}"
            do! NewLine + NewLine

            do! Indented + $"""public {builderClassName}({queryType} query): base(query)"""
            do! NewLine + "{"

            if ArgumentsBuilderWriter.CanAddArguments type' then
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

    member _.WriteToPipe writer: ValueTask =
        if type'.IsEnum || type'.IsInputObject then
            failwithf $"The {type'.GetType().Name} type is not supported."

        let argumentsBuilder = ArgumentsBuilderWriter(type', context)
        let unionsBuilder = UnionsBuilderWriter(type', context)
        let namespaceName = getQueryBuilderNamespace type'.IsOperation

        pipeWriter writer {
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

            // Add field methods directly to QueryBuilder
            if FieldsBuilderWriter.CanAddFields type' || UnionsBuilderWriter.CanAddUnions type' then
                do! NewLine
                // Generate field methods inline
                let fieldsWriter = FieldsBuilderWriter(type', builderClassName, context)
                yield! fieldsWriter.WriteFieldMethodsForQueryBuilder unionsBuilder.UnionFieldBuilders
            else
                printfn $"Type {type'.Name} does not support fields."

            do! "}"
            do! NewLine

            // Keep ArgumentsBuilder and UnionCasesBuilder as separate classes
            yield! argumentsBuilder.WriteToPipewriter
            yield! unionsBuilder.WriteToPipewriter

            // Close namespace
            yield! writeNamespaceEnd
        }

    static member WriteQueryBuildersToPipe (context: ParserContext) writer: ValueTask =
        let parsedContext = context :> IParsedContext

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
                    let queryBuilderWriter = QueryBuilderWriter(mappedType, parsedContext)
                    yield! queryBuilderWriter.WriteToPipe
            }

        pipeWriter writer {
            // Write using directives once at the top - FileSystem will extract and reuse them
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

                    // Each field in this object is an operation and should have a QueryBuilder
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
