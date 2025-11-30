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

public class MarketCurrencySettingsUpdatePayloadQueryBuilder() : GraphQueryBuilder<MarketCurrencySettingsUpdatePayload>("query marketCurrencySettingsUpdatePayload")
{
    [Obsolete("Use `marketCreate` and `marketUpdate` mutations instead.")]
    public MarketCurrencySettingsUpdatePayloadQueryBuilder AddFieldMarket()
    {
        AddField("market");
        return this;
    }

    public MarketCurrencySettingsUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}