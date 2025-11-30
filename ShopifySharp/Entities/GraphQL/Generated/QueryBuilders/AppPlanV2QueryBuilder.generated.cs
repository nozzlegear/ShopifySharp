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

public class AppPlanV2QueryBuilder() : GraphQueryBuilder<AppPlanV2>("appPlanV2")
{
    public AppPlanV2QueryBuilder AddUnionCasePricingDetails(Func<AppRecurringPricingQueryBuilder, AppRecurringPricingQueryBuilder> build)
    {
        AddUnion<AppRecurringPricing, AppRecurringPricingQueryBuilder>("pricingDetails", build);
        return this;
    }

    public AppPlanV2QueryBuilder AddUnionCasePricingDetails(Func<AppUsagePricingQueryBuilder, AppUsagePricingQueryBuilder> build)
    {
        AddUnion<AppUsagePricing, AppUsagePricingQueryBuilder>("pricingDetails", build);
        return this;
    }
}