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

public class SubscriptionDeliveryMethodShippingOptionQueryBuilder() : GraphQueryBuilder<SubscriptionDeliveryMethodShippingOption>("subscriptionDeliveryMethodShippingOption")
{
    public SubscriptionDeliveryMethodShippingOptionQueryBuilder AddFieldCarrierService(Func<DeliveryCarrierServiceQueryBuilder, DeliveryCarrierServiceQueryBuilder> build)
    {
        AddField<DeliveryCarrierService, DeliveryCarrierServiceQueryBuilder>("carrierService", build);
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