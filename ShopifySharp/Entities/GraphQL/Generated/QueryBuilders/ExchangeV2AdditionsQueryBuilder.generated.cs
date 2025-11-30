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

public class ExchangeV2AdditionsQueryBuilder() : GraphQueryBuilder<ExchangeV2Additions>("exchangeV2Additions")
{
    public ExchangeV2AdditionsQueryBuilder AddFieldLineItems(Func<ExchangeV2LineItemQueryBuilder, ExchangeV2LineItemQueryBuilder> build)
    {
        AddField<ExchangeV2LineItem, ExchangeV2LineItemQueryBuilder>("lineItems", build);
        return this;
    }

    public ExchangeV2AdditionsQueryBuilder AddFieldSubtotalPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("subtotalPriceSet", build);
        return this;
    }

    public ExchangeV2AdditionsQueryBuilder AddFieldTaxLines(Func<TaxLineQueryBuilder, TaxLineQueryBuilder> build)
    {
        AddField<TaxLine, TaxLineQueryBuilder>("taxLines", build);
        return this;
    }

    public ExchangeV2AdditionsQueryBuilder AddFieldTotalPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalPriceSet", build);
        return this;
    }
}