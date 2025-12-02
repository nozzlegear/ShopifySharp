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

public class GiftCardSaleQueryBuilder() : GraphQueryBuilder<GiftCardSale>("giftCardSale")
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

    public GiftCardSaleQueryBuilder AddFieldLineItem(Func<LineItemQueryBuilder, LineItemQueryBuilder> build)
    {
        AddField<LineItem, LineItemQueryBuilder>("lineItem", build);
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

    public GiftCardSaleQueryBuilder AddFieldTaxes(Func<SaleTaxQueryBuilder, SaleTaxQueryBuilder> build)
    {
        AddField<SaleTax, SaleTaxQueryBuilder>("taxes", build);
        return this;
    }

    public GiftCardSaleQueryBuilder AddFieldTotalAmount(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalAmount", build);
        return this;
    }

    public GiftCardSaleQueryBuilder AddFieldTotalDiscountAmountAfterTaxes(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalDiscountAmountAfterTaxes", build);
        return this;
    }

    public GiftCardSaleQueryBuilder AddFieldTotalDiscountAmountBeforeTaxes(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalDiscountAmountBeforeTaxes", build);
        return this;
    }

    public GiftCardSaleQueryBuilder AddFieldTotalTaxAmount(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalTaxAmount", build);
        return this;
    }
}