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

public class MarketingActivityUpdateExternalPayloadQueryBuilder() : GraphQueryBuilder<MarketingActivityUpdateExternalPayload>("marketingActivityUpdateExternalPayload")
{
    public MarketingActivityUpdateExternalPayloadQueryBuilder AddFieldMarketingActivity(Func<MarketingActivityQueryBuilder, MarketingActivityQueryBuilder> build)
    {
        AddField<MarketingActivity, MarketingActivityQueryBuilder>("marketingActivity", build);
        return this;
    }

    public MarketingActivityUpdateExternalPayloadQueryBuilder AddFieldUserErrors(Func<MarketingActivityUserErrorQueryBuilder, MarketingActivityUserErrorQueryBuilder> build)
    {
        AddField<MarketingActivityUserError, MarketingActivityUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}