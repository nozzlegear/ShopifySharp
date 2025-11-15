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

public class SubscriptionDiscountFixedAmountValueQueryBuilder() : GraphQueryBuilder<SubscriptionDiscountFixedAmountValue>("query subscriptionDiscountFixedAmountValue")
{
    public SubscriptionDiscountFixedAmountValueQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public SubscriptionDiscountFixedAmountValueQueryBuilder AddFieldAppliesOnEachItem()
    {
        AddField("appliesOnEachItem");
        return this;
    }
}