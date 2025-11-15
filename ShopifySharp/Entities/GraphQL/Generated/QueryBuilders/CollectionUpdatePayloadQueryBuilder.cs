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

public class CollectionUpdatePayloadQueryBuilder() : GraphQueryBuilder<CollectionUpdatePayload>("query collectionUpdatePayload")
{
    public CollectionUpdatePayloadQueryBuilder AddFieldCollection()
    {
        AddField("collection");
        return this;
    }

    public CollectionUpdatePayloadQueryBuilder AddFieldJob()
    {
        AddField("job");
        return this;
    }

    public CollectionUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}