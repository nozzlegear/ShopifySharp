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

public class ExchangeV2LineItemQueryBuilder() : GraphQueryBuilder<ExchangeV2LineItem>("query exchangeV2LineItem")
{
    public ExchangeV2LineItemQueryBuilder AddFieldCustomAttributes()
    {
        AddField("customAttributes");
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldDiscountedTotalSet()
    {
        AddField("discountedTotalSet");
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldDiscountedUnitPriceSet()
    {
        AddField("discountedUnitPriceSet");
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldFulfillmentService()
    {
        AddField("fulfillmentService");
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldGiftCard()
    {
        AddField("giftCard");
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldGiftCards()
    {
        AddField("giftCards");
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldIsGiftCard()
    {
        AddField("isGiftCard");
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldLineItem()
    {
        AddField("lineItem");
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldOriginalTotalSet()
    {
        AddField("originalTotalSet");
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldOriginalUnitPriceSet()
    {
        AddField("originalUnitPriceSet");
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldRequiresShipping()
    {
        AddField("requiresShipping");
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldSku()
    {
        AddField("sku");
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldTaxable()
    {
        AddField("taxable");
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldTaxLines()
    {
        AddField("taxLines");
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldVariant()
    {
        AddField("variant");
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldVariantTitle()
    {
        AddField("variantTitle");
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldVendor()
    {
        AddField("vendor");
        return this;
    }
}