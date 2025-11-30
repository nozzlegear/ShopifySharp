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

public class FeeSaleQueryBuilder() : GraphQueryBuilder<FeeSale>("query feeSale")
{
    public FeeSaleQueryBuilder AddFieldActionType()
    {
        AddField("actionType");
        return this;
    }

    public FeeSaleQueryBuilder AddFieldFee()
    {
        AddField("fee");
        return this;
    }

    public FeeSaleQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public FeeSaleQueryBuilder AddFieldLineType()
    {
        AddField("lineType");
        return this;
    }

    public FeeSaleQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public FeeSaleQueryBuilder AddFieldTaxes()
    {
        AddField("taxes");
        return this;
    }

    public FeeSaleQueryBuilder AddFieldTotalAmount()
    {
        AddField("totalAmount");
        return this;
    }

    public FeeSaleQueryBuilder AddFieldTotalDiscountAmountAfterTaxes()
    {
        AddField("totalDiscountAmountAfterTaxes");
        return this;
    }

    public FeeSaleQueryBuilder AddFieldTotalDiscountAmountBeforeTaxes()
    {
        AddField("totalDiscountAmountBeforeTaxes");
        return this;
    }

    public FeeSaleQueryBuilder AddFieldTotalTaxAmount()
    {
        AddField("totalTaxAmount");
        return this;
    }
}