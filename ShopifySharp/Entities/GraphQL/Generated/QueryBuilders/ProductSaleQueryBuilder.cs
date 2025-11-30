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

public class ProductSaleQueryBuilder() : GraphQueryBuilder<ProductSale>("query productSale")
{
    public ProductSaleQueryBuilder AddFieldActionType()
    {
        AddField("actionType");
        return this;
    }

    public ProductSaleQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ProductSaleQueryBuilder AddFieldLineItem()
    {
        AddField("lineItem");
        return this;
    }

    public ProductSaleQueryBuilder AddFieldLineType()
    {
        AddField("lineType");
        return this;
    }

    public ProductSaleQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public ProductSaleQueryBuilder AddFieldTaxes()
    {
        AddField("taxes");
        return this;
    }

    public ProductSaleQueryBuilder AddFieldTotalAmount()
    {
        AddField("totalAmount");
        return this;
    }

    public ProductSaleQueryBuilder AddFieldTotalDiscountAmountAfterTaxes()
    {
        AddField("totalDiscountAmountAfterTaxes");
        return this;
    }

    public ProductSaleQueryBuilder AddFieldTotalDiscountAmountBeforeTaxes()
    {
        AddField("totalDiscountAmountBeforeTaxes");
        return this;
    }

    public ProductSaleQueryBuilder AddFieldTotalTaxAmount()
    {
        AddField("totalTaxAmount");
        return this;
    }
}