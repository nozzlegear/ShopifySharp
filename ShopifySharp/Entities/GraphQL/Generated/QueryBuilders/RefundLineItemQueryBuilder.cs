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

public class RefundLineItemQueryBuilder() : GraphQueryBuilder<RefundLineItem>("query refundLineItem")
{
    public RefundLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public RefundLineItemQueryBuilder AddFieldLineItem()
    {
        AddField("lineItem");
        return this;
    }

    public RefundLineItemQueryBuilder AddFieldLocation()
    {
        AddField("location");
        return this;
    }

    [Obsolete("Use `priceSet` instead.")]
    public RefundLineItemQueryBuilder AddFieldPrice()
    {
        AddField("price");
        return this;
    }

    public RefundLineItemQueryBuilder AddFieldPriceSet()
    {
        AddField("priceSet");
        return this;
    }

    public RefundLineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public RefundLineItemQueryBuilder AddFieldRestocked()
    {
        AddField("restocked");
        return this;
    }

    public RefundLineItemQueryBuilder AddFieldRestockType()
    {
        AddField("restockType");
        return this;
    }

    [Obsolete("Use `subtotalSet` instead.")]
    public RefundLineItemQueryBuilder AddFieldSubtotal()
    {
        AddField("subtotal");
        return this;
    }

    public RefundLineItemQueryBuilder AddFieldSubtotalSet()
    {
        AddField("subtotalSet");
        return this;
    }

    [Obsolete("Use `totalTaxSet` instead.")]
    public RefundLineItemQueryBuilder AddFieldTotalTax()
    {
        AddField("totalTax");
        return this;
    }

    public RefundLineItemQueryBuilder AddFieldTotalTaxSet()
    {
        AddField("totalTaxSet");
        return this;
    }
}