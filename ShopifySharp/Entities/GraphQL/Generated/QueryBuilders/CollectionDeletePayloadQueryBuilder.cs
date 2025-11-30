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

public class CollectionDeletePayloadQueryBuilder() : GraphQueryBuilder<CollectionDeletePayload>("query collectionDeletePayload")
{
    public CollectionDeletePayloadQueryBuilder AddFieldDeletedCollectionId()
    {
        AddField("deletedCollectionId");
        return this;
    }

    public CollectionDeletePayloadQueryBuilder AddFieldShop()
    {
        AddField("shop");
        return this;
    }

    public CollectionDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}