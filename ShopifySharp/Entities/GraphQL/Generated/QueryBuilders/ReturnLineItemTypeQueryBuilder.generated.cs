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

public class ReturnLineItemTypeQueryBuilder() : GraphQueryBuilder<IReturnLineItemType>("returnLineItemType")
{
    public ReturnLineItemTypeQueryBuilder AddFieldCustomerNote()
    {
        AddField("customerNote");
        return this;
    }

    public ReturnLineItemTypeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ReturnLineItemTypeQueryBuilder AddFieldProcessableQuantity()
    {
        AddField("processableQuantity");
        return this;
    }

    public ReturnLineItemTypeQueryBuilder AddFieldProcessedQuantity()
    {
        AddField("processedQuantity");
        return this;
    }

    public ReturnLineItemTypeQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public ReturnLineItemTypeQueryBuilder AddFieldRefundableQuantity()
    {
        AddField("refundableQuantity");
        return this;
    }

    public ReturnLineItemTypeQueryBuilder AddFieldRefundedQuantity()
    {
        AddField("refundedQuantity");
        return this;
    }

    public ReturnLineItemTypeQueryBuilder AddFieldReturnReason()
    {
        AddField("returnReason");
        return this;
    }

    public ReturnLineItemTypeQueryBuilder AddFieldReturnReasonNote()
    {
        AddField("returnReasonNote");
        return this;
    }

    public ReturnLineItemTypeQueryBuilder AddFieldUnprocessedQuantity()
    {
        AddField("unprocessedQuantity");
        return this;
    }
}