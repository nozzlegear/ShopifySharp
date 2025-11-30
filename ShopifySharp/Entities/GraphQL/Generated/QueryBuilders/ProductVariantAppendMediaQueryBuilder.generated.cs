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

public class ProductVariantAppendMediaQueryBuilder() : GraphQueryBuilder<ProductVariantAppendMediaPayload>("productVariantAppendMedia"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public ProductVariantAppendMediaQueryBuilder AddArgumentProductId(string? productId)
    {
        AddArgument("productId", productId);
        return this;
    }

    public ProductVariantAppendMediaQueryBuilder AddArgumentVariantMedia(ICollection<ProductVariantAppendMediaInput>? variantMedia)
    {
        AddArgument("variantMedia", variantMedia);
        return this;
    }
}