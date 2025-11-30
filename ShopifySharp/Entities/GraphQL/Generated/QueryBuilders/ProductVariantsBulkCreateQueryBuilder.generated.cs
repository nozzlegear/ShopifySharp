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

public class ProductVariantsBulkCreateQueryBuilder() : GraphQueryBuilder<ProductVariantsBulkCreatePayload>("productVariantsBulkCreate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public ProductVariantsBulkCreateQueryBuilder AddArgumentMedia(ICollection<CreateMediaInput>? media)
    {
        AddArgument("media", media);
        return this;
    }

    public ProductVariantsBulkCreateQueryBuilder AddArgumentProductId(string? productId)
    {
        AddArgument("productId", productId);
        return this;
    }

    public ProductVariantsBulkCreateQueryBuilder AddArgumentStrategy(ProductVariantsBulkCreateStrategy? strategy)
    {
        AddArgument("strategy", strategy);
        return this;
    }

    public ProductVariantsBulkCreateQueryBuilder AddArgumentVariants(ICollection<ProductVariantsBulkInput>? variants)
    {
        AddArgument("variants", variants);
        return this;
    }
}