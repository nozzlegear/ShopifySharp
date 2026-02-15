/// Original code from graphql-query-builder-dotnet by Charles de Vandière
/// Copyright (c) 2025 Charles de Vandière
/// Modifications copyright (c) 2025 Nozzlegear Software
/// Licensed under MIT License - see attributions.md
#nullable enable
using JetBrains.Annotations;
using ShopifySharp.GraphQL;

namespace ShopifySharp.GraphQL.QueryBuilders;

[PublicAPI]
public abstract class QueryBuilderBase<T, TSelf> : IQuery
    where T: IGraphQLObject
    where TSelf : QueryBuilderBase<T, TSelf>
{
    public string QueryName => InnerQuery.QueryName;
    public string? AliasName => InnerQuery.AliasName;

    protected IQuery<T> InnerQuery { get; }

    protected abstract TSelf Self { get; }

    protected QueryBuilderBase(IQuery<T> query)
    {
        InnerQuery = query;
    }

    public string Build()
    {
        var queryContent = InnerQuery.Build();

        // If this is a top-level operation builder, wrap it with the operation type
        // ReSharper disable once SuspiciousTypeConversion.Global
        if (this is IGraphOperationQueryBuilder<T> operationBuilder)
        {
            var operationType = operationBuilder.OperationType == OperationType.Query
                ? "query"
                : "mutation";
            return $"{operationType} {{ {queryContent} }}";
        }

        // Nested builders or non-operation builders return unwrapped content
        return queryContent;
    }

    public TSelf SetAlias(string alias)
    {
        InnerQuery.SetAlias(alias);
        return Self;
    }
}
