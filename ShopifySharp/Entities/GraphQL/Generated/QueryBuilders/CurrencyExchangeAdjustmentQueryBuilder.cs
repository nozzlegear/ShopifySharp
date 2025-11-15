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

public class CurrencyExchangeAdjustmentQueryBuilder() : GraphQueryBuilder<CurrencyExchangeAdjustment>("query currencyExchangeAdjustment")
{
    public CurrencyExchangeAdjustmentQueryBuilder AddFieldAdjustment()
    {
        AddField("adjustment");
        return this;
    }

    public CurrencyExchangeAdjustmentQueryBuilder AddFieldFinalAmountSet()
    {
        AddField("finalAmountSet");
        return this;
    }

    public CurrencyExchangeAdjustmentQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CurrencyExchangeAdjustmentQueryBuilder AddFieldOriginalAmountSet()
    {
        AddField("originalAmountSet");
        return this;
    }
}