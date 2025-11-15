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

public class MarketWebPresenceDeletePayloadQueryBuilder() : GraphQueryBuilder<MarketWebPresenceDeletePayload>("query marketWebPresenceDeletePayload")
{
    public MarketWebPresenceDeletePayloadQueryBuilder AddFieldDeletedId()
    {
        AddField("deletedId");
        return this;
    }

    public MarketWebPresenceDeletePayloadQueryBuilder AddFieldMarket()
    {
        AddField("market");
        return this;
    }

    public MarketWebPresenceDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}