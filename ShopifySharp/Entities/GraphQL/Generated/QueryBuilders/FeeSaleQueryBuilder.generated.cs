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

public class FeeSaleQueryBuilder() : GraphQueryBuilder<FeeSale>("feeSale")
{
    public FeeSaleQueryBuilder AddFieldActionType()
    {
        AddField("actionType");
        return this;
    }

    public FeeSaleQueryBuilder AddFieldFee(Func<FeeQueryBuilder, FeeQueryBuilder> build)
    {
        AddField<IFee, FeeQueryBuilder>("fee", build);
        return this;
    }

    public FeeSaleQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public FeeSaleQueryBuilder AddFieldLineType()
    {
        AddField("lineType");
        return this;
    }

    public FeeSaleQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public FeeSaleQueryBuilder AddFieldTaxes(Func<SaleTaxQueryBuilder, SaleTaxQueryBuilder> build)
    {
        AddField<SaleTax, SaleTaxQueryBuilder>("taxes", build);
        return this;
    }

    public FeeSaleQueryBuilder AddFieldTotalAmount(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalAmount", build);
        return this;
    }

    public FeeSaleQueryBuilder AddFieldTotalDiscountAmountAfterTaxes(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalDiscountAmountAfterTaxes", build);
        return this;
    }

    public FeeSaleQueryBuilder AddFieldTotalDiscountAmountBeforeTaxes(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalDiscountAmountBeforeTaxes", build);
        return this;
    }

    public FeeSaleQueryBuilder AddFieldTotalTaxAmount(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalTaxAmount", build);
        return this;
    }
}