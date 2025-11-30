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

public class DutySaleQueryBuilder() : GraphQueryBuilder<DutySale>("dutySale")
{
    public DutySaleQueryBuilder AddFieldActionType()
    {
        AddField("actionType");
        return this;
    }

    public DutySaleQueryBuilder AddFieldDuty(Func<DutyQueryBuilder, DutyQueryBuilder> build)
    {
        AddField<Duty, DutyQueryBuilder>("duty", build);
        return this;
    }

    public DutySaleQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DutySaleQueryBuilder AddFieldLineType()
    {
        AddField("lineType");
        return this;
    }

    public DutySaleQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public DutySaleQueryBuilder AddFieldTaxes(Func<SaleTaxQueryBuilder, SaleTaxQueryBuilder> build)
    {
        AddField<SaleTax, SaleTaxQueryBuilder>("taxes", build);
        return this;
    }

    public DutySaleQueryBuilder AddFieldTotalAmount(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalAmount", build);
        return this;
    }

    public DutySaleQueryBuilder AddFieldTotalDiscountAmountAfterTaxes(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalDiscountAmountAfterTaxes", build);
        return this;
    }

    public DutySaleQueryBuilder AddFieldTotalDiscountAmountBeforeTaxes(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalDiscountAmountBeforeTaxes", build);
        return this;
    }

    public DutySaleQueryBuilder AddFieldTotalTaxAmount(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalTaxAmount", build);
        return this;
    }
}