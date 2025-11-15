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

public class CollectionAddProductsQueryBuilder() : GraphQueryBuilder<CollectionAddProductsPayload>("query collectionAddProducts")
{
    public CollectionAddProductsQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public CollectionAddProductsQueryBuilder AddArgumentProductIds(ICollection<string>? productIds)
    {
        AddArgument("productIds", productIds);
        return this;
    }
}