#nullable enable
using JetBrains.Annotations;

namespace ShopifySharp.Infrastructure;

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
