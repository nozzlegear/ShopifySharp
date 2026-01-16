/// Original code from graphql-query-builder-dotnet by Charles de Vandière
/// Copyright (c) 2025 Charles de Vandière
/// Modifications copyright (c) 2025 Nozzlegear Software
/// Licensed under MIT License - see attributions.md
#nullable enable
using ShopifySharp.GraphQL;

namespace ShopifySharp.Infrastructure;

public abstract class GraphQueryBuilder<T>
    where T: IGraphQLObject
{
    protected IQuery<T> Query { get; }

    public string Name => Query.Name;
    // public QueryOptions Options => Query.Options;
    // public string? AliasName => Query.AliasName;

    protected GraphQueryBuilder(string name, QueryOptions? queryOptions = null)
    {
        Query = new Query<T>(name, queryOptions ?? new QueryOptions());
    }

    protected GraphQueryBuilder(IQuery<T> query)
    {
        Query = query;
    }

    public string Build()
    {
        var queryContent = Query.Build();

        // If this is a top-level operation builder, wrap it with the operation type
        // ReSharper disable once SuspiciousTypeConversion.Global
        if (this is IGraphOperationQueryBuilder operationBuilder)
        {
            var operationType = operationBuilder.OperationType == OperationType.Query
                ? "query"
                : "mutation";
            return $"{operationType} {{ {queryContent} }}";
        }

        // Nested builders or non-operation builders return unwrapped content
        return queryContent;
    }

    public void WithAlias(string alias) => Query.WithAlias(alias);
}
