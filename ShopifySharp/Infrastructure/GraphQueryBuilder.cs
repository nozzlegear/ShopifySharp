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
    protected string Name { get; init; }
    protected QueryOptions QueryOptions { get; init; }
    protected IQuery<T> Query { get; init; }

    protected GraphQueryBuilder(string name, QueryOptions? queryOptions = null)
    {
        Name = name;
        QueryOptions = queryOptions ?? new QueryOptions();
        Query = new Query<T>(name, QueryOptions);
    }

    protected GraphQueryBuilder(IQuery<T> query)
    {
        Name = query.Name;
        QueryOptions = query.Options;
        Query = query;
    }

    /// <summary>
    /// Gets the underlying query. This method allows generated code to access the query
    /// while preventing name collisions with GraphQL fields named "query".
    /// </summary>
    public IQuery<T> GetQuery() => Query;

    public string Build()
    {
        var queryContent = Query.Build();

        // If this is a top-level operation builder, wrap it with the operation type
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

    public void Alias(string alias) => Query.Alias(alias);
}
