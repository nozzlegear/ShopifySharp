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

public class MarketConditionsQueryBuilder() : GraphQueryBuilder<MarketConditions>("query marketConditions")
{
    public MarketConditionsQueryBuilder AddFieldCompanyLocationsCondition()
    {
        AddField("companyLocationsCondition");
        return this;
    }

    public MarketConditionsQueryBuilder AddFieldConditionTypes()
    {
        AddField("conditionTypes");
        return this;
    }

    public MarketConditionsQueryBuilder AddFieldLocationsCondition()
    {
        AddField("locationsCondition");
        return this;
    }

    public MarketConditionsQueryBuilder AddFieldRegionsCondition()
    {
        AddField("regionsCondition");
        return this;
    }
}