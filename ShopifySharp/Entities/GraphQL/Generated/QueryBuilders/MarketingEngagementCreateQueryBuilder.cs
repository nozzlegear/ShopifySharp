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

public class MarketingEngagementCreateQueryBuilder() : GraphQueryBuilder<MarketingEngagementCreatePayload>("query marketingEngagementCreate")
{
    public MarketingEngagementCreateQueryBuilder AddArgumentChannelHandle(string? channelHandle)
    {
        AddArgument("channelHandle", channelHandle);
        return this;
    }

    public MarketingEngagementCreateQueryBuilder AddArgumentMarketingActivityId(string? marketingActivityId)
    {
        AddArgument("marketingActivityId", marketingActivityId);
        return this;
    }

    public MarketingEngagementCreateQueryBuilder AddArgumentMarketingEngagement(MarketingEngagementInput? marketingEngagement)
    {
        AddArgument("marketingEngagement", marketingEngagement);
        return this;
    }

    public MarketingEngagementCreateQueryBuilder AddArgumentRemoteId(string? remoteId)
    {
        AddArgument("remoteId", remoteId);
        return this;
    }
}