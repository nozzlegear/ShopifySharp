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

public class ShopifyPaymentsBalanceTransactionQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsBalanceTransaction>("shopifyPaymentsBalanceTransaction")
{
    public ShopifyPaymentsBalanceTransactionQueryBuilder AddFieldAdjustmentReason()
    {
        AddField("adjustmentReason");
        return this;
    }

    public ShopifyPaymentsBalanceTransactionQueryBuilder AddFieldAdjustmentsOrders(Func<ShopifyPaymentsAdjustmentOrderQueryBuilder, ShopifyPaymentsAdjustmentOrderQueryBuilder> build)
    {
        AddField<ShopifyPaymentsAdjustmentOrder, ShopifyPaymentsAdjustmentOrderQueryBuilder>("adjustmentsOrders", build);
        return this;
    }

    public ShopifyPaymentsBalanceTransactionQueryBuilder AddFieldAmount(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("amount", build);
        return this;
    }

    public ShopifyPaymentsBalanceTransactionQueryBuilder AddFieldAssociatedOrder(Func<ShopifyPaymentsAssociatedOrderQueryBuilder, ShopifyPaymentsAssociatedOrderQueryBuilder> build)
    {
        AddField<ShopifyPaymentsAssociatedOrder, ShopifyPaymentsAssociatedOrderQueryBuilder>("associatedOrder", build);
        return this;
    }

    public ShopifyPaymentsBalanceTransactionQueryBuilder AddFieldAssociatedPayout(Func<ShopifyPaymentsBalanceTransactionAssociatedPayoutQueryBuilder, ShopifyPaymentsBalanceTransactionAssociatedPayoutQueryBuilder> build)
    {
        AddField<ShopifyPaymentsBalanceTransactionAssociatedPayout, ShopifyPaymentsBalanceTransactionAssociatedPayoutQueryBuilder>("associatedPayout", build);
        return this;
    }

    public ShopifyPaymentsBalanceTransactionQueryBuilder AddFieldFee(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("fee", build);
        return this;
    }

    public ShopifyPaymentsBalanceTransactionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ShopifyPaymentsBalanceTransactionQueryBuilder AddFieldNet(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("net", build);
        return this;
    }

    public ShopifyPaymentsBalanceTransactionQueryBuilder AddFieldSourceId()
    {
        AddField("sourceId");
        return this;
    }

    public ShopifyPaymentsBalanceTransactionQueryBuilder AddFieldSourceOrderTransactionId()
    {
        AddField("sourceOrderTransactionId");
        return this;
    }

    public ShopifyPaymentsBalanceTransactionQueryBuilder AddFieldSourceType()
    {
        AddField("sourceType");
        return this;
    }

    public ShopifyPaymentsBalanceTransactionQueryBuilder AddFieldTest()
    {
        AddField("test");
        return this;
    }

    public ShopifyPaymentsBalanceTransactionQueryBuilder AddFieldTransactionDate()
    {
        AddField("transactionDate");
        return this;
    }

    public ShopifyPaymentsBalanceTransactionQueryBuilder AddFieldType()
    {
        AddField("type");
        return this;
    }
}