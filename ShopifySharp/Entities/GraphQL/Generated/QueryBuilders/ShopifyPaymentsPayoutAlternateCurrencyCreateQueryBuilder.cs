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

public class ShopifyPaymentsPayoutAlternateCurrencyCreateQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsPayoutAlternateCurrencyCreatePayload>("query shopifyPaymentsPayoutAlternateCurrencyCreate")
{
    public ShopifyPaymentsPayoutAlternateCurrencyCreateQueryBuilder AddArgumentAccountId(string? accountId)
    {
        AddArgument("accountId", accountId);
        return this;
    }

    public ShopifyPaymentsPayoutAlternateCurrencyCreateQueryBuilder AddArgumentCurrency(CurrencyCode? currency)
    {
        AddArgument("currency", currency);
        return this;
    }
}