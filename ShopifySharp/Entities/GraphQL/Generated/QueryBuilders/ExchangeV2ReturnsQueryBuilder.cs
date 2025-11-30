#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ExchangeV2ReturnsQueryBuilder() : GraphQueryBuilder<ExchangeV2Returns>("query exchangeV2Returns")
{
    public ExchangeV2ReturnsQueryBuilder AddFieldLineItems()
    {
        AddField("lineItems");
        return this;
    }

    public ExchangeV2ReturnsQueryBuilder AddFieldOrderDiscountAmountSet()
    {
        AddField("orderDiscountAmountSet");
        return this;
    }

    public ExchangeV2ReturnsQueryBuilder AddFieldShippingRefundAmountSet()
    {
        AddField("shippingRefundAmountSet");
        return this;
    }

    public ExchangeV2ReturnsQueryBuilder AddFieldSubtotalPriceSet()
    {
        AddField("subtotalPriceSet");
        return this;
    }

    public ExchangeV2ReturnsQueryBuilder AddFieldTaxLines()
    {
        AddField("taxLines");
        return this;
    }

    public ExchangeV2ReturnsQueryBuilder AddFieldTipRefundAmountSet()
    {
        AddField("tipRefundAmountSet");
        return this;
    }

    public ExchangeV2ReturnsQueryBuilder AddFieldTotalPriceSet()
    {
        AddField("totalPriceSet");
        return this;
    }
}