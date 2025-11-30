#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ProductVariantsBulkUpdateQueryBuilder() : GraphQueryBuilder<ProductVariantsBulkUpdatePayload>("query productVariantsBulkUpdate")
{
    public ProductVariantsBulkUpdateQueryBuilder AddArgumentAllowPartialUpdates(bool? allowPartialUpdates)
    {
        AddArgument("allowPartialUpdates", allowPartialUpdates);
        return this;
    }

    public ProductVariantsBulkUpdateQueryBuilder AddArgumentMedia(ICollection<CreateMediaInput>? media)
    {
        AddArgument("media", media);
        return this;
    }

    public ProductVariantsBulkUpdateQueryBuilder AddArgumentProductId(string? productId)
    {
        AddArgument("productId", productId);
        return this;
    }

    public ProductVariantsBulkUpdateQueryBuilder AddArgumentVariants(ICollection<ProductVariantsBulkInput>? variants)
    {
        AddArgument("variants", variants);
        return this;
    }
}