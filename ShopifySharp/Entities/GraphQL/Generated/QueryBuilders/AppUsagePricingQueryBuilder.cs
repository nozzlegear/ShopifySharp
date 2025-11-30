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

public class AppUsagePricingQueryBuilder() : GraphQueryBuilder<AppUsagePricing>("query appUsagePricing")
{
    public AppUsagePricingQueryBuilder AddFieldBalanceUsed()
    {
        AddField("balanceUsed");
        return this;
    }

    public AppUsagePricingQueryBuilder AddFieldCappedAmount()
    {
        AddField("cappedAmount");
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