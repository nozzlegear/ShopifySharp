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

public class CalculatedReturnLineItemQueryBuilder() : GraphQueryBuilder<CalculatedReturnLineItem>("query calculatedReturnLineItem")
{
    public CalculatedReturnLineItemQueryBuilder AddFieldFulfillmentLineItem()
    {
        AddField("fulfillmentLineItem");
        return this;
    }

    public CalculatedReturnLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CalculatedReturnLineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public CalculatedReturnLineItemQueryBuilder AddFieldRestockingFee()
    {
        AddField("restockingFee");
        return this;
    }

    public CalculatedReturnLineItemQueryBuilder AddFieldSubtotalBeforeOrderDiscountsSet()
    {
        AddField("subtotalBeforeOrderDiscountsSet");
        return this;
    }

    public CalculatedReturnLineItemQueryBuilder AddFieldSubtotalSet()
    {
        AddField("subtotalSet");
        return this;
    }

    public CalculatedReturnLineItemQueryBuilder AddFieldTotalTaxSet()
    {
        AddField("totalTaxSet");
        return this;
    }
}