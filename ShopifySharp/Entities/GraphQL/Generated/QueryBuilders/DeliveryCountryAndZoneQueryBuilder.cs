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

public class DeliveryCountryAndZoneQueryBuilder() : GraphQueryBuilder<DeliveryCountryAndZone>("query deliveryCountryAndZone")
{
    public DeliveryCountryAndZoneQueryBuilder AddFieldCountry()
    {
        AddField("country");
        return this;
    }

    public DeliveryCountryAndZoneQueryBuilder AddFieldZone()
    {
        AddField("zone");
        return this;
    }
}