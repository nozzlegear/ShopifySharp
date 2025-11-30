#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ShopifyPaymentsBalanceTransactionQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsBalanceTransaction>("query shopifyPaymentsBalanceTransaction")
{
    public ShopifyPaymentsBalanceTransactionQueryBuilder AddFieldAdjustmentReason()
    {
        AddField("adjustmentReason");
        return this;
    }

    public ShopifyPaymentsBalanceTransactionQueryBuilder AddFieldAdjustmentsOrders()
    {
        AddField("adjustmentsOrders");
        return this;
    }

    public ShopifyPaymentsBalanceTransactionQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public ShopifyPaymentsBalanceTransactionQueryBuilder AddFieldAssociatedOrder()
    {
        AddField("associatedOrder");
        return this;
    }

    public ShopifyPaymentsBalanceTransactionQueryBuilder AddFieldAssociatedPayout()
    {
        AddField("associatedPayout");
        return this;
    }

    public ShopifyPaymentsBalanceTransactionQueryBuilder AddFieldFee()
    {
        AddField("fee");
        return this;
    }

    public ShopifyPaymentsBalanceTransactionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ShopifyPaymentsBalanceTransactionQueryBuilder AddFieldNet()
    {
        AddField("net");
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