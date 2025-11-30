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

public class ShippingLineSaleQueryBuilder() : GraphQueryBuilder<ShippingLineSale>("shippingLineSale")
{
    public ShippingLineSaleQueryBuilder AddFieldActionType()
    {
        AddField("actionType");
        return this;
    }

    public ShippingLineSaleQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ShippingLineSaleQueryBuilder AddFieldLineType()
    {
        AddField("lineType");
        return this;
    }

    public ShippingLineSaleQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public ShippingLineSaleQueryBuilder AddFieldShippingLine(Func<ShippingLineQueryBuilder, ShippingLineQueryBuilder> build)
    {
        AddField<ShippingLine, ShippingLineQueryBuilder>("shippingLine", build);
        return this;
    }

    public ShippingLineSaleQueryBuilder AddFieldTaxes(Func<SaleTaxQueryBuilder, SaleTaxQueryBuilder> build)
    {
        AddField<SaleTax, SaleTaxQueryBuilder>("taxes", build);
        return this;
    }

    public ShippingLineSaleQueryBuilder AddFieldTotalAmount(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalAmount", build);
        return this;
    }

    public ShippingLineSaleQueryBuilder AddFieldTotalDiscountAmountAfterTaxes(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalDiscountAmountAfterTaxes", build);
        return this;
    }

    public ShippingLineSaleQueryBuilder AddFieldTotalDiscountAmountBeforeTaxes(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalDiscountAmountBeforeTaxes", build);
        return this;
    }

    public ShippingLineSaleQueryBuilder AddFieldTotalTaxAmount(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalTaxAmount", build);
        return this;
    }
}