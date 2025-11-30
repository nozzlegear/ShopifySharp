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

public class QuantityRuleQueryBuilder() : GraphQueryBuilder<QuantityRule>("query quantityRule")
{
    public QuantityRuleQueryBuilder AddFieldIncrement()
    {
        AddField("increment");
        return this;
    }

    public QuantityRuleQueryBuilder AddFieldIsDefault()
    {
        AddField("isDefault");
        return this;
    }

    public QuantityRuleQueryBuilder AddFieldMaximum()
    {
        AddField("maximum");
        return this;
    }

    public QuantityRuleQueryBuilder AddFieldMinimum()
    {
        AddField("minimum");
        return this;
    }

    public QuantityRuleQueryBuilder AddFieldOriginType()
    {
        AddField("originType");
        return this;
    }

    public QuantityRuleQueryBuilder AddFieldProductVariant()
    {
        AddField("productVariant");
        return this;
    }
}