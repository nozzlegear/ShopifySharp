/// Original code from graphql-query-builder-dotnet by Charles de Vandière
/// Copyright (c) 2025 Charles de Vandière
/// Modifications copyright (c) 2025 Nozzlegear Software
/// Licensed under MIT License - see attributions.md
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
