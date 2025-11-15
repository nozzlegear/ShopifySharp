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

public class CollectionPublicationConnectionQueryBuilder() : GraphQueryBuilder<CollectionPublicationConnection>("query collectionPublicationConnection")
{
    public CollectionPublicationConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public CollectionPublicationConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public CollectionPublicationConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}