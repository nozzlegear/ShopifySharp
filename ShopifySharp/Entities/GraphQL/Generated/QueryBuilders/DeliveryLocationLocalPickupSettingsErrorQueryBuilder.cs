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

public class DeliveryLocationLocalPickupSettingsErrorQueryBuilder() : GraphQueryBuilder<DeliveryLocationLocalPickupSettingsError>("query deliveryLocationLocalPickupSettingsError")
{
    public DeliveryLocationLocalPickupSettingsErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public DeliveryLocationLocalPickupSettingsErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public DeliveryLocationLocalPickupSettingsErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}