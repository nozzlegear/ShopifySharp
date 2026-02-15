#nullable enable
using ShopifySharp.GraphQL;

namespace ShopifySharp.GraphQL.QueryBuilders;

// ReSharper disable once UnusedTypeParameter
public interface IGraphOperationQueryBuilder<TResult> : IQuery
    where TResult : IGraphQLObject
{
    OperationType OperationType { get; }
}
