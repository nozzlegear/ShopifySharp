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

public class AppRecurringPricingQueryBuilder() : GraphQueryBuilder<AppRecurringPricing>("appRecurringPricing")
{
    public AppRecurringPricingQueryBuilder AddFieldDiscount(Func<AppSubscriptionDiscountQueryBuilder, AppSubscriptionDiscountQueryBuilder> build)
    {
        AddField<AppSubscriptionDiscount, AppSubscriptionDiscountQueryBuilder>("discount", build);
        return this;
    }

    public AppRecurringPricingQueryBuilder AddFieldInterval()
    {
        AddField("interval");
        return this;
    }

    public AppRecurringPricingQueryBuilder AddFieldPlanHandle()
    {
        AddField("planHandle");
        return this;
    }

    public AppRecurringPricingQueryBuilder AddFieldPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("price", build);
        return this;
    }
}