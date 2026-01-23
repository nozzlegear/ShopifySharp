#nullable enable
using System;
using ShopifySharp.GraphQL;

namespace ShopifySharp.Infrastructure;

// ReSharper disable once UnusedTypeParameter
public interface IGraphOperationQueryBuilder<TResult> where TResult : IGraphQLObject
{
    OperationType OperationType { get; }
    string Build();
}
