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

public class MarketLocalizationsRemovePayloadQueryBuilder() : GraphQueryBuilder<MarketLocalizationsRemovePayload>("query marketLocalizationsRemovePayload")
{
    public MarketLocalizationsRemovePayloadQueryBuilder AddFieldMarketLocalizations()
    {
        AddField("marketLocalizations");
        return this;
    }

    public MarketLocalizationsRemovePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}