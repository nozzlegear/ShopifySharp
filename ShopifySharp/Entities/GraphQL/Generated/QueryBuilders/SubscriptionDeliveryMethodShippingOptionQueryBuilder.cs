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

public class SubscriptionDeliveryMethodShippingOptionQueryBuilder() : GraphQueryBuilder<SubscriptionDeliveryMethodShippingOption>("query subscriptionDeliveryMethodShippingOption")
{
    [Obsolete("This field has never been implemented.")]
    public SubscriptionDeliveryMethodShippingOptionQueryBuilder AddFieldCarrierService()
    {
        AddField("carrierService");
        return this;
    }

    public SubscriptionDeliveryMethodShippingOptionQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public SubscriptionDeliveryMethodShippingOptionQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public SubscriptionDeliveryMethodShippingOptionQueryBuilder AddFieldPresentmentTitle()
    {
        AddField("presentmentTitle");
        return this;
    }

    public SubscriptionDeliveryMethodShippingOptionQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}