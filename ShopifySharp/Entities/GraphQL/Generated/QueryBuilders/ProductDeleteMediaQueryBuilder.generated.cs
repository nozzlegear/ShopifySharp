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

[Obsolete("Use `fileUpdate` instead.")]
public class ProductDeleteMediaQueryBuilder() : GraphQueryBuilder<ProductDeleteMediaPayload>("productDeleteMedia"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public ProductDeleteMediaQueryBuilder AddArgumentMediaIds(ICollection<string>? mediaIds)
    {
        AddArgument("mediaIds", mediaIds);
        return this;
    }

    public ProductDeleteMediaQueryBuilder AddArgumentProductId(string? productId)
    {
        AddArgument("productId", productId);
        return this;
    }
}