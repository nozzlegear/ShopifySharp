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

public class MarketWebPresenceConnectionQueryBuilder() : GraphQueryBuilder<MarketWebPresenceConnection>("query marketWebPresenceConnection")
{
    public MarketWebPresenceConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public MarketWebPresenceConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public MarketWebPresenceConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}