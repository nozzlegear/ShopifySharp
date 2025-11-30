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

public class UnverifiedReturnLineItemQueryBuilder() : GraphQueryBuilder<UnverifiedReturnLineItem>("query unverifiedReturnLineItem")
{
    public UnverifiedReturnLineItemQueryBuilder AddFieldCustomerNote()
    {
        AddField("customerNote");
        return this;
    }

    public UnverifiedReturnLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public UnverifiedReturnLineItemQueryBuilder AddFieldProcessableQuantity()
    {
        AddField("processableQuantity");
        return this;
    }

    public UnverifiedReturnLineItemQueryBuilder AddFieldProcessedQuantity()
    {
        AddField("processedQuantity");
        return this;
    }

    public UnverifiedReturnLineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public UnverifiedReturnLineItemQueryBuilder AddFieldRefundableQuantity()
    {
        AddField("refundableQuantity");
        return this;
    }

    public UnverifiedReturnLineItemQueryBuilder AddFieldRefundedQuantity()
    {
        AddField("refundedQuantity");
        return this;
    }

    public UnverifiedReturnLineItemQueryBuilder AddFieldReturnReason()
    {
        AddField("returnReason");
        return this;
    }

    public UnverifiedReturnLineItemQueryBuilder AddFieldReturnReasonNote()
    {
        AddField("returnReasonNote");
        return this;
    }

    public UnverifiedReturnLineItemQueryBuilder AddFieldUnitPrice()
    {
        AddField("unitPrice");
        return this;
    }

    public UnverifiedReturnLineItemQueryBuilder AddFieldUnprocessedQuantity()
    {
        AddField("unprocessedQuantity");
        return this;
    }
}