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

public class CurrencySettingQueryBuilder() : GraphQueryBuilder<CurrencySetting>("currencySetting")
{
    public CurrencySettingQueryBuilder AddFieldCurrencyCode()
    {
        AddField("currencyCode");
        return this;
    }

    public CurrencySettingQueryBuilder AddFieldCurrencyName()
    {
        AddField("currencyName");
        return this;
    }

    public CurrencySettingQueryBuilder AddFieldEnabled()
    {
        AddField("enabled");
        return this;
    }

    public CurrencySettingQueryBuilder AddFieldManualRate()
    {
        AddField("manualRate");
        return this;
    }

    public CurrencySettingQueryBuilder AddFieldRateUpdatedAt()
    {
        AddField("rateUpdatedAt");
        return this;
    }
}