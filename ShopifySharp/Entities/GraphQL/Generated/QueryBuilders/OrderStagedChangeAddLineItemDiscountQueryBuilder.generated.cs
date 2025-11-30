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

public class OrderStagedChangeAddLineItemDiscountQueryBuilder() : GraphQueryBuilder<OrderStagedChangeAddLineItemDiscount>("orderStagedChangeAddLineItemDiscount")
{
    public OrderStagedChangeAddLineItemDiscountQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public OrderStagedChangeAddLineItemDiscountQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public OrderStagedChangeAddLineItemDiscountQueryBuilder AddUnionCaseValue(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddUnion<MoneyV2, MoneyV2QueryBuilder>("value", build);
        return this;
    }

    public OrderStagedChangeAddLineItemDiscountQueryBuilder AddUnionCaseValue(Func<PricingPercentageValueQueryBuilder, PricingPercentageValueQueryBuilder> build)
    {
        AddUnion<PricingPercentageValue, PricingPercentageValueQueryBuilder>("value", build);
        return this;
    }
}