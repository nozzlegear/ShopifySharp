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

public class CurrencyExchangeAdjustmentQueryBuilder() : GraphQueryBuilder<CurrencyExchangeAdjustment>("currencyExchangeAdjustment")
{
    public CurrencyExchangeAdjustmentQueryBuilder AddFieldAdjustment(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("adjustment", build);
        return this;
    }

    public CurrencyExchangeAdjustmentQueryBuilder AddFieldFinalAmountSet(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("finalAmountSet", build);
        return this;
    }

    public CurrencyExchangeAdjustmentQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CurrencyExchangeAdjustmentQueryBuilder AddFieldOriginalAmountSet(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("originalAmountSet", build);
        return this;
    }
}