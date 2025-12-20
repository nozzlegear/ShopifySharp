namespace ShopifySharp.GraphQL.Parser

open System.Threading.Tasks
open ShopifySharp.GraphQL.Parser.PipeWriter
open ShopifySharp.GraphQL.Parser.Utils

type UnionsBuilderWriter(context: IParsedContext) =
    let writeUnionCaseJoin (pascalParentClassName: string) (unionCaseName: string) (fieldName: string) (_: IParsedContext) writer: ValueTask =
        pipeWriter writer {
            let pascalUnionCaseName = toCasing Pascal unionCaseName
            let pascalFieldName = toCasing Pascal fieldName
            let camelFieldName = toCasing Camel fieldName
            let unionCaseQueryBuilderName = $"{pascalUnionCaseName}QueryBuilder"

            do! Indented + $"public {pascalParentClassName} AddUnionCase{pascalFieldName}(Func<{unionCaseQueryBuilderName}, {unionCaseQueryBuilderName}> build)"
            do! NewLine
            do! Indented + "{"
            do! NewLine
            do! DoubleIndented + $"AddUnionCase<{pascalUnionCaseName}, {unionCaseQueryBuilderName}>(\"{camelFieldName}\", \"{pascalUnionCaseName}\", build);"
            do! NewLine
            do! DoubleIndented + "return this;"
            do! NewLine
            do! Indented + "}"
            do! NewLine
        }

    member _.WriteToPipewriter (type': VisitedTypes) writer: ValueTask =
        failwith "not implemented"
