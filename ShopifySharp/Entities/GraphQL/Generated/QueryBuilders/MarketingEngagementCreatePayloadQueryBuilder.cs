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

public class MarketingEngagementCreatePayloadQueryBuilder() : GraphQueryBuilder<MarketingEngagementCreatePayload>("query marketingEngagementCreatePayload")
{
    public MarketingEngagementCreatePayloadQueryBuilder AddFieldMarketingEngagement()
    {
        AddField("marketingEngagement");
        return this;
    }

    public MarketingEngagementCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}