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

public class ShopPlanQueryBuilder() : GraphQueryBuilder<ShopPlan>("shopPlan")
{
    [Obsolete("Use `publicDisplayName` instead.")]
    public ShopPlanQueryBuilder AddFieldDisplayName()
    {
        AddField("displayName");
        return this;
    }

    public ShopPlanQueryBuilder AddFieldPartnerDevelopment()
    {
        AddField("partnerDevelopment");
        return this;
    }

    public ShopPlanQueryBuilder AddFieldPublicDisplayName()
    {
        AddField("publicDisplayName");
        return this;
    }

    public ShopPlanQueryBuilder AddFieldShopifyPlus()
    {
        AddField("shopifyPlus");
        return this;
    }
}