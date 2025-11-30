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

public class MarketingActivityUpdatePayloadQueryBuilder() : GraphQueryBuilder<MarketingActivityUpdatePayload>("query marketingActivityUpdatePayload")
{
    public MarketingActivityUpdatePayloadQueryBuilder AddFieldMarketingActivity()
    {
        AddField("marketingActivity");
        return this;
    }

    public MarketingActivityUpdatePayloadQueryBuilder AddFieldRedirectPath()
    {
        AddField("redirectPath");
        return this;
    }

    public MarketingActivityUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}