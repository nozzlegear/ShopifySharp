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

public class CalculatedAutomaticDiscountApplicationQueryBuilder() : GraphQueryBuilder<CalculatedAutomaticDiscountApplication>("calculatedAutomaticDiscountApplication")
{
    public CalculatedAutomaticDiscountApplicationQueryBuilder AddFieldAllocationMethod()
    {
        AddField("allocationMethod");
        return this;
    }

    public CalculatedAutomaticDiscountApplicationQueryBuilder AddFieldAppliedTo()
    {
        AddField("appliedTo");
        return this;
    }

    public CalculatedAutomaticDiscountApplicationQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public CalculatedAutomaticDiscountApplicationQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CalculatedAutomaticDiscountApplicationQueryBuilder AddFieldTargetSelection()
    {
        AddField("targetSelection");
        return this;
    }

    public CalculatedAutomaticDiscountApplicationQueryBuilder AddFieldTargetType()
    {
        AddField("targetType");
        return this;
    }

    public CalculatedAutomaticDiscountApplicationQueryBuilder AddUnionCaseValue(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddUnion<MoneyV2, MoneyV2QueryBuilder>("value", build);
        return this;
    }

    public CalculatedAutomaticDiscountApplicationQueryBuilder AddUnionCaseValue(Func<PricingPercentageValueQueryBuilder, PricingPercentageValueQueryBuilder> build)
    {
        AddUnion<PricingPercentageValue, PricingPercentageValueQueryBuilder>("value", build);
        return this;
    }
}