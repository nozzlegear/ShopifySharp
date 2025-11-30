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

public class AppSubscriptionDiscountQueryBuilder() : GraphQueryBuilder<AppSubscriptionDiscount>("appSubscriptionDiscount")
{
    public AppSubscriptionDiscountQueryBuilder AddFieldDurationLimitInIntervals()
    {
        AddField("durationLimitInIntervals");
        return this;
    }

    public AppSubscriptionDiscountQueryBuilder AddFieldPriceAfterDiscount(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("priceAfterDiscount", build);
        return this;
    }

    public AppSubscriptionDiscountQueryBuilder AddFieldRemainingDurationInIntervals()
    {
        AddField("remainingDurationInIntervals");
        return this;
    }

    public AppSubscriptionDiscountQueryBuilder AddUnionCaseValue(Func<AppSubscriptionDiscountAmountQueryBuilder, AppSubscriptionDiscountAmountQueryBuilder> build)
    {
        AddUnion<AppSubscriptionDiscountAmount, AppSubscriptionDiscountAmountQueryBuilder>("value", build);
        return this;
    }

    public AppSubscriptionDiscountQueryBuilder AddUnionCaseValue(Func<AppSubscriptionDiscountPercentageQueryBuilder, AppSubscriptionDiscountPercentageQueryBuilder> build)
    {
        AddUnion<AppSubscriptionDiscountPercentage, AppSubscriptionDiscountPercentageQueryBuilder>("value", build);
        return this;
    }
}