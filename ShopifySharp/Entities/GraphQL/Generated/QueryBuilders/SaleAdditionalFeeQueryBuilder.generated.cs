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

public class SaleAdditionalFeeQueryBuilder() : GraphQueryBuilder<SaleAdditionalFee>("saleAdditionalFee")
{
    public SaleAdditionalFeeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public SaleAdditionalFeeQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public SaleAdditionalFeeQueryBuilder AddFieldPrice(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("price", build);
        return this;
    }

    public SaleAdditionalFeeQueryBuilder AddFieldTaxLines(Func<TaxLineQueryBuilder, TaxLineQueryBuilder> build)
    {
        AddField<TaxLine, TaxLineQueryBuilder>("taxLines", build);
        return this;
    }
}