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

public class LocationAddPayloadQueryBuilder() : GraphQueryBuilder<LocationAddPayload>("query locationAddPayload")
{
    public LocationAddPayloadQueryBuilder AddFieldLocation()
    {
        AddField("location");
        return this;
    }

    public LocationAddPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}