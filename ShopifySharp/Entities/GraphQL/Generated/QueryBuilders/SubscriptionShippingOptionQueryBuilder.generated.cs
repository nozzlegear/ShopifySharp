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

public class SubscriptionShippingOptionQueryBuilder() : GraphQueryBuilder<SubscriptionShippingOption>("subscriptionShippingOption")
{
    public SubscriptionShippingOptionQueryBuilder AddFieldCarrierService(Func<DeliveryCarrierServiceQueryBuilder, DeliveryCarrierServiceQueryBuilder> build)
    {
        AddField<DeliveryCarrierService, DeliveryCarrierServiceQueryBuilder>("carrierService", build);
        return this;
    }

    public SubscriptionShippingOptionQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public SubscriptionShippingOptionQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public SubscriptionShippingOptionQueryBuilder AddFieldPhoneRequired()
    {
        AddField("phoneRequired");
        return this;
    }

    public SubscriptionShippingOptionQueryBuilder AddFieldPresentmentTitle()
    {
        AddField("presentmentTitle");
        return this;
    }

    public SubscriptionShippingOptionQueryBuilder AddFieldPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("price", build);
        return this;
    }

    public SubscriptionShippingOptionQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}