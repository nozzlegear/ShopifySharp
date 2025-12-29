namespace ShopifySharp.GraphQL.Parser

open System.Threading.Tasks
open GraphQLParser.AST
open ShopifySharp.GraphQL.Parser
open ShopifySharp.GraphQL.Parser.PipeWriter
open Utils

module rec QueryBuilderWriter =
    let [<Literal>] private QueryRootObjectName = "QueryRoot"
    let [<Literal>] private MutationRootObjectName = "Mutation"

    let private canAddArguments (type': VisitedTypes) =
        type'.IsOperation

    let private writeClassNameAndInheritedType (isOperation: bool)
                                               (type': VisitedTypes)
                                               (context: IParsedContext)
                                               writer
                                               : ValueTask =
        let genericTypeName =
            toGenericType type' context.AssumeNullability
            |> qualifiedPascalTypeName

        pipeWriter writer {
            do! $"public class {toBuilderName (QueryBuilder type'.Name)}: GraphQueryBuilder<{genericTypeName}>"

            if isOperation then
                do! ", IGraphOperationQueryBuilder"

            do! NewLine
        }

    let private writeOperationTypeProperty (operationType: OperationType) (_: IParsedContext) writer: ValueTask =
        pipeWriter writer {
            do! Indented + "public OperationType OperationType { get; } = "
            match operationType with
            | OperationType.Query -> do! "OperationType.Query;"
            | OperationType.Mutation -> do! "OperationType.Mutation;"
            | value -> failwith $"Operation type \"{value}\" is not supported."
            do! NewLine
        }

    let private writeSubQueryBuilderProperties (type': VisitedTypes) (_: IParsedContext) writer: ValueTask =
        pipeWriter writer {
            if ArgumentsBuilderWriter.CanAddArguments type' then
                do! Indented + $$"""public {{ toBuilderName (QueryBuilderTypes.ArgumentBuilder type'.Name)}} Arguments { get; }"""
                do! NewLine
            if FieldsBuilderWriter.CanAddFields type' then
                do! Indented + $$"""public {{ toBuilderName (QueryBuilderTypes.FieldsBuilder type'.Name)}} Fields { get; }"""
                do! NewLine
            if UnionsBuilderWriter.CanAddUnions type' then
                do! Indented + $$"""public {{ toBuilderName (QueryBuilderTypes.UnionsBuilder type'.Name)}} Unions { get; }"""
                do! NewLine
        }

    let private writeConstructor (type': VisitedTypes) (context: IParsedContext) writer: ValueTask =
        let genericTypeName =
            toGenericType type' context.AssumeNullability
            |> qualifiedPascalTypeName
        let queryType =
            $$"""Query<ShopifySharp.GraphQL.{{genericTypeName}}>"""
        let defaultQueryName =
            match type' with
            | VisitedTypes.Operation operation -> operation.Name
            | _ -> type'.Name

        pipeWriter writer {
            do! Indented + $"""public {toBuilderName (QueryBuilder type'.Name)}(): this("{toCasing Camel defaultQueryName}")"""
            do! NewLine + "{}"
            do! NewLine + NewLine

            do! Indented + $"""public {toBuilderName (QueryBuilder type'.Name)}(string name): base(new {queryType}(name))"""
            do! NewLine + "{"

            if ArgumentsBuilderWriter.CanAddArguments type' then
                do! DoubleIndented + $$"""Arguments = new {{toBuilderName (ArgumentBuilder type'.Name)}}(base.Query);"""
                do! NewLine

            if FieldsBuilderWriter.CanAddFields type' then
                do! DoubleIndented + $$"""Fields = new {{toBuilderName (FieldsBuilder type'.Name)}}(Query);"""
                do! NewLine

            if UnionsBuilderWriter.CanAddUnions type' then
                do! DoubleIndented + $$"""Unions = new {{toBuilderName (UnionsBuilder type'.Name)}}(Query);"""
                do! NewLine

            do! NewLine + "}"
            do! NewLine
        }

    let writeQueryBuilder context (type': VisitedTypes) (operationType: OperationType option) writer: ValueTask =
        if type'.IsEnum || type'.IsInputObject then
            failwithf $"The {type'.GetType().Name} type is not supported."

        let fieldsBuilder = FieldsBuilderWriter(type', context)
        let argumentsBuilder = ArgumentsBuilderWriter(type', context)
        let unionsBuilder = UnionsBuilderWriter(type', context)

        pipeWriter writer {
            yield! writeDeprecationAttribute Outdented type'.Deprecation
            yield! writeClassNameAndInheritedType operationType.IsSome type' context
            do! "{"
            do! NewLine

            if operationType.IsSome then
                yield! writeOperationTypeProperty operationType.Value context

            yield! writeSubQueryBuilderProperties type' context
            yield! writeConstructor type' context

            do! "}"
            do! NewLine

            yield! fieldsBuilder.WriteToPipewriter
            yield! argumentsBuilder.WriteToPipewriter
            yield! unionsBuilder.WriteToPipewriter
        }

    let private writeNamespaceAndUsings writer: ValueTask =
        pipeWriter writer {
            do! "#nullable enable"
            do! NewLine
            do! "namespace ShopifySharp.Services.Generated;"
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
        }

    let writeQueryBuildersToPipe (context: ParserContext) writer: ValueTask =
        let parsedContext = context :> IParsedContext

        let tryMapQueryBuilder node =
            pipeWriter writer {
                match AstNodeMapper.tryMap context node with
                | None ->
                    printfn $"No mapping for type %A{node.GetType()}"
                | Some (VisitedTypes.InputObject _)
                | Some (VisitedTypes.Enum _) ->
                    // InputObjects and Enums do not need a QueryBuilder and are not supported
                    ()
                | Some mappedType ->
                    writeQueryBuilder context mappedType None
            }

        pipeWriter writer {
            // Always write the namespace and usings at the very top of the document
            yield! writeNamespaceAndUsings

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
                        yield! writeQueryBuilder context (VisitedTypes.Operation operation) (Some operationType)

                    if operationType = OperationType.Query then
                        do! tryMapQueryBuilder node
                | _ ->
                    do! tryMapQueryBuilder node
        }
