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

public class DiscountCustomerBuysQueryBuilder() : GraphQueryBuilder<DiscountCustomerBuys>("query discountCustomerBuys")
{
    public DiscountCustomerBuysQueryBuilder AddFieldIsOneTimePurchase()
    {
        AddField("isOneTimePurchase");
        return this;
    }

    public DiscountCustomerBuysQueryBuilder AddFieldIsSubscription()
    {
        AddField("isSubscription");
        return this;
    }

    public DiscountCustomerBuysQueryBuilder AddFieldItems()
    {
        AddField("items");
        return this;
    }

    public DiscountCustomerBuysQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}