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

public class MoneyV2QueryBuilder() : GraphQueryBuilder<MoneyV2>("query moneyV2")
{
    public MoneyV2QueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public MoneyV2QueryBuilder AddFieldCurrencyCode()
    {
        AddField("currencyCode");
        return this;
    }
}