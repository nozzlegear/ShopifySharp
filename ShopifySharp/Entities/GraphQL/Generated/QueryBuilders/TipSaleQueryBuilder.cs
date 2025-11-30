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

public class TipSaleQueryBuilder() : GraphQueryBuilder<TipSale>("query tipSale")
{
    public TipSaleQueryBuilder AddFieldActionType()
    {
        AddField("actionType");
        return this;
    }

    public TipSaleQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public TipSaleQueryBuilder AddFieldLineItem()
    {
        AddField("lineItem");
        return this;
    }

    public TipSaleQueryBuilder AddFieldLineType()
    {
        AddField("lineType");
        return this;
    }

    public TipSaleQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public TipSaleQueryBuilder AddFieldTaxes()
    {
        AddField("taxes");
        return this;
    }

    public TipSaleQueryBuilder AddFieldTotalAmount()
    {
        AddField("totalAmount");
        return this;
    }

    public TipSaleQueryBuilder AddFieldTotalDiscountAmountAfterTaxes()
    {
        AddField("totalDiscountAmountAfterTaxes");
        return this;
    }

    public TipSaleQueryBuilder AddFieldTotalDiscountAmountBeforeTaxes()
    {
        AddField("totalDiscountAmountBeforeTaxes");
        return this;
    }

    public TipSaleQueryBuilder AddFieldTotalTaxAmount()
    {
        AddField("totalTaxAmount");
        return this;
    }
}