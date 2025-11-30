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

public class PriceRuleMoneyRangeQueryBuilder() : GraphQueryBuilder<PriceRuleMoneyRange>("priceRuleMoneyRange")
{
    public PriceRuleMoneyRangeQueryBuilder AddFieldGreaterThan()
    {
        AddField("greaterThan");
        return this;
    }

    public PriceRuleMoneyRangeQueryBuilder AddFieldGreaterThanOrEqualTo()
    {
        AddField("greaterThanOrEqualTo");
        return this;
    }

    public PriceRuleMoneyRangeQueryBuilder AddFieldLessThan()
    {
        AddField("lessThan");
        return this;
    }

    public PriceRuleMoneyRangeQueryBuilder AddFieldLessThanOrEqualTo()
    {
        AddField("lessThanOrEqualTo");
        return this;
    }
}