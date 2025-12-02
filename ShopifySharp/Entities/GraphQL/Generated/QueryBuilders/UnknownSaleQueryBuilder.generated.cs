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

public class UnknownSaleQueryBuilder() : GraphQueryBuilder<UnknownSale>("unknownSale")
{
    public UnknownSaleQueryBuilder AddFieldActionType()
    {
        AddField("actionType");
        return this;
    }

    public UnknownSaleQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public UnknownSaleQueryBuilder AddFieldLineType()
    {
        AddField("lineType");
        return this;
    }

    public UnknownSaleQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public UnknownSaleQueryBuilder AddFieldTaxes(Func<SaleTaxQueryBuilder, SaleTaxQueryBuilder> build)
    {
        AddField<SaleTax, SaleTaxQueryBuilder>("taxes", build);
        return this;
    }

    public UnknownSaleQueryBuilder AddFieldTotalAmount(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalAmount", build);
        return this;
    }

    public UnknownSaleQueryBuilder AddFieldTotalDiscountAmountAfterTaxes(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalDiscountAmountAfterTaxes", build);
        return this;
    }

    public UnknownSaleQueryBuilder AddFieldTotalDiscountAmountBeforeTaxes(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalDiscountAmountBeforeTaxes", build);
        return this;
    }

    public UnknownSaleQueryBuilder AddFieldTotalTaxAmount(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalTaxAmount", build);
        return this;
    }
}