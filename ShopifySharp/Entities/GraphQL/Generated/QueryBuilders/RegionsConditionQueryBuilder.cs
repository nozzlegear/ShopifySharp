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

public class RegionsConditionQueryBuilder() : GraphQueryBuilder<RegionsCondition>("query regionsCondition")
{
    public RegionsConditionQueryBuilder AddFieldApplicationLevel()
    {
        AddField("applicationLevel");
        return this;
    }

    public RegionsConditionQueryBuilder AddFieldRegions()
    {
        AddField("regions");
        return this;
    }
}