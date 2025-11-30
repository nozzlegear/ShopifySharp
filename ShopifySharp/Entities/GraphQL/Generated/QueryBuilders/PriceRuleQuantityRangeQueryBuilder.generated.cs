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

public class PriceRuleQuantityRangeQueryBuilder() : GraphQueryBuilder<PriceRuleQuantityRange>("priceRuleQuantityRange")
{
    public PriceRuleQuantityRangeQueryBuilder AddFieldGreaterThan()
    {
        AddField("greaterThan");
        return this;
    }

    public PriceRuleQuantityRangeQueryBuilder AddFieldGreaterThanOrEqualTo()
    {
        AddField("greaterThanOrEqualTo");
        return this;
    }

    public PriceRuleQuantityRangeQueryBuilder AddFieldLessThan()
    {
        AddField("lessThan");
        return this;
    }

    public PriceRuleQuantityRangeQueryBuilder AddFieldLessThanOrEqualTo()
    {
        AddField("lessThanOrEqualTo");
        return this;
    }
}