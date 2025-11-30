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

[Obsolete("Use `productUpdate` or `productSet` instead.")]
public class ProductCreateMediaQueryBuilder() : GraphQueryBuilder<ProductCreateMediaPayload>("query productCreateMedia")
{
    public ProductCreateMediaQueryBuilder AddArgumentMedia(ICollection<CreateMediaInput>? media)
    {
        AddArgument("media", media);
        return this;
    }

    public ProductCreateMediaQueryBuilder AddArgumentProductId(string? productId)
    {
        AddArgument("productId", productId);
        return this;
    }
}