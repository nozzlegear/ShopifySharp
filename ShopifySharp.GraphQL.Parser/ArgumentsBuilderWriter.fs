namespace ShopifySharp.GraphQL.Parser

open System.Threading.Tasks
open ShopifySharp.GraphQL.Parser.PipeWriter
open ShopifySharp.GraphQL.Parser.Utils

type ArgumentsBuilderWriter(type': VisitedTypes, context: IParsedContext) =
    let pascalClassName = toBuilderName (ArgumentBuilder type'.Name)
    let genericTypeName =
        toGenericType type' context.AssumeNullability
        |> qualifiedPascalTypeName
    let queryType = $$"""IQuery<{{genericTypeName}}>"""

    let writeAddArgumentMethods writer: ValueTask =
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
                do! TripleIndented + $$"""Query = base.Query.AddArgument("{{argument.Name}}", {{camelArgumentName}});"""
                do! NewLine
                do! TripleIndented + "return this;"
                do! NewLine
                do! DoubleIndented + "}"
                do! NewLine
        }

    let writeConstructor writer: ValueTask =
        pipeWriter writer {
            do! Indented + $$"""public {{pascalClassName}}({{queryType}} query) : base(query)"""
            do! NewLine
            do! Indented + "{"
            do! NewLine
            do! Indented + "}"
            do! NewLine
        }

    static member CanAddArguments (type': VisitedTypes) =
        match type' with
        | VisitedTypes.Class _ -> false
        | Interface _ -> false
        | InputObject _-> false
        | UnionType _-> false
        | Enum _ -> false
        | Operation operation ->
            // Only generate ArgumentsBuilder if the operation actually has arguments
            operation.Arguments.Length > 0

    member _.WriteToPipewriter writer: ValueTask =
        if not (ArgumentsBuilderWriter.CanAddArguments type') then
            ValueTask.CompletedTask
        else
            pipeWriter writer {
                do! $$"""public sealed class {{pascalClassName}} : ArgumentsBuilderBase<{{genericTypeName}}>"""
                do! NewLine
                do! "{"
                do! NewLine
                yield! writeConstructor
                do! NewLine + NewLine
                yield! writeAddArgumentMethods
                do! "}"
            }
