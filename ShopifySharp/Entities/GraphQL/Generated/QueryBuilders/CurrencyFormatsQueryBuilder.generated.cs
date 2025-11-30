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

public class CurrencyFormatsQueryBuilder() : GraphQueryBuilder<CurrencyFormats>("currencyFormats")
{
    public CurrencyFormatsQueryBuilder AddFieldMoneyFormat()
    {
        AddField("moneyFormat");
        return this;
    }

    public CurrencyFormatsQueryBuilder AddFieldMoneyInEmailsFormat()
    {
        AddField("moneyInEmailsFormat");
        return this;
    }

    public CurrencyFormatsQueryBuilder AddFieldMoneyWithCurrencyFormat()
    {
        AddField("moneyWithCurrencyFormat");
        return this;
    }

    public CurrencyFormatsQueryBuilder AddFieldMoneyWithCurrencyInEmailsFormat()
    {
        AddField("moneyWithCurrencyInEmailsFormat");
        return this;
    }
}