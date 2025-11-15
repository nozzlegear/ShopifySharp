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

public class LocationLocalPickupEnableQueryBuilder() : GraphQueryBuilder<LocationLocalPickupEnablePayload>("query locationLocalPickupEnable")
{
    public LocationLocalPickupEnableQueryBuilder AddArgumentLocalPickupSettings(DeliveryLocationLocalPickupEnableInput? localPickupSettings)
    {
        AddArgument("localPickupSettings", localPickupSettings);
        return this;
    }
}