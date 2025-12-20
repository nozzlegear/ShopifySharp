/// Original code from graphql-query-builder-dotnet by Charles de Vandière
/// Copyright (c) 2025 Charles de Vandière
/// Modifications copyright (c) 2025 Nozzlegear Software
/// Licensed under MIT License - see attributions.md
#nullable enable
using System;
using ShopifySharp.GraphQL;

namespace ShopifySharp.Infrastructure;

public abstract class GraphQueryBuilder<T>
    where T: IGraphQLObject
{
    protected string Name { get; init; }
    protected QueryOptions QueryOptions { get; init; }
    public IQuery<T> Query { get; init; }

    protected GraphQueryBuilder(string name, QueryOptions? queryOptions = null)
    {
        Name = name;
        QueryOptions = queryOptions ?? new QueryOptions();
        Query = new Query<T>(name, QueryOptions);
    }

    public string Build() => Query.Build();

    public void Alias(string alias) => Query.Alias(alias);
}
