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

public class MarketRegionCountryQueryBuilder() : GraphQueryBuilder<MarketRegionCountry>("marketRegionCountry")
{
    public MarketRegionCountryQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public MarketRegionCountryQueryBuilder AddFieldCurrency(Func<CurrencySettingQueryBuilder, CurrencySettingQueryBuilder> build)
    {
        AddField<CurrencySetting, CurrencySettingQueryBuilder>("currency", build);
        return this;
    }

    public MarketRegionCountryQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public MarketRegionCountryQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }
}