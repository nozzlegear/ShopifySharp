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

public class ProductVariantDetachMediaQueryBuilder() : GraphQueryBuilder<ProductVariantDetachMediaPayload>("query productVariantDetachMedia")
{
    public ProductVariantDetachMediaQueryBuilder AddArgumentProductId(string? productId)
    {
        AddArgument("productId", productId);
        return this;
    }

    public ProductVariantDetachMediaQueryBuilder AddArgumentVariantMedia(ICollection<ProductVariantDetachMediaInput>? variantMedia)
    {
        AddArgument("variantMedia", variantMedia);
        return this;
    }
}