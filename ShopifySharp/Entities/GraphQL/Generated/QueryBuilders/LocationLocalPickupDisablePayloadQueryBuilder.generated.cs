#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class LocationLocalPickupDisablePayloadQueryBuilder() : GraphQueryBuilder<LocationLocalPickupDisablePayload>("locationLocalPickupDisablePayload")
{
    public LocationLocalPickupDisablePayloadQueryBuilder AddFieldLocationId()
    {
        AddField("locationId");
        return this;
    }

    public LocationLocalPickupDisablePayloadQueryBuilder AddFieldUserErrors(Func<DeliveryLocationLocalPickupSettingsErrorQueryBuilder, DeliveryLocationLocalPickupSettingsErrorQueryBuilder> build)
    {
        AddField<DeliveryLocationLocalPickupSettingsError, DeliveryLocationLocalPickupSettingsErrorQueryBuilder>("userErrors", build);
        return this;
    }
}