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

public class MarketingActivityUpdatePayloadQueryBuilder() : GraphQueryBuilder<MarketingActivityUpdatePayload>("marketingActivityUpdatePayload")
{
    public MarketingActivityUpdatePayloadQueryBuilder AddFieldMarketingActivity(Func<MarketingActivityQueryBuilder, MarketingActivityQueryBuilder> build)
    {
        AddField<MarketingActivity, MarketingActivityQueryBuilder>("marketingActivity", build);
        return this;
    }

    public MarketingActivityUpdatePayloadQueryBuilder AddFieldRedirectPath()
    {
        AddField("redirectPath");
        return this;
    }

    public MarketingActivityUpdatePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}