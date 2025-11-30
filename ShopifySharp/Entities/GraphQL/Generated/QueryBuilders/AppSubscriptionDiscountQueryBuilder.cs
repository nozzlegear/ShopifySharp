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

public class AppSubscriptionDiscountQueryBuilder() : GraphQueryBuilder<AppSubscriptionDiscount>("query appSubscriptionDiscount")
{
    public AppSubscriptionDiscountQueryBuilder AddFieldDurationLimitInIntervals()
    {
        AddField("durationLimitInIntervals");
        return this;
    }

    public AppSubscriptionDiscountQueryBuilder AddFieldPriceAfterDiscount()
    {
        AddField("priceAfterDiscount");
        return this;
    }

    public AppSubscriptionDiscountQueryBuilder AddFieldRemainingDurationInIntervals()
    {
        AddField("remainingDurationInIntervals");
        return this;
    }

    public AppSubscriptionDiscountQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}