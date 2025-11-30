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

public class LocationsConditionQueryBuilder() : GraphQueryBuilder<LocationsCondition>("query locationsCondition")
{
    public LocationsConditionQueryBuilder AddFieldApplicationLevel()
    {
        AddField("applicationLevel");
        return this;
    }

    public LocationsConditionQueryBuilder AddFieldLocations()
    {
        AddField("locations");
        return this;
    }
}