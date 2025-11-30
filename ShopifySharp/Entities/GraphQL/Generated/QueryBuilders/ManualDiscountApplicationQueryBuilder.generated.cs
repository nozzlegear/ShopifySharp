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

public class ManualDiscountApplicationQueryBuilder() : GraphQueryBuilder<ManualDiscountApplication>("manualDiscountApplication")
{
    public ManualDiscountApplicationQueryBuilder AddFieldAllocationMethod()
    {
        AddField("allocationMethod");
        return this;
    }

    public ManualDiscountApplicationQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public ManualDiscountApplicationQueryBuilder AddFieldIndex()
    {
        AddField("index");
        return this;
    }

    public ManualDiscountApplicationQueryBuilder AddFieldTargetSelection()
    {
        AddField("targetSelection");
        return this;
    }

    public ManualDiscountApplicationQueryBuilder AddFieldTargetType()
    {
        AddField("targetType");
        return this;
    }

    public ManualDiscountApplicationQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public ManualDiscountApplicationQueryBuilder AddUnionCaseValue(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddUnion<MoneyV2, MoneyV2QueryBuilder>("value", build);
        return this;
    }

    public ManualDiscountApplicationQueryBuilder AddUnionCaseValue(Func<PricingPercentageValueQueryBuilder, PricingPercentageValueQueryBuilder> build)
    {
        AddUnion<PricingPercentageValue, PricingPercentageValueQueryBuilder>("value", build);
        return this;
    }
}