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

public class OrderAdjustmentQueryBuilder() : GraphQueryBuilder<OrderAdjustment>("orderAdjustment")
{
    public OrderAdjustmentQueryBuilder AddFieldAmountSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("amountSet", build);
        return this;
    }

    public OrderAdjustmentQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public OrderAdjustmentQueryBuilder AddFieldReason()
    {
        AddField("reason");
        return this;
    }

    public OrderAdjustmentQueryBuilder AddFieldTaxAmountSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("taxAmountSet", build);
        return this;
    }
}