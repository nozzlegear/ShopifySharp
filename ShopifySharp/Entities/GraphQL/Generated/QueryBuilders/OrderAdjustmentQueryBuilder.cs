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

public class OrderAdjustmentQueryBuilder() : GraphQueryBuilder<OrderAdjustment>("query orderAdjustment")
{
    public OrderAdjustmentQueryBuilder AddFieldAmountSet()
    {
        AddField("amountSet");
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

    public OrderAdjustmentQueryBuilder AddFieldTaxAmountSet()
    {
        AddField("taxAmountSet");
        return this;
    }
}