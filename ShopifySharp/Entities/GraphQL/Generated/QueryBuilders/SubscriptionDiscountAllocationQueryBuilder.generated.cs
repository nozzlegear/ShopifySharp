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

public class SubscriptionDiscountAllocationQueryBuilder() : GraphQueryBuilder<SubscriptionDiscountAllocation>("subscriptionDiscountAllocation")
{
    public SubscriptionDiscountAllocationQueryBuilder AddFieldAmount(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("amount", build);
        return this;
    }

    public SubscriptionDiscountAllocationQueryBuilder AddUnionCaseDiscount(Func<SubscriptionAppliedCodeDiscountQueryBuilder, SubscriptionAppliedCodeDiscountQueryBuilder> build)
    {
        AddUnion<SubscriptionAppliedCodeDiscount, SubscriptionAppliedCodeDiscountQueryBuilder>("discount", build);
        return this;
    }

    public SubscriptionDiscountAllocationQueryBuilder AddUnionCaseDiscount(Func<SubscriptionManualDiscountQueryBuilder, SubscriptionManualDiscountQueryBuilder> build)
    {
        AddUnion<SubscriptionManualDiscount, SubscriptionManualDiscountQueryBuilder>("discount", build);
        return this;
    }
}