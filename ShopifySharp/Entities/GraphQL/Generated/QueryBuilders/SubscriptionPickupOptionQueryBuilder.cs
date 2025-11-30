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

public class SubscriptionPickupOptionQueryBuilder() : GraphQueryBuilder<SubscriptionPickupOption>("query subscriptionPickupOption")
{
    public SubscriptionPickupOptionQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public SubscriptionPickupOptionQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public SubscriptionPickupOptionQueryBuilder AddFieldLocation()
    {
        AddField("location");
        return this;
    }

    public SubscriptionPickupOptionQueryBuilder AddFieldPhoneRequired()
    {
        AddField("phoneRequired");
        return this;
    }

    public SubscriptionPickupOptionQueryBuilder AddFieldPickupTime()
    {
        AddField("pickupTime");
        return this;
    }

    public SubscriptionPickupOptionQueryBuilder AddFieldPresentmentTitle()
    {
        AddField("presentmentTitle");
        return this;
    }

    public SubscriptionPickupOptionQueryBuilder AddFieldPrice()
    {
        AddField("price");
        return this;
    }

    public SubscriptionPickupOptionQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}