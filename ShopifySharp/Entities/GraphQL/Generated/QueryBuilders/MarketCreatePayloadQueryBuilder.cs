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

public class MarketCreatePayloadQueryBuilder() : GraphQueryBuilder<MarketCreatePayload>("query marketCreatePayload")
{
    public MarketCreatePayloadQueryBuilder AddFieldMarket()
    {
        AddField("market");
        return this;
    }

    public MarketCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}