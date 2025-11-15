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

public class LocationDeactivateQueryBuilder() : GraphQueryBuilder<LocationDeactivatePayload>("query locationDeactivate")
{
    public LocationDeactivateQueryBuilder AddArgumentDestinationLocationId(string? destinationLocationId)
    {
        AddArgument("destinationLocationId", destinationLocationId);
        return this;
    }

    public LocationDeactivateQueryBuilder AddArgumentLocationId(string? locationId)
    {
        AddArgument("locationId", locationId);
        return this;
    }
}