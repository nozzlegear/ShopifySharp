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

public class CollectionRemoveProductsPayloadQueryBuilder() : GraphQueryBuilder<CollectionRemoveProductsPayload>("query collectionRemoveProductsPayload")
{
    public CollectionRemoveProductsPayloadQueryBuilder AddFieldJob()
    {
        AddField("job");
        return this;
    }

    public CollectionRemoveProductsPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}