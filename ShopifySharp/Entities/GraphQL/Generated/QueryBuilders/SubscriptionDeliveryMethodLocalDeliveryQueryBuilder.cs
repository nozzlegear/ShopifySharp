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

public class SubscriptionDeliveryMethodLocalDeliveryQueryBuilder() : GraphQueryBuilder<SubscriptionDeliveryMethodLocalDelivery>("query subscriptionDeliveryMethodLocalDelivery")
{
    public SubscriptionDeliveryMethodLocalDeliveryQueryBuilder AddFieldAddress()
    {
        AddField("address");
        return this;
    }

    public SubscriptionDeliveryMethodLocalDeliveryQueryBuilder AddFieldLocalDeliveryOption()
    {
        AddField("localDeliveryOption");
        return this;
    }
}