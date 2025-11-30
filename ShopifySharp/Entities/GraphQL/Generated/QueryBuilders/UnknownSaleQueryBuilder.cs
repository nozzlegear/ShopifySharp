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

public class UnknownSaleQueryBuilder() : GraphQueryBuilder<UnknownSale>("query unknownSale")
{
    public UnknownSaleQueryBuilder AddFieldActionType()
    {
        AddField("actionType");
        return this;
    }

    public UnknownSaleQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public UnknownSaleQueryBuilder AddFieldLineType()
    {
        AddField("lineType");
        return this;
    }

    public UnknownSaleQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public UnknownSaleQueryBuilder AddFieldTaxes()
    {
        AddField("taxes");
        return this;
    }

    public UnknownSaleQueryBuilder AddFieldTotalAmount()
    {
        AddField("totalAmount");
        return this;
    }

    public UnknownSaleQueryBuilder AddFieldTotalDiscountAmountAfterTaxes()
    {
        AddField("totalDiscountAmountAfterTaxes");
        return this;
    }

    public UnknownSaleQueryBuilder AddFieldTotalDiscountAmountBeforeTaxes()
    {
        AddField("totalDiscountAmountBeforeTaxes");
        return this;
    }

    public UnknownSaleQueryBuilder AddFieldTotalTaxAmount()
    {
        AddField("totalTaxAmount");
        return this;
    }
}