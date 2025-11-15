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

public class LocationEditPayloadQueryBuilder() : GraphQueryBuilder<LocationEditPayload>("query locationEditPayload")
{
    public LocationEditPayloadQueryBuilder AddFieldLocation()
    {
        AddField("location");
        return this;
    }

    public LocationEditPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}