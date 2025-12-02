#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class MarketingEngagementCreatePayloadQueryBuilder() : GraphQueryBuilder<MarketingEngagementCreatePayload>("marketingEngagementCreatePayload")
{
    public MarketingEngagementCreatePayloadQueryBuilder AddFieldMarketingEngagement(Func<MarketingEngagementQueryBuilder, MarketingEngagementQueryBuilder> build)
    {
        AddField<MarketingEngagement, MarketingEngagementQueryBuilder>("marketingEngagement", build);
        return this;
    }

    public MarketingEngagementCreatePayloadQueryBuilder AddFieldUserErrors(Func<MarketingActivityUserErrorQueryBuilder, MarketingActivityUserErrorQueryBuilder> build)
    {
        AddField<MarketingActivityUserError, MarketingActivityUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}