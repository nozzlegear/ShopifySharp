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

public class ReturnLineItemQueryBuilder() : GraphQueryBuilder<ReturnLineItem>("query returnLineItem")
{
    public ReturnLineItemQueryBuilder AddFieldCustomerNote()
    {
        AddField("customerNote");
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldFulfillmentLineItem()
    {
        AddField("fulfillmentLineItem");
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldProcessableQuantity()
    {
        AddField("processableQuantity");
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldProcessedQuantity()
    {
        AddField("processedQuantity");
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldRefundableQuantity()
    {
        AddField("refundableQuantity");
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldRefundedQuantity()
    {
        AddField("refundedQuantity");
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldRestockingFee()
    {
        AddField("restockingFee");
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldReturnReason()
    {
        AddField("returnReason");
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldReturnReasonNote()
    {
        AddField("returnReasonNote");
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldTotalWeight()
    {
        AddField("totalWeight");
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldUnprocessedQuantity()
    {
        AddField("unprocessedQuantity");
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldWithCodeDiscountedTotalPriceSet()
    {
        AddField("withCodeDiscountedTotalPriceSet");
        return this;
    }
}