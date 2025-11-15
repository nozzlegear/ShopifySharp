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

public class MarketingEventConnectionQueryBuilder() : GraphQueryBuilder<MarketingEventConnection>("query marketingEventConnection")
{
    public MarketingEventConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public MarketingEventConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public MarketingEventConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}