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

public class SaleTaxQueryBuilder() : GraphQueryBuilder<SaleTax>("saleTax")
{
    public SaleTaxQueryBuilder AddFieldAmount(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("amount", build);
        return this;
    }

    public SaleTaxQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public SaleTaxQueryBuilder AddFieldTaxLine(Func<TaxLineQueryBuilder, TaxLineQueryBuilder> build)
    {
        AddField<TaxLine, TaxLineQueryBuilder>("taxLine", build);
        return this;
    }
}