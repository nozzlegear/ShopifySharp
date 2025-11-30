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

public class ExchangeV2ReturnsQueryBuilder() : GraphQueryBuilder<ExchangeV2Returns>("exchangeV2Returns")
{
    public ExchangeV2ReturnsQueryBuilder AddFieldLineItems(Func<ExchangeV2LineItemQueryBuilder, ExchangeV2LineItemQueryBuilder> build)
    {
        AddField<ExchangeV2LineItem, ExchangeV2LineItemQueryBuilder>("lineItems", build);
        return this;
    }

    public ExchangeV2ReturnsQueryBuilder AddFieldOrderDiscountAmountSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("orderDiscountAmountSet", build);
        return this;
    }

    public ExchangeV2ReturnsQueryBuilder AddFieldShippingRefundAmountSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("shippingRefundAmountSet", build);
        return this;
    }

    public ExchangeV2ReturnsQueryBuilder AddFieldSubtotalPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("subtotalPriceSet", build);
        return this;
    }

    public ExchangeV2ReturnsQueryBuilder AddFieldTaxLines(Func<TaxLineQueryBuilder, TaxLineQueryBuilder> build)
    {
        AddField<TaxLine, TaxLineQueryBuilder>("taxLines", build);
        return this;
    }

    public ExchangeV2ReturnsQueryBuilder AddFieldTipRefundAmountSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("tipRefundAmountSet", build);
        return this;
    }

    public ExchangeV2ReturnsQueryBuilder AddFieldTotalPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalPriceSet", build);
        return this;
    }
}