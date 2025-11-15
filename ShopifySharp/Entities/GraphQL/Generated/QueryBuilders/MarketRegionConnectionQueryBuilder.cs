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

public class MarketRegionConnectionQueryBuilder() : GraphQueryBuilder<MarketRegionConnection>("query marketRegionConnection")
{
    public MarketRegionConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public MarketRegionConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public MarketRegionConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}