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

public class CalculatedDiscountApplicationQueryBuilder() : GraphQueryBuilder<ICalculatedDiscountApplication>("calculatedDiscountApplication")
{
    public CalculatedDiscountApplicationQueryBuilder AddFieldAllocationMethod()
    {
        AddField("allocationMethod");
        return this;
    }

    public CalculatedDiscountApplicationQueryBuilder AddFieldAppliedTo()
    {
        AddField("appliedTo");
        return this;
    }

    public CalculatedDiscountApplicationQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public CalculatedDiscountApplicationQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CalculatedDiscountApplicationQueryBuilder AddFieldTargetSelection()
    {
        AddField("targetSelection");
        return this;
    }

    public CalculatedDiscountApplicationQueryBuilder AddFieldTargetType()
    {
        AddField("targetType");
        return this;
    }

    public CalculatedDiscountApplicationQueryBuilder AddUnionCaseValue(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddUnion<MoneyV2, MoneyV2QueryBuilder>("value", build);
        return this;
    }

    public CalculatedDiscountApplicationQueryBuilder AddUnionCaseValue(Func<PricingPercentageValueQueryBuilder, PricingPercentageValueQueryBuilder> build)
    {
        AddUnion<PricingPercentageValue, PricingPercentageValueQueryBuilder>("value", build);
        return this;
    }
}