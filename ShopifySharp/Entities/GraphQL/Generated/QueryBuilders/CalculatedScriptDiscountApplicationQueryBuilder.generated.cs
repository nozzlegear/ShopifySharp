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

public class CalculatedScriptDiscountApplicationQueryBuilder() : GraphQueryBuilder<CalculatedScriptDiscountApplication>("calculatedScriptDiscountApplication")
{
    public CalculatedScriptDiscountApplicationQueryBuilder AddFieldAllocationMethod()
    {
        AddField("allocationMethod");
        return this;
    }

    public CalculatedScriptDiscountApplicationQueryBuilder AddFieldAppliedTo()
    {
        AddField("appliedTo");
        return this;
    }

    public CalculatedScriptDiscountApplicationQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public CalculatedScriptDiscountApplicationQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CalculatedScriptDiscountApplicationQueryBuilder AddFieldTargetSelection()
    {
        AddField("targetSelection");
        return this;
    }

    public CalculatedScriptDiscountApplicationQueryBuilder AddFieldTargetType()
    {
        AddField("targetType");
        return this;
    }

    public CalculatedScriptDiscountApplicationQueryBuilder AddUnionCaseValue(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddUnion<MoneyV2, MoneyV2QueryBuilder>("value", build);
        return this;
    }

    public CalculatedScriptDiscountApplicationQueryBuilder AddUnionCaseValue(Func<PricingPercentageValueQueryBuilder, PricingPercentageValueQueryBuilder> build)
    {
        AddUnion<PricingPercentageValue, PricingPercentageValueQueryBuilder>("value", build);
        return this;
    }
}