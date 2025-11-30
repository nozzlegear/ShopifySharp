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

public class MarketRegionCountryQueryBuilder() : GraphQueryBuilder<MarketRegionCountry>("query marketRegionCountry")
{
    public MarketRegionCountryQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public MarketRegionCountryQueryBuilder AddFieldCurrency()
    {
        AddField("currency");
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