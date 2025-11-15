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

public class IReturnLineItemTypeQueryBuilder() : GraphQueryBuilder<IReturnLineItemType>("query iReturnLineItemType")
{
    public IReturnLineItemTypeQueryBuilder AddFieldCustomerNote()
    {
        AddField("customerNote");
        return this;
    }

    public IReturnLineItemTypeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public IReturnLineItemTypeQueryBuilder AddFieldProcessableQuantity()
    {
        AddField("processableQuantity");
        return this;
    }

    public IReturnLineItemTypeQueryBuilder AddFieldProcessedQuantity()
    {
        AddField("processedQuantity");
        return this;
    }

    public IReturnLineItemTypeQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public IReturnLineItemTypeQueryBuilder AddFieldRefundableQuantity()
    {
        AddField("refundableQuantity");
        return this;
    }

    public IReturnLineItemTypeQueryBuilder AddFieldRefundedQuantity()
    {
        AddField("refundedQuantity");
        return this;
    }

    public IReturnLineItemTypeQueryBuilder AddFieldReturnReason()
    {
        AddField("returnReason");
        return this;
    }

    public IReturnLineItemTypeQueryBuilder AddFieldReturnReasonNote()
    {
        AddField("returnReasonNote");
        return this;
    }

    public IReturnLineItemTypeQueryBuilder AddFieldUnprocessedQuantity()
    {
        AddField("unprocessedQuantity");
        return this;
    }
}