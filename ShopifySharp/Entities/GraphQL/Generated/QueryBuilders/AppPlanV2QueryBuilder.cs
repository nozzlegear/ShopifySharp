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

public class AppPlanV2QueryBuilder() : GraphQueryBuilder<AppPlanV2>("query appPlanV2")
{
    public AppPlanV2QueryBuilder AddFieldPricingDetails()
    {
        AddField("pricingDetails");
        return this;
    }
}