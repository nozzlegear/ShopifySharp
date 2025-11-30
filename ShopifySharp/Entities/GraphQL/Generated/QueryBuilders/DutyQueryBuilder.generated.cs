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

public class DutyQueryBuilder() : GraphQueryBuilder<Duty>("duty")
{
    public DutyQueryBuilder AddFieldCountryCodeOfOrigin()
    {
        AddField("countryCodeOfOrigin");
        return this;
    }

    public DutyQueryBuilder AddFieldHarmonizedSystemCode()
    {
        AddField("harmonizedSystemCode");
        return this;
    }

    public DutyQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DutyQueryBuilder AddFieldPrice(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("price", build);
        return this;
    }

    public DutyQueryBuilder AddFieldTaxLines(Func<TaxLineQueryBuilder, TaxLineQueryBuilder> build)
    {
        AddField<TaxLine, TaxLineQueryBuilder>("taxLines", build);
        return this;
    }
}