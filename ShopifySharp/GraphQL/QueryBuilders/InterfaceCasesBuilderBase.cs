#nullable enable
using JetBrains.Annotations;

namespace ShopifySharp.GraphQL.QueryBuilders;

[PublicAPI]
public abstract class InterfaceCasesBuilderBase<TSource, TSelf>(IQuery<TSource> query): IInterfaceCasesBuilder<TSelf>
    where TSelf : IInterfaceCasesBuilder<TSelf>
{
    protected readonly IQuery<TSource> InnerQuery = query;

    protected abstract TSelf Self { get; }

    /// <inheritdoc />
    public TSelf AddInterfaceCase<TConcreteType>(IQuery<TConcreteType> concreteTypeQuery) where TConcreteType : class?
    {
        InnerQuery.AddUnionCase(concreteTypeQuery);
        return Self;
    }
}
