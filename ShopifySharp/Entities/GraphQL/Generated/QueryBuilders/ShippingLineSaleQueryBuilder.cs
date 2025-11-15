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

public class ShippingLineSaleQueryBuilder() : GraphQueryBuilder<ShippingLineSale>("query shippingLineSale")
{
    public ShippingLineSaleQueryBuilder AddFieldActionType()
    {
        AddField("actionType");
        return this;
    }

    public ShippingLineSaleQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ShippingLineSaleQueryBuilder AddFieldLineType()
    {
        AddField("lineType");
        return this;
    }

    public ShippingLineSaleQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public ShippingLineSaleQueryBuilder AddFieldShippingLine()
    {
        AddField("shippingLine");
        return this;
    }

    public ShippingLineSaleQueryBuilder AddFieldTaxes()
    {
        AddField("taxes");
        return this;
    }

    public ShippingLineSaleQueryBuilder AddFieldTotalAmount()
    {
        AddField("totalAmount");
        return this;
    }

    public ShippingLineSaleQueryBuilder AddFieldTotalDiscountAmountAfterTaxes()
    {
        AddField("totalDiscountAmountAfterTaxes");
        return this;
    }

    public ShippingLineSaleQueryBuilder AddFieldTotalDiscountAmountBeforeTaxes()
    {
        AddField("totalDiscountAmountBeforeTaxes");
        return this;
    }

    public ShippingLineSaleQueryBuilder AddFieldTotalTaxAmount()
    {
        AddField("totalTaxAmount");
        return this;
    }
}