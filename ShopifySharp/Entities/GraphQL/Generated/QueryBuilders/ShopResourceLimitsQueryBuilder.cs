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

public class ShopResourceLimitsQueryBuilder() : GraphQueryBuilder<ShopResourceLimits>("query shopResourceLimits")
{
    public ShopResourceLimitsQueryBuilder AddFieldLocationLimit()
    {
        AddField("locationLimit");
        return this;
    }

    public ShopResourceLimitsQueryBuilder AddFieldMaxProductOptions()
    {
        AddField("maxProductOptions");
        return this;
    }

    public ShopResourceLimitsQueryBuilder AddFieldMaxProductVariants()
    {
        AddField("maxProductVariants");
        return this;
    }

    public ShopResourceLimitsQueryBuilder AddFieldRedirectLimitReached()
    {
        AddField("redirectLimitReached");
        return this;
    }
}