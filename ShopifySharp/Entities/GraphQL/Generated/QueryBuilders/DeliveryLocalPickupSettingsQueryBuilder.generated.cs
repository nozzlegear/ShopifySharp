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

public class DeliveryLocalPickupSettingsQueryBuilder() : GraphQueryBuilder<DeliveryLocalPickupSettings>("deliveryLocalPickupSettings")
{
    public DeliveryLocalPickupSettingsQueryBuilder AddFieldInstructions()
    {
        AddField("instructions");
        return this;
    }

    public DeliveryLocalPickupSettingsQueryBuilder AddFieldPickupTime()
    {
        AddField("pickupTime");
        return this;
    }
}