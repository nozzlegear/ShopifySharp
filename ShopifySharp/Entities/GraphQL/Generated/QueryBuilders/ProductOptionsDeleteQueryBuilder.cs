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

public class ProductOptionsDeleteQueryBuilder() : GraphQueryBuilder<ProductOptionsDeletePayload>("query productOptionsDelete")
{
    public ProductOptionsDeleteQueryBuilder AddArgumentOptions(ICollection<string>? options)
    {
        AddArgument("options", options);
        return this;
    }

    public ProductOptionsDeleteQueryBuilder AddArgumentProductId(string? productId)
    {
        AddArgument("productId", productId);
        return this;
    }

    public ProductOptionsDeleteQueryBuilder AddArgumentStrategy(ProductOptionDeleteStrategy? strategy)
    {
        AddArgument("strategy", strategy);
        return this;
    }
}