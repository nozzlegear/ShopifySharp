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

public class CalculatedManualDiscountApplicationQueryBuilder() : GraphQueryBuilder<CalculatedManualDiscountApplication>("calculatedManualDiscountApplication")
{
    public CalculatedManualDiscountApplicationQueryBuilder AddFieldAllocationMethod()
    {
        AddField("allocationMethod");
        return this;
    }

    public CalculatedManualDiscountApplicationQueryBuilder AddFieldAppliedTo()
    {
        AddField("appliedTo");
        return this;
    }

    public CalculatedManualDiscountApplicationQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public CalculatedManualDiscountApplicationQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CalculatedManualDiscountApplicationQueryBuilder AddFieldTargetSelection()
    {
        AddField("targetSelection");
        return this;
    }

    public CalculatedManualDiscountApplicationQueryBuilder AddFieldTargetType()
    {
        AddField("targetType");
        return this;
    }

    public CalculatedManualDiscountApplicationQueryBuilder AddUnionCaseValue(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddUnion<MoneyV2, MoneyV2QueryBuilder>("value", build);
        return this;
    }

    public CalculatedManualDiscountApplicationQueryBuilder AddUnionCaseValue(Func<PricingPercentageValueQueryBuilder, PricingPercentageValueQueryBuilder> build)
    {
        AddUnion<PricingPercentageValue, PricingPercentageValueQueryBuilder>("value", build);
        return this;
    }
}