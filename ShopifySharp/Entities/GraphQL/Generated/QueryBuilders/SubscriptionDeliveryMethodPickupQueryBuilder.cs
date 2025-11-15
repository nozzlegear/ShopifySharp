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

public class SubscriptionDeliveryMethodPickupQueryBuilder() : GraphQueryBuilder<SubscriptionDeliveryMethodPickup>("query subscriptionDeliveryMethodPickup")
{
    public SubscriptionDeliveryMethodPickupQueryBuilder AddFieldPickupOption()
    {
        AddField("pickupOption");
        return this;
    }
}