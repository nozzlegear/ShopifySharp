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

public class AdditionalFeeSaleQueryBuilder() : GraphQueryBuilder<AdditionalFeeSale>("additionalFeeSale")
{
    public AdditionalFeeSaleQueryBuilder AddFieldActionType()
    {
        AddField("actionType");
        return this;
    }

    public AdditionalFeeSaleQueryBuilder AddFieldAdditionalFee(Func<SaleAdditionalFeeQueryBuilder, SaleAdditionalFeeQueryBuilder> build)
    {
        AddField<SaleAdditionalFee, SaleAdditionalFeeQueryBuilder>("additionalFee", build);
        return this;
    }

    public AdditionalFeeSaleQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public AdditionalFeeSaleQueryBuilder AddFieldLineType()
    {
        AddField("lineType");
        return this;
    }

    public AdditionalFeeSaleQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public AdditionalFeeSaleQueryBuilder AddFieldTaxes(Func<SaleTaxQueryBuilder, SaleTaxQueryBuilder> build)
    {
        AddField<SaleTax, SaleTaxQueryBuilder>("taxes", build);
        return this;
    }

    public AdditionalFeeSaleQueryBuilder AddFieldTotalAmount(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalAmount", build);
        return this;
    }

    public AdditionalFeeSaleQueryBuilder AddFieldTotalDiscountAmountAfterTaxes(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalDiscountAmountAfterTaxes", build);
        return this;
    }

    public AdditionalFeeSaleQueryBuilder AddFieldTotalDiscountAmountBeforeTaxes(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalDiscountAmountBeforeTaxes", build);
        return this;
    }

    public AdditionalFeeSaleQueryBuilder AddFieldTotalTaxAmount(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalTaxAmount", build);
        return this;
    }
}