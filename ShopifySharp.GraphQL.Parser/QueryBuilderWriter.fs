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

        pipeWriter writer {
            do! $"public sealed class {builderClassName}: GraphQueryBuilder<{genericTypeName}>"

            if type'.IsOperation then
                do! ", IGraphOperationQueryBuilder"

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

    let writeConstructor writer: ValueTask =
        let queryType =
            $$"""Query<{{genericTypeName}}>"""
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
            do! Indented + $"""public {builderClassName}(string name): base(new {queryType}(name))"""
            do! NewLine + "{"

            if ArgumentsBuilderWriter.CanAddArguments type' then
                do! DoubleIndented + $$"""Arguments = new {{toBuilderName (ArgumentBuilder type'.Name)}}(base.Query);"""
                do! NewLine

            do! NewLine + "}"
            do! NewLine + NewLine

            // Private copy constructor for immutability
            do! Indented + $"""private {builderClassName}({queryType} query): base(query)"""
            do! NewLine + "{"

            if ArgumentsBuilderWriter.CanAddArguments type' then
                do! DoubleIndented + $$"""Arguments = new {{toBuilderName (ArgumentBuilder type'.Name)}}(base.Query);"""
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

    static let determineNamespace (isOperation: bool): string =
        // Operations go in QueryBuilders.Operations namespace, everything else in QueryBuilders.Types
        // ArgumentsBuilder and UnionCasesBuilder are written with their parent QueryBuilder
        // so they'll be in the same namespace
        if isOperation then
            "ShopifySharp.GraphQL.Generated.QueryBuilders.Operations"
        else
            "ShopifySharp.GraphQL.Generated.QueryBuilders.Types"

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
            do! "using ShopifySharp.Infrastructure;"
            do! NewLine
            do! "using ShopifySharp.Infrastructure.Serialization.Json;"
            do! NewLine
            // Add using directives for generated namespaces so they can reference each other
            do! "using " + determineNamespace true + ";"
            do! NewLine
            do! "using " + determineNamespace false + ";"
            do! NewLine
            do! NewLine
        }

    member _.WriteToPipe writer: ValueTask =
        if type'.IsEnum || type'.IsInputObject then
            failwithf $"The {type'.GetType().Name} type is not supported."

        let fieldsBuilder = FieldsBuilderWriter(type', context)
        let argumentsBuilder = ArgumentsBuilderWriter(type', context)
        let unionsBuilder = UnionsBuilderWriter(type', context)
        let builderName = toBuilderName (QueryBuilder type'.Name)
        let genericTypeName =
            toGenericType type' context.AssumeNullability
            |> qualifiedPascalTypeName
        let namespaceName = determineNamespace type'.IsOperation

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
            yield! writeConstructor

            // Add field methods directly to QueryBuilder
            if FieldsBuilderWriter.CanAddFields type' || UnionsBuilderWriter.CanAddUnions type' then
                do! NewLine
                // Generate field methods inline
                yield! FieldsBuilderWriter.writeFieldMethodsForQueryBuilder type' context unionsBuilder.UnionFieldBuilders builderName genericTypeName

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
                        printf $"mapping querybuilder for operation {objDef.Name}"
                        yield! tryMapQueryBuilder node
                | _ ->
                    yield! tryMapQueryBuilder node
        }
