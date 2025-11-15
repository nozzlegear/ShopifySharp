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

public class PriceRuleDiscountCodeQueryBuilder() : GraphQueryBuilder<PriceRuleDiscountCode>("query priceRuleDiscountCode")
{
    public PriceRuleDiscountCodeQueryBuilder AddFieldApp()
    {
        AddField("app");
        return this;
    }

    public PriceRuleDiscountCodeQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public PriceRuleDiscountCodeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public PriceRuleDiscountCodeQueryBuilder AddFieldUsageCount()
    {
        AddField("usageCount");
        return this;
    }
}