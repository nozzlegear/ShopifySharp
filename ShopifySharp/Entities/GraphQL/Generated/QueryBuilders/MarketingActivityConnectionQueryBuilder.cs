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

public class MarketingActivityConnectionQueryBuilder() : GraphQueryBuilder<MarketingActivityConnection>("query marketingActivityConnection")
{
    public MarketingActivityConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public MarketingActivityConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public MarketingActivityConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}