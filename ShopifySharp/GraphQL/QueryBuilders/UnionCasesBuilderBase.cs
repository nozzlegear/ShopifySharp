/// Original code from graphql-query-builder-dotnet by Charles de Vandière
/// Copyright (c) 2025 Charles de Vandière
/// Modifications copyright (c) 2025 Nozzlegear Software
/// Licensed under MIT License - see attributions.md
#nullable enable
using JetBrains.Annotations;

namespace ShopifySharp.GraphQL.QueryBuilders;

[PublicAPI]
public abstract class UnionCasesBuilderBase<TSource, TSelf>(IQuery<TSource> query): IUnionCasesBuilder<TSelf>
    where TSelf : IUnionCasesBuilder<TSelf>
{
    protected readonly IQuery<TSource> InnerQuery = query;

    protected abstract TSelf Self { get; }

    public TSelf AddUnionCase<TUnionCase>(IQuery<TUnionCase> unionCaseQuery) where TUnionCase : class?
    {
        InnerQuery.AddUnionCase(unionCaseQuery);
        return Self;
    }
}
