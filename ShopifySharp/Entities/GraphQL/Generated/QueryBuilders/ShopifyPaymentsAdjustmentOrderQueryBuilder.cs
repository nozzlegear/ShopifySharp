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

public class ShopifyPaymentsAdjustmentOrderQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsAdjustmentOrder>("query shopifyPaymentsAdjustmentOrder")
{
    public ShopifyPaymentsAdjustmentOrderQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public ShopifyPaymentsAdjustmentOrderQueryBuilder AddFieldFees()
    {
        AddField("fees");
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

    public ShopifyPaymentsAdjustmentOrderQueryBuilder AddFieldNet()
    {
        AddField("net");
        return this;
    }

    public ShopifyPaymentsAdjustmentOrderQueryBuilder AddFieldOrderTransactionId()
    {
        AddField("orderTransactionId");
        return this;
    }
}