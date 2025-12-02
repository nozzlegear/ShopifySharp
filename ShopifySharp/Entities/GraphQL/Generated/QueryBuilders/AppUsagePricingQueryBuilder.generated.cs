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

public class AppUsagePricingQueryBuilder() : GraphQueryBuilder<AppUsagePricing>("appUsagePricing")
{
    public AppUsagePricingQueryBuilder AddFieldBalanceUsed(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("balanceUsed", build);
        return this;
    }

    public AppUsagePricingQueryBuilder AddFieldCappedAmount(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("cappedAmount", build);
        return this;
    }

    public AppUsagePricingQueryBuilder AddFieldInterval()
    {
        AddField("interval");
        return this;
    }

    public AppUsagePricingQueryBuilder AddFieldTerms()
    {
        AddField("terms");
        return this;
    }
}