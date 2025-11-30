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

public class LocationLocalPickupEnablePayloadQueryBuilder() : GraphQueryBuilder<LocationLocalPickupEnablePayload>("query locationLocalPickupEnablePayload")
{
    public LocationLocalPickupEnablePayloadQueryBuilder AddFieldLocalPickupSettings()
    {
        AddField("localPickupSettings");
        return this;
    }

    public LocationLocalPickupEnablePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}