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

public class DeliveryProfileLocationGroupQueryBuilder() : GraphQueryBuilder<DeliveryProfileLocationGroup>("query deliveryProfileLocationGroup")
{
    public DeliveryProfileLocationGroupQueryBuilder AddFieldCountriesInAnyZone()
    {
        AddField("countriesInAnyZone");
        return this;
    }

    public DeliveryProfileLocationGroupQueryBuilder AddFieldLocationGroup()
    {
        AddField("locationGroup");
        return this;
    }

    public DeliveryProfileLocationGroupQueryBuilder AddFieldLocationGroupZones()
    {
        AddField("locationGroupZones");
        return this;
    }
}