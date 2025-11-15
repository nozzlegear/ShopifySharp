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

public class MarketingActivityUpdateExternalPayloadQueryBuilder() : GraphQueryBuilder<MarketingActivityUpdateExternalPayload>("query marketingActivityUpdateExternalPayload")
{
    public MarketingActivityUpdateExternalPayloadQueryBuilder AddFieldMarketingActivity()
    {
        AddField("marketingActivity");
        return this;
    }

    public MarketingActivityUpdateExternalPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}