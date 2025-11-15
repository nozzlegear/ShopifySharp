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

public class CollectionConnectionQueryBuilder() : GraphQueryBuilder<CollectionConnection>("query collectionConnection")
{
    public CollectionConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public CollectionConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public CollectionConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}