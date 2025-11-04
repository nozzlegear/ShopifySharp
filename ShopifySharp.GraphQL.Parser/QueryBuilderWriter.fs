namespace ShopifySharp.GraphQL.Parser

open System.Threading.Tasks
open ShopifySharp.GraphQL.Parser.PipeWriter
open Utils

module rec QueryBuilderWriter =

    type QueryBuilder<'t> = ShopifySharp.Infrastructure.Query<'t>

    let writeUnionTypeMutationJoins (pascalParentClassName: string) (unionCaseName: string) (context: IParsedContext) writer: ValueTask =
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

    let writeQueryBuilderAddFieldMethods (pascalClassName: string) (operation: QueryOrMutation) (context: IParsedContext) writer: ValueTask =
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
                    ()
                else
                    do! DoubleIndented + $"AddField(\"{camelFieldName}\");"
                do! NewLine
                do! TripleIndented + "return this;"
                do! NewLine
                do! DoubleIndented + "}"
                do! NewLine
                // TODO: add the Func overload
            }

        pipeWriter writer {
            match operation.ReturnType with
            | ReturnType.FieldType (FieldType.ValueType (FieldValueType.GraphObjectType graphObjectTypeName)) ->
                if context.TypeIsKnownUnionCase graphObjectTypeName || context.IsNamedType (NamedType.UnionType graphObjectTypeName) then
                    printfn "HONK"
                    yield! writeUnionTypeMutationJoins pascalClassName graphObjectTypeName context
                else
                    do! writeField graphObjectTypeName None
            | ReturnType.FieldType _ ->
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
            | ReturnType.VisitedType (VisitedTypes.UnionType unionType) ->
                for unionCase in unionType.Cases do
                    yield! writeUnionTypeMutationJoins pascalClassName unionCase.Name context
            | ReturnType.VisitedType visitedType ->
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

    let writeQueryBuilderAddArgumentMethods (pascalClassName: string) (operation: QueryOrMutation) (context: IParsedContext) writer: ValueTask =
        pipeWriter writer {
            let sanitizeArgumentName casing argName =
                sanitizeFieldOrOperationName (NamedType.Class pascalClassName) argName
                |> toCasing casing

            for argument in operation.Arguments do
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

    let writeQueryBuilderConstructor (pascalClassName: string) (returnType: ReturnType) (context: IParsedContext) writer: ValueTask =
        pipeWriter writer {
            let camelTypeName = toCasing Camel type'.Name
            let methodReturnType =
                match returnType with
                | ReturnType.VisitedType visitedTypes ->
                    visitedTypes.Name
                | ReturnType.FieldType fieldType ->
                    AstNodeMapper.mapFieldTypeToString context.IsNamedType context.AssumeNullability fieldType FieldTypeCollectionHandling.KeepCollection

            // Fully qualify class names that might collide with System types
            let qualifiedGenericType =
                let pascalGenericType = toCasing Pascal genericType
                match pascalGenericType with
                | "Attribute" -> "ShopifySharp.GraphQL.Attribute"
                | _ -> pascalGenericType

            // TODO: this may not always be a query, it may also be a mutation (or even a subselection in the case of nested objects)
            do! $"public class {pascalClassName}(): GraphQueryBuilder<{qualifiedGenericType}>(\"query {camelTypeName}\")"
            do! NewLine
        }

    let writeQueryBuilder (operation: QueryOrMutation) (context: IParsedContext) writer: ValueTask =
        // TODO: need to switch to iterating through all definitions in the document and creating a QueryBuilder for each
        //       type and operation.

        pipeWriter writer {
            let pascalClassName = toCasing Pascal (operation.Name + "QueryBuilder")

            yield! writeDeprecationAttribute Outdented operation.Deprecation
            yield! writeQueryBuilderConstructor pascalClassName operation.ReturnType context
            do! "{"
            do! NewLine
            yield! writeQueryBuilderAddFieldMethods pascalClassName operation context
            yield! writeQueryBuilderAddArgumentMethods pascalClassName operation context
            do! NewLine
            do! "}"
            do! NewLine
        }

