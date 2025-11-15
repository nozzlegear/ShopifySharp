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

public class AdditionalFeeSaleQueryBuilder() : GraphQueryBuilder<AdditionalFeeSale>("query additionalFeeSale")
{
    public AdditionalFeeSaleQueryBuilder AddFieldActionType()
    {
        AddField("actionType");
        return this;
    }

    public AdditionalFeeSaleQueryBuilder AddFieldAdditionalFee()
    {
        AddField("additionalFee");
        return this;
    }

    public AdditionalFeeSaleQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public AdditionalFeeSaleQueryBuilder AddFieldLineType()
    {
        AddField("lineType");
        return this;
    }

    public AdditionalFeeSaleQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public AdditionalFeeSaleQueryBuilder AddFieldTaxes()
    {
        AddField("taxes");
        return this;
    }

    public AdditionalFeeSaleQueryBuilder AddFieldTotalAmount()
    {
        AddField("totalAmount");
        return this;
    }

    public AdditionalFeeSaleQueryBuilder AddFieldTotalDiscountAmountAfterTaxes()
    {
        AddField("totalDiscountAmountAfterTaxes");
        return this;
    }

    public AdditionalFeeSaleQueryBuilder AddFieldTotalDiscountAmountBeforeTaxes()
    {
        AddField("totalDiscountAmountBeforeTaxes");
        return this;
    }

    public AdditionalFeeSaleQueryBuilder AddFieldTotalTaxAmount()
    {
        AddField("totalTaxAmount");
        return this;
    }
}