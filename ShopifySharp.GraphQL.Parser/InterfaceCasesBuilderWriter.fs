namespace ShopifySharp.GraphQL.Parser

open System.Threading.Tasks
open ShopifySharp.GraphQL.Parser.PipeWriter
open ShopifySharp.GraphQL.Parser.Utils

type InterfaceCasesBuilderWriter(
    parentType: Interface,
    fieldName: string,
    concreteCaseNames: string array,
    deprecation: string option,
    context: IParsedContext
) as self =
    let builderClassName = toBuilderName (InterfaceCasesBuilder parentType.Name)
    let genericTypeName =
        toGenericType (Interface parentType) context.AssumeNullability
        |> qualifiedPascalTypeName

    let writeOnConcreteCaseMethod (concreteCaseName: string) writer: ValueTask =
        let pascalConcreteCaseName = toCasing Pascal concreteCaseName
        let concreteCaseQueryBuilderName = qualifiedBuilderTypeName (QueryBuilder concreteCaseName)

        pipeWriter writer {
            do! Indented + $"public {builderClassName} On{pascalConcreteCaseName}(Action<{concreteCaseQueryBuilderName}> build)"
            do! NewLine
            do! Indented + "{"
            do! NewLine
            do! DoubleIndented + $$"""var query = new Query<{{pascalConcreteCaseName}}>("... on {{pascalConcreteCaseName}}");"""
            do! NewLine
            do! DoubleIndented + $$"""var queryBuilder = new {{concreteCaseQueryBuilderName}}(query);"""
            do! NewLine + NewLine
            do! DoubleIndented + "build.Invoke(queryBuilder);"
            do! NewLine
            do! DoubleIndented + $$"""base.InnerQuery.AddField(query);"""
            do! NewLine + NewLine
            do! DoubleIndented + "return this;"
            do! NewLine
            do! Indented + "}"
            do! NewLine
        }

    let writeConstructor writer: ValueTask =
        pipeWriter writer {
            do! Indented + $$"""public {{builderClassName}}(string fieldName = "{{self.CamelFieldName}}") : this(new Query<{{genericTypeName}}>(fieldName))"""
            do! NewLine
            do! Indented + "{}"
            do! NewLine + NewLine
            do! Indented + $$"""public {{builderClassName}}(IQuery<{{genericTypeName}}> query) : base(query)"""
            do! NewLine
            do! Indented + "{}"
            do! NewLine + NewLine
        }

    let writeOverrideProperties writer: ValueTask =
        pipeWriter writer {
            do! Indented + $"protected override {builderClassName} Self => this;"
            do! NewLine + NewLine
        }

    member _.BuilderClassName = builderClassName
    member _.CamelFieldName = toCasing Camel fieldName
    member _.PascalFieldName = toCasing Pascal fieldName
    member _.GenericTypeName = genericTypeName
    member _.DeprecationWarning = deprecation

    member _.WriteToPipewriter writer: ValueTask =
        pipeWriter writer {
            do! $"public sealed class {builderClassName} : InterfaceCasesBuilderBase<{genericTypeName}, {builderClassName}>"
            do! NewLine
            do! "{"
            do! NewLine

            yield! writeOverrideProperties
            yield! writeConstructor

            for concreteCaseName in concreteCaseNames do
                yield! writeOnConcreteCaseMethod concreteCaseName
                do! NewLine

            do! "}"
        }

    static member WriteDirectConcreteCaseMethods (targetBuilderClassName: string) (concreteCaseNames: string array) writer: ValueTask =
        pipeWriter writer {
            for concreteCaseName in concreteCaseNames do
                let pascalConcreteCaseName = toCasing Pascal concreteCaseName
                let concreteCaseQueryBuilderName = qualifiedBuilderTypeName (QueryBuilder concreteCaseName)
                do! Indented + $$"""public {{targetBuilderClassName}} On{{pascalConcreteCaseName}}(Action<{{concreteCaseQueryBuilderName}}> build)"""
                do! NewLine
                do! Indented + "{"
                do! NewLine
                do! DoubleIndented + $$"""var query = new Query<{{pascalConcreteCaseName}}>("... on {{pascalConcreteCaseName}}");"""
                do! NewLine
                do! DoubleIndented + $$"""var queryBuilder = new {{concreteCaseQueryBuilderName}}(query);"""
                do! NewLine + NewLine
                do! DoubleIndented + "build.Invoke(queryBuilder);"
                do! NewLine
                do! DoubleIndented + "base.InnerQuery.AddInterfaceCase(query);"
                do! NewLine + NewLine
                do! DoubleIndented + "return this;"
                do! NewLine
                do! Indented + "}"
                do! NewLine + NewLine
        }
