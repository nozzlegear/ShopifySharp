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

public class DiscountCustomerGetsQueryBuilder() : GraphQueryBuilder<DiscountCustomerGets>("query discountCustomerGets")
{
    public DiscountCustomerGetsQueryBuilder AddFieldAppliesOnOneTimePurchase()
    {
        AddField("appliesOnOneTimePurchase");
        return this;
    }

    public DiscountCustomerGetsQueryBuilder AddFieldAppliesOnSubscription()
    {
        AddField("appliesOnSubscription");
        return this;
    }

    public DiscountCustomerGetsQueryBuilder AddFieldItems()
    {
        AddField("items");
        return this;
    }

    public DiscountCustomerGetsQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}