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

public class MarketCurrencySettingsQueryBuilder() : GraphQueryBuilder<MarketCurrencySettings>("marketCurrencySettings")
{
    public MarketCurrencySettingsQueryBuilder AddFieldBaseCurrency(Func<CurrencySettingQueryBuilder, CurrencySettingQueryBuilder> build)
    {
        AddField<CurrencySetting, CurrencySettingQueryBuilder>("baseCurrency", build);
        return this;
    }

    public MarketCurrencySettingsQueryBuilder AddFieldLocalCurrencies()
    {
        AddField("localCurrencies");
        return this;
    }

    public MarketCurrencySettingsQueryBuilder AddFieldRoundingEnabled()
    {
        AddField("roundingEnabled");
        return this;
    }
}