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

public class SubscriptionLocalDeliveryOptionQueryBuilder() : GraphQueryBuilder<SubscriptionLocalDeliveryOption>("query subscriptionLocalDeliveryOption")
{
    public SubscriptionLocalDeliveryOptionQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public SubscriptionLocalDeliveryOptionQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public SubscriptionLocalDeliveryOptionQueryBuilder AddFieldPhoneRequired()
    {
        AddField("phoneRequired");
        return this;
    }

    public SubscriptionLocalDeliveryOptionQueryBuilder AddFieldPresentmentTitle()
    {
        AddField("presentmentTitle");
        return this;
    }

    public SubscriptionLocalDeliveryOptionQueryBuilder AddFieldPrice()
    {
        AddField("price");
        return this;
    }

    public SubscriptionLocalDeliveryOptionQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}