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

public class MarketConditionsQueryBuilder() : GraphQueryBuilder<MarketConditions>("marketConditions")
{
    public MarketConditionsQueryBuilder AddFieldCompanyLocationsCondition(Func<CompanyLocationsConditionQueryBuilder, CompanyLocationsConditionQueryBuilder> build)
    {
        AddField<CompanyLocationsCondition, CompanyLocationsConditionQueryBuilder>("companyLocationsCondition", build);
        return this;
    }

    public MarketConditionsQueryBuilder AddFieldConditionTypes()
    {
        AddField("conditionTypes");
        return this;
    }

    public MarketConditionsQueryBuilder AddFieldLocationsCondition(Func<LocationsConditionQueryBuilder, LocationsConditionQueryBuilder> build)
    {
        AddField<LocationsCondition, LocationsConditionQueryBuilder>("locationsCondition", build);
        return this;
    }

    public MarketConditionsQueryBuilder AddFieldRegionsCondition(Func<RegionsConditionQueryBuilder, RegionsConditionQueryBuilder> build)
    {
        AddField<RegionsCondition, RegionsConditionQueryBuilder>("regionsCondition", build);
        return this;
    }
}