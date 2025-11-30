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

public class MarketingActivityUpsertExternalPayloadQueryBuilder() : GraphQueryBuilder<MarketingActivityUpsertExternalPayload>("query marketingActivityUpsertExternalPayload")
{
    public MarketingActivityUpsertExternalPayloadQueryBuilder AddFieldMarketingActivity()
    {
        AddField("marketingActivity");
        return this;
    }

    public MarketingActivityUpsertExternalPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}