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

public class MarketCurrencySettingsUpdatePayloadQueryBuilder() : GraphQueryBuilder<MarketCurrencySettingsUpdatePayload>("marketCurrencySettingsUpdatePayload")
{
    public MarketCurrencySettingsUpdatePayloadQueryBuilder AddFieldMarket(Func<MarketQueryBuilder, MarketQueryBuilder> build)
    {
        AddField<Market, MarketQueryBuilder>("market", build);
        return this;
    }

    public MarketCurrencySettingsUpdatePayloadQueryBuilder AddFieldUserErrors(Func<MarketCurrencySettingsUserErrorQueryBuilder, MarketCurrencySettingsUserErrorQueryBuilder> build)
    {
        AddField<MarketCurrencySettingsUserError, MarketCurrencySettingsUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}