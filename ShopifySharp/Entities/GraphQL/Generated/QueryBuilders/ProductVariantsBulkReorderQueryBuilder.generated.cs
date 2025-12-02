#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ProductVariantsBulkReorderQueryBuilder() : GraphQueryBuilder<ProductVariantsBulkReorderPayload>("productVariantsBulkReorder"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public ProductVariantsBulkReorderQueryBuilder AddArgumentPositions(ICollection<ProductVariantPositionInput>? positions)
    {
        AddArgument("positions", positions);
        return this;
    }

    public ProductVariantsBulkReorderQueryBuilder AddArgumentProductId(string? productId)
    {
        AddArgument("productId", productId);
        return this;
    }
}