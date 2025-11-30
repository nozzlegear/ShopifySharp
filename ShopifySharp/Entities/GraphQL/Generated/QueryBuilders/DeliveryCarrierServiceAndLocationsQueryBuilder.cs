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

public class DeliveryCarrierServiceAndLocationsQueryBuilder() : GraphQueryBuilder<DeliveryCarrierServiceAndLocations>("query deliveryCarrierServiceAndLocations")
{
    public DeliveryCarrierServiceAndLocationsQueryBuilder AddFieldCarrierService()
    {
        AddField("carrierService");
        return this;
    }

    public DeliveryCarrierServiceAndLocationsQueryBuilder AddFieldLocations()
    {
        AddField("locations");
        return this;
    }
}