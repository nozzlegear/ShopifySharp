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

public class MarketingActivityCreateExternalPayloadQueryBuilder() : GraphQueryBuilder<MarketingActivityCreateExternalPayload>("marketingActivityCreateExternalPayload")
{
    public MarketingActivityCreateExternalPayloadQueryBuilder AddFieldMarketingActivity(Func<MarketingActivityQueryBuilder, MarketingActivityQueryBuilder> build)
    {
        AddField<MarketingActivity, MarketingActivityQueryBuilder>("marketingActivity", build);
        return this;
    }

    public MarketingActivityCreateExternalPayloadQueryBuilder AddFieldUserErrors(Func<MarketingActivityUserErrorQueryBuilder, MarketingActivityUserErrorQueryBuilder> build)
    {
        AddField<MarketingActivityUserError, MarketingActivityUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}