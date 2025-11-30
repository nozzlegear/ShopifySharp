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

public class SubscriptionDeliveryMethodPickupOptionQueryBuilder() : GraphQueryBuilder<SubscriptionDeliveryMethodPickupOption>("subscriptionDeliveryMethodPickupOption")
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

    public SubscriptionDeliveryMethodPickupOptionQueryBuilder AddFieldLocation(Func<LocationQueryBuilder, LocationQueryBuilder> build)
    {
        AddField<Location, LocationQueryBuilder>("location", build);
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