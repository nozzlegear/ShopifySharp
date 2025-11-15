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

[Obsolete("Use `fileUpdate` instead.")]
public class ProductUpdateMediaQueryBuilder() : GraphQueryBuilder<ProductUpdateMediaPayload>("query productUpdateMedia")
{
    public ProductUpdateMediaQueryBuilder AddArgumentMedia(ICollection<UpdateMediaInput>? media)
    {
        AddArgument("media", media);
        return this;
    }

    public ProductUpdateMediaQueryBuilder AddArgumentProductId(string? productId)
    {
        AddArgument("productId", productId);
        return this;
    }
}