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

public class AdditionalFeeQueryBuilder() : GraphQueryBuilder<AdditionalFee>("additionalFee")
{
    public AdditionalFeeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public AdditionalFeeQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public AdditionalFeeQueryBuilder AddFieldPrice(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("price", build);
        return this;
    }

    public AdditionalFeeQueryBuilder AddFieldTaxLines(Func<TaxLineQueryBuilder, TaxLineQueryBuilder> build)
    {
        AddField<TaxLine, TaxLineQueryBuilder>("taxLines", build);
        return this;
    }
}