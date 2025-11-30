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

public class DeliveryLocationGroupQueryBuilder() : GraphQueryBuilder<DeliveryLocationGroup>("query deliveryLocationGroup")
{
    public DeliveryLocationGroupQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DeliveryLocationGroupQueryBuilder AddFieldLocations()
    {
        AddField("locations");
        return this;
    }

    public DeliveryLocationGroupQueryBuilder AddFieldLocationsCount()
    {
        AddField("locationsCount");
        return this;
    }
}