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

public class ExchangeV2AdditionsQueryBuilder() : GraphQueryBuilder<ExchangeV2Additions>("query exchangeV2Additions")
{
    public ExchangeV2AdditionsQueryBuilder AddFieldLineItems()
    {
        AddField("lineItems");
        return this;
    }

    public ExchangeV2AdditionsQueryBuilder AddFieldSubtotalPriceSet()
    {
        AddField("subtotalPriceSet");
        return this;
    }

    public ExchangeV2AdditionsQueryBuilder AddFieldTaxLines()
    {
        AddField("taxLines");
        return this;
    }

    public ExchangeV2AdditionsQueryBuilder AddFieldTotalPriceSet()
    {
        AddField("totalPriceSet");
        return this;
    }
}