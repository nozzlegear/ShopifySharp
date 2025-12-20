namespace ShopifySharp.GraphQL.Parser

open System.Threading.Tasks
open GraphQLParser.AST
open ShopifySharp.GraphQL.Parser
open ShopifySharp.GraphQL.Parser.PipeWriter
open Utils

module rec QueryBuilderWriter =
    let [<Literal>] private QueryRootObjectName = "QueryRoot"
    let [<Literal>] private MutationRootObjectName = "Mutation"

    let private canAddFields = function
        | VisitedTypes.Class _ -> true
        | VisitedTypes.Interface _ -> true
        | VisitedTypes.Enum _ -> false
        | VisitedTypes.InputObject _ -> true
        | VisitedTypes.UnionType _ -> false
        | VisitedTypes.Operation operation when operation.ReturnType.IsFieldType -> true
        | VisitedTypes.Operation _ -> false

    let private canAddArguments (type': VisitedTypes) =
        type'.IsOperation

    // TODO: add unionsbuilder here

    let private writeQueryBuilderConstructor (pascalClassName: string)
                                             (isOperation: bool)
                                             (type': VisitedTypes)
                                             (context: IParsedContext)
                                             writer
                                             : ValueTask =
        pipeWriter writer {
            let camelTypeName = toCasing Camel type'.Name

            let genericType =
                match type' with
                | VisitedTypes.Interface interface' ->
                    interface'.DotnetName
                | VisitedTypes.Operation operation ->
                    match operation.ReturnType with
                    | ReturnType.VisitedType (VisitedTypes.Interface interface') ->
                        interface'.DotnetName
                    | ReturnType.VisitedType visitedTypes ->
                        visitedTypes.Name
                    | ReturnType.FieldType fieldType ->
                        // Use the wrapper function to ensure primitives are wrapped in GraphQLValue<T> or GraphQLCollection<T>
                        AstNodeMapper.mapFieldTypeToStringWithPrimitiveWrapper context.AssumeNullability fieldType
                | x -> x.Name

            let qualifiedGenericType = qualifiedPascalTypeName genericType

            do! $"public class {pascalClassName}(): GraphQueryBuilder<{qualifiedGenericType}>(\"{camelTypeName}\")"

            if isOperation then
                do! ", IGraphOperationQueryBuilder"

            do! NewLine
        }

    let private writeSubQueryBuilderProperties pascalClassName context writer: ValueTask =
        pipeWriter writer {
            do! Indented + $$"""public {{pascalClassName}}QueryArgumentsBuilder Arguments { get; }"""
            do! NewLine
            do! Indented + $$"""public {{pascalClassName}}QueryFieldsBuilder Fields { get; }"""
            do! NewLine
            do! Indented + $$"""public {{pascalClassName}}QueryUnionsBuilder Unions { get; }"""
            do! NewLine
        }

    let writeOperationTypeProperty (operationType: OperationType) (_: IParsedContext) writer: ValueTask =
        pipeWriter writer {
            do! Indented + "public OperationType OperationType { get; } = "
            match operationType with
            | OperationType.Query -> do! "OperationType.Query;"
            | OperationType.Mutation -> do! "OperationType.Mutation;"
            | value -> failwith $"Operation type \"{value}\" is not supported."
            do! NewLine
        }

    let writeQueryBuilder context (type': VisitedTypes) (operationType: OperationType option) writer: ValueTask =
        if type'.IsEnum || type'.IsInputObject then
            failwithf $"The {type'.GetType().Name} type is not supported."

        let fieldsBuilder = FieldsBuilderWriter(type', context)
        let argumentsBuilder = ArgumentsBuilderWriter(type', context)

        pipeWriter writer {
            let pascalClassName = toCasing Pascal (type'.Name + "QueryBuilder")

            yield! writeDeprecationAttribute Outdented type'.Deprecation
            yield! writeQueryBuilderConstructor pascalClassName operationType.IsSome type' context
            do! "{"
            do! NewLine

            if operationType.IsSome then
                yield! writeOperationTypeProperty operationType.Value context

            yield! writeSubQueryBuilderProperties pascalClassName context

            // if canAddFields type' then
            //     yield! writeQueryBuilderAddFieldMethods pascalClassName type' context
            //
            // if canAddArguments type' then
            //     yield! writeQueryBuilderAddArgumentMethods pascalClassName type' context

            do! NewLine
            do! "}"
            do! NewLine

            yield! fieldsBuilder.WriteToPipewriter
            yield! argumentsBuilder.WriteToPipewriter
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
                | _ ->
                    match AstNodeMapper.tryMap context node with
                    | None ->
                        printfn $"No mapping for type %A{node.GetType()}"
                    | Some (VisitedTypes.InputObject _)
                    | Some (VisitedTypes.Enum _) ->
                        // InputObjects and Enums do not need a QueryBuilder and are not supported
                        ()
                    | Some mappedType ->
                        yield! writeQueryBuilder context mappedType None
        }
