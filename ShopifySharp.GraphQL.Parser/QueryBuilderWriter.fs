namespace ShopifySharp.GraphQL.Parser

open System.IO.Pipelines
open System.Threading.Tasks
open GraphQLParser.AST
open ShopifySharp.GraphQL.Parser.PipeWriter
open Utils

module rec QueryBuilderWriter =

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

    let writeUnionTypeMutationJoins (pascalParentClassName: string) (unionCaseName: string) (_: IParsedContext) writer: ValueTask =
        pipeWriter writer {
            let pascalUnionCaseName = toCasing Pascal unionCaseName
            let camelUnionCaseName = toCasing Camel unionCaseName
            let unionCaseQueryBuilderName = $"{pascalUnionCaseName}QueryBuilder"

            do! Indented + $"public {pascalParentClassName} AddUnion{pascalUnionCaseName}(Func<{unionCaseQueryBuilderName}, {unionCaseQueryBuilderName}> build)"
            do! NewLine
            do! Indented + "{"
            do! NewLine
            do! DoubleIndented + $"AddUnion<{pascalUnionCaseName}>(\"{camelUnionCaseName}\", build);"
            do! NewLine
            do! DoubleIndented + "return this;"
            do! NewLine
            do! Indented + "}"
            do! NewLine
        }

    let writeQueryBuilderAddFieldMethods (pascalClassName: string) (type': VisitedTypes) (context: IParsedContext) writer: ValueTask =
        let writeField (fieldName: string) fieldDeprecationWarning: ValueTask =
            let pascalFieldName = toCasing Pascal fieldName
            let camelFieldName = toCasing Camel fieldName

            pipeWriter writer {
                yield! writeDeprecationAttribute Indented fieldDeprecationWarning
                do! Indented + $"public {pascalClassName} AddField{pascalFieldName}()"
                do! NewLine
                do! DoubleIndented + "{"
                do! NewLine
                // TODO: check if field.Type is a union type – if so, use AddUnion<TUnion>?
                if context.TypeIsKnownUnionCase fieldName then
                    do! DoubleIndented + $"Add{pascalClassName}()"
                else
                    do! DoubleIndented + $"AddField(\"{camelFieldName}\");"
                do! NewLine
                do! TripleIndented + "return this;"
                do! NewLine
                do! DoubleIndented + "}"
                do! NewLine
                // TODO: add the Func overload
            }

        let writeAddValue (_: FieldType): ValueTask =
            pipeWriter writer {
                do! Indented + $"public {pascalClassName} AddValue()"
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
                        yield! writeUnionTypeMutationJoins pascalClassName unionCase.Name context
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
                        do! writeField field.Name field.Deprecation
            }

        pipeWriter writer {
            match type' with
            | VisitedTypes.Operation operation ->
                match operation.ReturnType with
                | ReturnType.FieldType (FieldType.ValueType (FieldValueType.GraphObjectType graphObjectTypeName)) ->
                    if context.TypeIsKnownUnionCase graphObjectTypeName || context.IsNamedType (NamedType.UnionType graphObjectTypeName) then
                        yield! writeUnionTypeMutationJoins pascalClassName graphObjectTypeName context
                    else
                        do! writeField graphObjectTypeName None
                | ReturnType.FieldType fieldType ->
                    do! writeAddValue fieldType
                | ReturnType.VisitedType visitedTypes ->
                    do! writeForVisitedType visitedTypes
            | visitedType ->
                do! writeForVisitedType visitedType
        }

    let writeQueryBuilderAddArgumentMethods (pascalClassName: string) (type': VisitedTypes) (context: IParsedContext) writer: ValueTask =
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
                    AstNodeMapper.mapFieldTypeToString context.IsNamedType context.AssumeNullability argument.ValueType FieldTypeCollectionHandling.KeepCollection
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

    let writeQueryBuilderConstructor (pascalClassName: string) (type': VisitedTypes) (context: IParsedContext) writer: ValueTask =
        pipeWriter writer {
            let camelTypeName = toCasing Camel type'.Name

            let genericType =
                match type' with
                | VisitedTypes.Operation operation ->
                    match operation.ReturnType with
                    | ReturnType.VisitedType visitedTypes ->
                        visitedTypes.Name
                    | ReturnType.FieldType fieldType ->
                        AstNodeMapper.mapFieldTypeToString context.IsNamedType context.AssumeNullability fieldType FieldTypeCollectionHandling.KeepCollection
                | x -> x.Name

            // Fully qualify class names that might collide with System types
            let qualifiedGenericType =
                let pascalGenericType = toCasing Pascal genericType
                // The type name should already have the "I" prefix if it's an interface
                // (it comes from VisitedTypes.Name which includes the prefix)
                match pascalGenericType with
                | "Attribute" -> "ShopifySharp.GraphQL.Attribute"
                | _ -> pascalGenericType

            // TODO: this may not always be a query, it may also be a mutation (or even a subselection in the case of nested objects)
            do! $"public class {pascalClassName}(): GraphQueryBuilder<{qualifiedGenericType}>(\"query {camelTypeName}\")"
            do! NewLine
        }

    let writeQueryBuilder (type': VisitedTypes) (context: IParsedContext) writer: ValueTask =
        if type'.IsEnum || type'.IsInputObject then
            failwithf $"The {type'.GetType().Name} type is not supported."

        pipeWriter writer {
            let pascalClassName = toCasing Pascal (type'.Name + "QueryBuilder")

            yield! writeDeprecationAttribute Outdented type'.Deprecation
            yield! writeQueryBuilderConstructor pascalClassName type' context
            do! "{"
            do! NewLine

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
            do! "using ShopifySharp.Credentials;"
            do! NewLine
            do! "using ShopifySharp.GraphQL;"
            do! NewLine
            do! "using ShopifySharp.Infrastructure;"
            do! NewLine
            do! "using ShopifySharp.Infrastructure.Serialization.Json;"
            do! NewLine
        }

    let private writeServicesToPipe (context: IParsedContext) writer: ValueTask =
        pipeWriter writer {
            // Always write the namespace and usings at the very top of the document
            yield! writeNamespaceAndUsings

            for node in context.Document.Definitions do
                match node with
                | :? GraphQLObjectTypeDefinition as objDef when
                    objDef.Name.StringValue = "QueryRoot" || objDef.Name.StringValue = "Mutation" ->

                    // Each field in this object is an operation and should have a QueryBuilder
                    for field in objDef.Fields do
                        let operation = AstNodeMapper.mapRootFieldDefinition field context
                        yield! writeQueryBuilder (VisitedTypes.Operation operation) context
                | _ ->
                    match AstNodeMapper.tryMap context node with
                    | None ->
                        printfn $"No mapping for type %A{node.GetType()}"
                    | Some (VisitedTypes.InputObject _)
                    | Some (VisitedTypes.Enum _) ->
                        // InputObjects and Enums do not need a QueryBuilder and are not supported
                        ()
                    | Some mappedType ->
                        yield! writeQueryBuilder mappedType context
        }

    let writeServicesToFileSystem(destination: FileSystemDestination) (context: ParserContext): ValueTask =
        let cancellationToken = context.CancellationToken

        ValueTask(task {
            let pipe = Pipe(PipeOptions())
            let readTask = (readPipe pipe.Reader cancellationToken).ConfigureAwait(false)

            do! writeServicesToPipe context pipe.Writer
            do! pipe.Writer.CompleteAsync().ConfigureAwait(false);

            let! csharpCode = readTask
            do! (FileSystem.writeCsharpCodeToFileSystem destination csharpCode cancellationToken).ConfigureAwait(false)
        })
