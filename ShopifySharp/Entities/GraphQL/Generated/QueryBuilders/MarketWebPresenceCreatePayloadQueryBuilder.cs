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

public class MarketWebPresenceCreatePayloadQueryBuilder() : GraphQueryBuilder<MarketWebPresenceCreatePayload>("query marketWebPresenceCreatePayload")
{
    public MarketWebPresenceCreatePayloadQueryBuilder AddFieldMarket()
    {
        AddField("market");
        return this;
    }

    public MarketWebPresenceCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}