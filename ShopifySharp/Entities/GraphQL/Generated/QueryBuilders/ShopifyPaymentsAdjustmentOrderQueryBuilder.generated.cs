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

public class ShopifyPaymentsAdjustmentOrderQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsAdjustmentOrder>("shopifyPaymentsAdjustmentOrder")
{
    public ShopifyPaymentsAdjustmentOrderQueryBuilder AddFieldAmount(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("amount", build);
        return this;
    }

    public ShopifyPaymentsAdjustmentOrderQueryBuilder AddFieldFees(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("fees", build);
        return this;
    }

    public ShopifyPaymentsAdjustmentOrderQueryBuilder AddFieldLink()
    {
        AddField("link");
        return this;
    }

    public ShopifyPaymentsAdjustmentOrderQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public ShopifyPaymentsAdjustmentOrderQueryBuilder AddFieldNet(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("net", build);
        return this;
    }

    public ShopifyPaymentsAdjustmentOrderQueryBuilder AddFieldOrderTransactionId()
    {
        AddField("orderTransactionId");
        return this;
    }
}