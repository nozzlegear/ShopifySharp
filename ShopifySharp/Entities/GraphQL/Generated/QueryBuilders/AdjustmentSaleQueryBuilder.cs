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

public class AdjustmentSaleQueryBuilder() : GraphQueryBuilder<AdjustmentSale>("query adjustmentSale")
{
    public AdjustmentSaleQueryBuilder AddFieldActionType()
    {
        AddField("actionType");
        return this;
    }

    public AdjustmentSaleQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public AdjustmentSaleQueryBuilder AddFieldLineType()
    {
        AddField("lineType");
        return this;
    }

    public AdjustmentSaleQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public AdjustmentSaleQueryBuilder AddFieldTaxes()
    {
        AddField("taxes");
        return this;
    }

    public AdjustmentSaleQueryBuilder AddFieldTotalAmount()
    {
        AddField("totalAmount");
        return this;
    }

    public AdjustmentSaleQueryBuilder AddFieldTotalDiscountAmountAfterTaxes()
    {
        AddField("totalDiscountAmountAfterTaxes");
        return this;
    }

    public AdjustmentSaleQueryBuilder AddFieldTotalDiscountAmountBeforeTaxes()
    {
        AddField("totalDiscountAmountBeforeTaxes");
        return this;
    }

    public AdjustmentSaleQueryBuilder AddFieldTotalTaxAmount()
    {
        AddField("totalTaxAmount");
        return this;
    }
}