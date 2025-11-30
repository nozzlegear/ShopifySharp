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

public class AppRecurringPricingQueryBuilder() : GraphQueryBuilder<AppRecurringPricing>("query appRecurringPricing")
{
    public AppRecurringPricingQueryBuilder AddFieldDiscount()
    {
        AddField("discount");
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

    public AppRecurringPricingQueryBuilder AddFieldPrice()
    {
        AddField("price");
        return this;
    }
}