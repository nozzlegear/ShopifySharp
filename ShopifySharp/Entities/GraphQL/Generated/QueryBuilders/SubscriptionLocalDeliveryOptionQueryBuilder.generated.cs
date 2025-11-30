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

public class SubscriptionLocalDeliveryOptionQueryBuilder() : GraphQueryBuilder<SubscriptionLocalDeliveryOption>("subscriptionLocalDeliveryOption")
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

    public SubscriptionLocalDeliveryOptionQueryBuilder AddFieldPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("price", build);
        return this;
    }

    public SubscriptionLocalDeliveryOptionQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}