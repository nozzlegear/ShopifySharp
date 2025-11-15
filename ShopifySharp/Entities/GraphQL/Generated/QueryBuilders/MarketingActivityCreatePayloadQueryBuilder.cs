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

public class MarketingActivityCreatePayloadQueryBuilder() : GraphQueryBuilder<MarketingActivityCreatePayload>("query marketingActivityCreatePayload")
{
    [Obsolete("Marketing activity app extensions are deprecated and will be removed in the near future.")]
    public MarketingActivityCreatePayloadQueryBuilder AddFieldMarketingActivity()
    {
        AddField("marketingActivity");
        return this;
    }

    [Obsolete("Marketing activity app extensions are deprecated and will be removed in the near future.")]
    public MarketingActivityCreatePayloadQueryBuilder AddFieldRedirectPath()
    {
        AddField("redirectPath");
        return this;
    }

    public MarketingActivityCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}