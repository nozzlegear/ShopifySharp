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
) as self =
    let builderClassName = toBuilderName (UnionCasesBuilder parentType.Name)
    let genericTypeName =
        toGenericType parentType context.AssumeNullability
        |> qualifiedPascalTypeName

    let writeOnUnionCaseMethod (unionCaseName: string) writer: ValueTask =
        let pascalUnionCaseName = toCasing Pascal unionCaseName
        let unionCaseQueryBuilderName = $"{pascalUnionCaseName}QueryBuilder"

        pipeWriter writer {
            do! Indented + $"public {builderClassName} On{pascalUnionCaseName}(Action<{unionCaseQueryBuilderName}> build)"
            do! NewLine
            do! Indented + "{"
            do! NewLine
            do! DoubleIndented + $$"""var queryBuilder = new {{unionCaseQueryBuilderName}}("... on {{pascalUnionCaseName}}");"""
            do! NewLine
            do! DoubleIndented + "build.Invoke(queryBuilder);"
            do! NewLine
            do! DoubleIndented + $$"""base.Query.AddField(queryBuilder.Query);"""
            do! NewLine
            do! DoubleIndented + "return this;"
            do! NewLine
            do! Indented + "}"
            do! NewLine
        }

    member _.BuilderClassName = builderClassName
    member _.CamelFieldName = toCasing Camel fieldName
    member _.PascalFieldName = toCasing Pascal fieldName
    member _.GenericTypeName = genericTypeName
    member _.DeprecationWarning = deprecation

    member _.WriteToPipewriter writer: ValueTask =
        pipeWriter writer {
            do! $"public sealed class {builderClassName} : UnionCaseBuilderBase<{genericTypeName}>"
            do! NewLine
            do! "{"
            do! NewLine
            do! Indented + $$"""public {{builderClassName}}(string fieldName = "{{self.CamelFieldName}}") : this(new Query<{{genericTypeName}}>(fieldName))"""
            do! NewLine
            do! Indented + "{}"
            do! NewLine + NewLine
            do! Indented + $$"""public {{builderClassName}}(IQuery<{{genericTypeName}}> query) : base(query)"""
            do! NewLine
            do! Indented + "{}"
            do! NewLine + NewLine

            for unionCaseName in unionCaseNames do
                yield! writeOnUnionCaseMethod unionCaseName
                do! NewLine

            do! "}"
        }
