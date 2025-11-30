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

public class SellingPlanCheckoutChargeQueryBuilder() : GraphQueryBuilder<SellingPlanCheckoutCharge>("sellingPlanCheckoutCharge")
{
    public SellingPlanCheckoutChargeQueryBuilder AddFieldType()
    {
        AddField("type");
        return this;
    }

    public SellingPlanCheckoutChargeQueryBuilder AddUnionCaseValue(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddUnion<MoneyV2, MoneyV2QueryBuilder>("value", build);
        return this;
    }

    public SellingPlanCheckoutChargeQueryBuilder AddUnionCaseValue(Func<SellingPlanCheckoutChargePercentageValueQueryBuilder, SellingPlanCheckoutChargePercentageValueQueryBuilder> build)
    {
        AddUnion<SellingPlanCheckoutChargePercentageValue, SellingPlanCheckoutChargePercentageValueQueryBuilder>("value", build);
        return this;
    }
}