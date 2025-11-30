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

public class CollectionUnpublishPayloadQueryBuilder() : GraphQueryBuilder<CollectionUnpublishPayload>("query collectionUnpublishPayload")
{
    public CollectionUnpublishPayloadQueryBuilder AddFieldCollection()
    {
        AddField("collection");
        return this;
    }

    public CollectionUnpublishPayloadQueryBuilder AddFieldShop()
    {
        AddField("shop");
        return this;
    }

    public CollectionUnpublishPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}