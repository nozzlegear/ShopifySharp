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

public class GiftCardSaleQueryBuilder() : GraphQueryBuilder<GiftCardSale>("query giftCardSale")
{
    public GiftCardSaleQueryBuilder AddFieldActionType()
    {
        AddField("actionType");
        return this;
    }

    public GiftCardSaleQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public GiftCardSaleQueryBuilder AddFieldLineItem()
    {
        AddField("lineItem");
        return this;
    }

    public GiftCardSaleQueryBuilder AddFieldLineType()
    {
        AddField("lineType");
        return this;
    }

    public GiftCardSaleQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public GiftCardSaleQueryBuilder AddFieldTaxes()
    {
        AddField("taxes");
        return this;
    }

    public GiftCardSaleQueryBuilder AddFieldTotalAmount()
    {
        AddField("totalAmount");
        return this;
    }

    public GiftCardSaleQueryBuilder AddFieldTotalDiscountAmountAfterTaxes()
    {
        AddField("totalDiscountAmountAfterTaxes");
        return this;
    }

    public GiftCardSaleQueryBuilder AddFieldTotalDiscountAmountBeforeTaxes()
    {
        AddField("totalDiscountAmountBeforeTaxes");
        return this;
    }

    public GiftCardSaleQueryBuilder AddFieldTotalTaxAmount()
    {
        AddField("totalTaxAmount");
        return this;
    }
}