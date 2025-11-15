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

public class CollectionAddProductsPayloadQueryBuilder() : GraphQueryBuilder<CollectionAddProductsPayload>("query collectionAddProductsPayload")
{
    public CollectionAddProductsPayloadQueryBuilder AddFieldCollection()
    {
        AddField("collection");
        return this;
    }

    public CollectionAddProductsPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}