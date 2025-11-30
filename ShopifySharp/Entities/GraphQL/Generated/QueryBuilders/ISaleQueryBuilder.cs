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

public class ISaleQueryBuilder() : GraphQueryBuilder<ISale>("query iSale")
{
    public ISaleQueryBuilder AddFieldActionType()
    {
        AddField("actionType");
        return this;
    }

    public ISaleQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ISaleQueryBuilder AddFieldLineType()
    {
        AddField("lineType");
        return this;
    }

    public ISaleQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public ISaleQueryBuilder AddFieldTaxes()
    {
        AddField("taxes");
        return this;
    }

    public ISaleQueryBuilder AddFieldTotalAmount()
    {
        AddField("totalAmount");
        return this;
    }

    public ISaleQueryBuilder AddFieldTotalDiscountAmountAfterTaxes()
    {
        AddField("totalDiscountAmountAfterTaxes");
        return this;
    }

    public ISaleQueryBuilder AddFieldTotalDiscountAmountBeforeTaxes()
    {
        AddField("totalDiscountAmountBeforeTaxes");
        return this;
    }

    public ISaleQueryBuilder AddFieldTotalTaxAmount()
    {
        AddField("totalTaxAmount");
        return this;
    }
}