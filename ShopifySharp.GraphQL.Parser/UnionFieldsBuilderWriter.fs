namespace ShopifySharp.GraphQL.Parser

open System.Threading.Tasks
open ShopifySharp.GraphQL.Parser.PipeWriter
open ShopifySharp.GraphQL.Parser.Utils

type UnionCasesBuilderWriter(
    parentType: VisitedTypes,
    fieldName: string,
    unionCaseNames: string array,
    deprecation: string option,
    context: IParsedContext
) =
    let builderClassName = toBuilderName (UnionCasesBuilder fieldName)

    let writeOnUnionCaseMethod (unionCaseName: string) writer: ValueTask =
        let pascalUnionCaseName = toCasing Pascal unionCaseName
        let unionCaseQueryBuilderName = $"{pascalUnionCaseName}QueryBuilder"

        pipeWriter writer {
            do! Indented + $"public {builderClassName} On{pascalUnionCaseName}(Action<{unionCaseQueryBuilderName}> build)"
            do! NewLine
            do! Indented + "{"
            do! NewLine
            do! DoubleIndented + $"var queryBuilder = new {unionCaseQueryBuilderName}(\"... on {pascalUnionCaseName}\");"
            do! NewLine
            do! DoubleIndented + "build(queryBuilder);"
            do! NewLine
            do! DoubleIndented + $"_query.AddField<{pascalUnionCaseName}>(queryBuilder.Query);"
            do! NewLine
            do! DoubleIndented + "return this;"
            do! NewLine
            do! Indented + "}"
            do! NewLine
        }

    member _.BuilderClassName = builderClassName
    member _.CamelFieldName = toCasing Camel fieldName
    member _.PascalFieldName = toCasing Pascal fieldName
    member _.DeprecationWarning = deprecation

    member _.WriteToPipewriter writer: ValueTask =
        pipeWriter writer {
            do! $"public sealed class {builderClassName}"
            do! NewLine
            do! "{"
            do! NewLine
            do! Indented + "private readonly IQuery<object> _query;"
            do! NewLine + NewLine
            do! Indented + $"public {builderClassName}(string fieldName)"
            do! NewLine
            do! Indented + "{"
            do! NewLine
            do! DoubleIndented + "_query = new Query<object>(fieldName);"
            do! NewLine
            do! DoubleIndented + "_query.AddField(\"__typename\");"
            do! NewLine
            do! Indented + "}"
            do! NewLine + NewLine

            for unionCaseName in unionCaseNames do
                yield! writeOnUnionCaseMethod unionCaseName
                do! NewLine

            do! Indented + "public IQuery<object> Query => _query;"
            do! NewLine
            do! "}"
        }
