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

public class SubscriptionDeliveryMethodPickupOptionQueryBuilder() : GraphQueryBuilder<SubscriptionDeliveryMethodPickupOption>("query subscriptionDeliveryMethodPickupOption")
{
    public SubscriptionDeliveryMethodPickupOptionQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public SubscriptionDeliveryMethodPickupOptionQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public SubscriptionDeliveryMethodPickupOptionQueryBuilder AddFieldLocation()
    {
        AddField("location");
        return this;
    }

    public SubscriptionDeliveryMethodPickupOptionQueryBuilder AddFieldPresentmentTitle()
    {
        AddField("presentmentTitle");
        return this;
    }

    public SubscriptionDeliveryMethodPickupOptionQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}