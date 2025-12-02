#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ExchangeV2LineItemQueryBuilder() : GraphQueryBuilder<ExchangeV2LineItem>("exchangeV2LineItem")
{
    public ExchangeV2LineItemQueryBuilder AddFieldCustomAttributes(Func<AttributeQueryBuilder, AttributeQueryBuilder> build)
    {
        AddField<ShopifySharp.GraphQL.Attribute, AttributeQueryBuilder>("customAttributes", build);
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldDiscountedTotalSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("discountedTotalSet", build);
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldDiscountedUnitPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("discountedUnitPriceSet", build);
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldFulfillmentService(Func<FulfillmentServiceQueryBuilder, FulfillmentServiceQueryBuilder> build)
    {
        AddField<FulfillmentService, FulfillmentServiceQueryBuilder>("fulfillmentService", build);
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldGiftCard()
    {
        AddField("giftCard");
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldGiftCards(Func<GiftCardQueryBuilder, GiftCardQueryBuilder> build)
    {
        AddField<GiftCard, GiftCardQueryBuilder>("giftCards", build);
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldIsGiftCard()
    {
        AddField("isGiftCard");
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldLineItem(Func<LineItemQueryBuilder, LineItemQueryBuilder> build)
    {
        AddField<LineItem, LineItemQueryBuilder>("lineItem", build);
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldOriginalTotalSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("originalTotalSet", build);
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldOriginalUnitPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("originalUnitPriceSet", build);
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

    public ExchangeV2LineItemQueryBuilder AddFieldTaxLines(Func<TaxLineQueryBuilder, TaxLineQueryBuilder> build)
    {
        AddField<TaxLine, TaxLineQueryBuilder>("taxLines", build);
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public ExchangeV2LineItemQueryBuilder AddFieldVariant(Func<ProductVariantQueryBuilder, ProductVariantQueryBuilder> build)
    {
        AddField<ProductVariant, ProductVariantQueryBuilder>("variant", build);
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