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

public class SubscriptionDeliveryOptionResultSuccessQueryBuilder() : GraphQueryBuilder<SubscriptionDeliveryOptionResultSuccess>("subscriptionDeliveryOptionResultSuccess")
{
    public SubscriptionDeliveryOptionResultSuccessQueryBuilder AddUnionCaseDeliveryOptions(Func<SubscriptionLocalDeliveryOptionQueryBuilder, SubscriptionLocalDeliveryOptionQueryBuilder> build)
    {
        AddUnion<SubscriptionLocalDeliveryOption, SubscriptionLocalDeliveryOptionQueryBuilder>("deliveryOptions", build);
        return this;
    }

    public SubscriptionDeliveryOptionResultSuccessQueryBuilder AddUnionCaseDeliveryOptions(Func<SubscriptionPickupOptionQueryBuilder, SubscriptionPickupOptionQueryBuilder> build)
    {
        AddUnion<SubscriptionPickupOption, SubscriptionPickupOptionQueryBuilder>("deliveryOptions", build);
        return this;
    }

    public SubscriptionDeliveryOptionResultSuccessQueryBuilder AddUnionCaseDeliveryOptions(Func<SubscriptionShippingOptionQueryBuilder, SubscriptionShippingOptionQueryBuilder> build)
    {
        AddUnion<SubscriptionShippingOption, SubscriptionShippingOptionQueryBuilder>("deliveryOptions", build);
        return this;
    }
}