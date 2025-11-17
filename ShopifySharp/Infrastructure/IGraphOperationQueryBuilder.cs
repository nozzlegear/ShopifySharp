#nullable enable
using ShopifySharp.GraphQL;

namespace ShopifySharp.Infrastructure;

public interface IGraphOperationQueryBuilder
{
    OperationType OperationType { get; }
}
