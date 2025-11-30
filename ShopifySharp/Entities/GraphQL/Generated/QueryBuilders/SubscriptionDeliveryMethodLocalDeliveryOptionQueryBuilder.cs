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

public class SubscriptionDeliveryMethodLocalDeliveryOptionQueryBuilder() : GraphQueryBuilder<SubscriptionDeliveryMethodLocalDeliveryOption>("query subscriptionDeliveryMethodLocalDeliveryOption")
{
    public SubscriptionDeliveryMethodLocalDeliveryOptionQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public SubscriptionDeliveryMethodLocalDeliveryOptionQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public SubscriptionDeliveryMethodLocalDeliveryOptionQueryBuilder AddFieldInstructions()
    {
        AddField("instructions");
        return this;
    }

    public SubscriptionDeliveryMethodLocalDeliveryOptionQueryBuilder AddFieldPhone()
    {
        AddField("phone");
        return this;
    }

    public SubscriptionDeliveryMethodLocalDeliveryOptionQueryBuilder AddFieldPresentmentTitle()
    {
        AddField("presentmentTitle");
        return this;
    }

    public SubscriptionDeliveryMethodLocalDeliveryOptionQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}