#nullable enable
using System;
using ShopifySharp.GraphQL;

namespace ShopifySharp.Infrastructure;

// ReSharper disable once UnusedTypeParameter
public interface IGraphOperationQueryBuilder<TResult> : IQuery
    where TResult : IGraphQLObject
{
    OperationType OperationType { get; }
}
