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

public class RegionsConditionQueryBuilder() : GraphQueryBuilder<RegionsCondition>("regionsCondition")
{
    public RegionsConditionQueryBuilder AddFieldApplicationLevel()
    {
        AddField("applicationLevel");
        return this;
    }

    public RegionsConditionQueryBuilder AddFieldRegions(Func<MarketRegionConnectionQueryBuilder, MarketRegionConnectionQueryBuilder> build)
    {
        AddField<MarketRegionConnection, MarketRegionConnectionQueryBuilder>("regions", build);
        return this;
    }
}