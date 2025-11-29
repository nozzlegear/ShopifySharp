namespace ShopifySharp.GraphQL.Parser

open System.Threading.Tasks
open GraphQLParser.AST
open ShopifySharp.GraphQL.Parser
open ShopifySharp.GraphQL.Parser.PipeWriter
open Utils

module rec QueryBuilderWriter =
    let [<Literal>] private QueryRootObjectName = "QueryRoot"
    let [<Literal>] private MutationRootObjectName = "Mutation"

    // Fully qualify class names which might collide with System types
    let qualifiedPascalTypeName  className =
        match toCasing Pascal className with
        | "Attribute" -> "ShopifySharp.GraphQL.Attribute"
        | pascalGenericType -> pascalGenericType

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

    let private writeUnionCaseJoin (pascalParentClassName: string) (unionCaseName: string) (fieldName: string) (_: IParsedContext) writer: ValueTask =
        pipeWriter writer {
            let pascalUnionCaseName = toCasing Pascal unionCaseName
            let pascalFieldName = toCasing Pascal fieldName
            let camelFieldName = toCasing Camel fieldName
            let unionCaseQueryBuilderName = $"{pascalUnionCaseName}QueryBuilder"

            do! Indented + $"public {pascalParentClassName} AddUnionCase{pascalFieldName}(Func<{unionCaseQueryBuilderName}, {unionCaseQueryBuilderName}> build)"
            do! NewLine
            do! Indented + "{"
            do! NewLine
            do! DoubleIndented + $"AddUnion<{pascalUnionCaseName}, {unionCaseQueryBuilderName}>(\"{camelFieldName}\", build);"
            do! NewLine
            do! DoubleIndented + "return this;"
            do! NewLine
            do! Indented + "}"
            do! NewLine
        }

    let private writeQueryBuilderAddFieldMethod (pascalClassName: string)
                                                (fieldName: string)
                                                (fieldType: FieldType)
                                                (deprecationWarning: string option)
                                                (context: IParsedContext)
                                                writer =
        let pascalFieldName = toCasing Pascal fieldName
        let camelFieldName = toCasing Camel fieldName

        pipeWriter writer {
            match AstNodeMapper.unwrapFieldType fieldType with
            | FieldValueType.GraphObjectType (NamedType.UnionType (_, unionCaseNames)) ->
                // yield! writeUnionCaseJoin pascalClassName unionTypeName fieldName context
                for unionCaseName in unionCaseNames do
                    yield! writeUnionCaseJoin pascalClassName unionCaseName fieldName context
            | FieldValueType.GraphObjectType (NamedType.Class graphObjectTypeName as namedType)
            | FieldValueType.GraphObjectType (NamedType.Interface graphObjectTypeName as namedType)
            | FieldValueType.GraphObjectType (NamedType.InputObject graphObjectTypeName as namedType) ->
                let pascalTypeName =
                    if namedType.IsInterface
                    then toCasing Pascal (mapStrToInterfaceName graphObjectTypeName)
                    else qualifiedPascalTypeName graphObjectTypeName
                let queryBuilderName = $"{toCasing Pascal graphObjectTypeName}QueryBuilder"

                // TODO: if this is a collection type (not fieldType.IsFieldValueType), use the AddField collection overload

                yield! writeDeprecationAttribute Indented None
                do! Indented + $"public {pascalClassName} AddField{pascalFieldName}(Func<{queryBuilderName}, {queryBuilderName}> build)"
                do! NewLine
                do! DoubleIndented + "{"
                do! NewLine
                do! TripleIndented + $"AddField<{pascalTypeName}, {queryBuilderName}>(\"{camelFieldName}\", build);"
                do! NewLine
                do! TripleIndented + "return this;"
                do! NewLine
                do! DoubleIndented + "}"
                do! NewLine
            | _ ->
                // TODO: if this is a collection type (not fieldType.IsFieldValueType), use the AddField collection overload

                yield! writeDeprecationAttribute Indented deprecationWarning
                do! Indented + $"public {pascalClassName} AddField{pascalFieldName}()"
                do! NewLine
                do! DoubleIndented + "{"
                do! NewLine
                do! DoubleIndented + $"AddField(\"{camelFieldName}\");"
                do! NewLine
                do! TripleIndented + "return this;"
                do! NewLine
                do! DoubleIndented + "}"
                do! NewLine
        }

    let private writeQueryBuilderAddFieldMethods (pascalClassName: string) (type': VisitedTypes) (context: IParsedContext) writer: ValueTask =
        let writeAddReturnValue (_: FieldType): ValueTask =
            pipeWriter writer {
                do! Indented + $"public {pascalClassName} AddReturnValue()"
                do! NewLine
                do! DoubleIndented + "{"
                do! NewLine
                do! DoubleIndented + "// This method is a no-op – the value will be included automatically by virtue of this QueryBuilder being including"
                do! NewLine
                do! TripleIndented + "return this;"
                do! NewLine
                do! DoubleIndented + "}"
                do! NewLine
            }

        let writeForVisitedType (visitedType: VisitedTypes): ValueTask =
            pipeWriter writer {
                match visitedType with
                | VisitedTypes.UnionType unionType ->
                    for unionCase in unionType.Cases do
                        yield! writeUnionCaseJoin pascalClassName unionCase.Name unionCase.Name context
                        //yield! writeUnionTypeJoin pascalClassName unionCase.Name context
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
                        yield! writeQueryBuilderAddFieldMethod pascalClassName field.Name field.ValueType field.Deprecation context
            }

        pipeWriter writer {
            match type' with
            | VisitedTypes.Operation operation ->
                match operation.ReturnType with
                | ReturnType.FieldType (FieldType.ValueType (FieldValueType.GraphObjectType graphValueType)) ->
                    let fieldType = FieldType.ValueType (FieldValueType.GraphObjectType graphValueType)
                    let fieldName = graphValueType.ToString()
                    yield! writeQueryBuilderAddFieldMethod pascalClassName fieldName fieldType None context
                | ReturnType.FieldType fieldType ->
                    do! writeAddReturnValue fieldType
                | ReturnType.VisitedType visitedTypes ->
                    do! writeForVisitedType visitedTypes
            | visitedType ->
                do! writeForVisitedType visitedType
        }

    let private writeQueryBuilderAddArgumentMethods (pascalClassName: string) (type': VisitedTypes) (context: IParsedContext) writer: ValueTask =
        let arguments =
            match type' with
            | Operation operation -> operation.Arguments
            | _ -> failwith $"Type {type'.Name} does not support adding QueryBuilder arguments."

        pipeWriter writer {
            let sanitizeArgumentName casing argName =
                sanitizeFieldOrOperationName (NamedType.Class pascalClassName) argName
                |> toCasing casing

            for argument in arguments do
                let valueType =
                    AstNodeMapper.mapFieldTypeToString context.AssumeNullability argument.ValueType FieldTypeCollectionHandling.KeepCollection
                let camelArgumentName =
                    sanitizeArgumentName Camel argument.Name
                let pascalArgumentName =
                    toCasing Pascal argument.Name

                yield! writeDeprecationAttribute Indented argument.Deprecation
                do! $"public {pascalClassName} AddArgument{pascalArgumentName}({valueType} {camelArgumentName})"
                do! NewLine
                do! DoubleIndented + "{"
                do! NewLine
                do! DoubleIndented + $"AddArgument(\"{argument.Name}\", {camelArgumentName});"
                do! NewLine
                do! TripleIndented + "return this;"
                do! NewLine
                do! DoubleIndented + "}"
                do! NewLine
        }

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

    let writeOperationTypeProperty (operationType: OperationType) (_: IParsedContext) writer: ValueTask =
        pipeWriter writer {
            do! "public OperationType OperationType { get; } = "
            match operationType with
            | OperationType.Query -> do! "OperationType.Query;"
            | OperationType.Mutation -> do! "OperationType.Mutation;"
            | value -> failwith $"Operation type \"{value}\" is not supported."
            do! NewLine
        }

    let writeQueryBuilder context (type': VisitedTypes) (operationType: OperationType option) writer: ValueTask =
        if type'.IsEnum || type'.IsInputObject then
            failwithf $"The {type'.GetType().Name} type is not supported."

        pipeWriter writer {
            let pascalClassName = toCasing Pascal (type'.Name + "QueryBuilder")

            yield! writeDeprecationAttribute Outdented type'.Deprecation
            yield! writeQueryBuilderConstructor pascalClassName operationType.IsSome type' context
            do! "{"
            do! NewLine

            if operationType.IsSome then
                yield! writeOperationTypeProperty operationType.Value context

            if canAddFields type' then
                yield! writeQueryBuilderAddFieldMethods pascalClassName type' context

            if canAddArguments type' then
                yield! writeQueryBuilderAddArgumentMethods pascalClassName type' context

            do! NewLine
            do! "}"
            do! NewLine
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
