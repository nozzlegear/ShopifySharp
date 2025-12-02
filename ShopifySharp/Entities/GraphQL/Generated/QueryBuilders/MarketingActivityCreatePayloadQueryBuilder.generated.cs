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

public class MarketingActivityCreatePayloadQueryBuilder() : GraphQueryBuilder<MarketingActivityCreatePayload>("marketingActivityCreatePayload")
{
    public MarketingActivityCreatePayloadQueryBuilder AddFieldMarketingActivity(Func<MarketingActivityQueryBuilder, MarketingActivityQueryBuilder> build)
    {
        AddField<MarketingActivity, MarketingActivityQueryBuilder>("marketingActivity", build);
        return this;
    }

    [Obsolete("Marketing activity app extensions are deprecated and will be removed in the near future.")]
    public MarketingActivityCreatePayloadQueryBuilder AddFieldRedirectPath()
    {
        AddField("redirectPath");
        return this;
    }

    public MarketingActivityCreatePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}