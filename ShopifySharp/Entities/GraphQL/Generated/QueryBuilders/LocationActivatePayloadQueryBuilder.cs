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

public class LocationActivatePayloadQueryBuilder() : GraphQueryBuilder<LocationActivatePayload>("query locationActivatePayload")
{
    public LocationActivatePayloadQueryBuilder AddFieldLocation()
    {
        AddField("location");
        return this;
    }

    public LocationActivatePayloadQueryBuilder AddFieldLocationActivateUserErrors()
    {
        AddField("locationActivateUserErrors");
        return this;
    }
}