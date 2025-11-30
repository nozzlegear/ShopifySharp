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

public class GiftCardDebitQueryBuilder() : GraphQueryBuilder<GiftCardDebitPayload>("query giftCardDebit")
{
    public GiftCardDebitQueryBuilder AddArgumentDebitInput(GiftCardDebitInput? debitInput)
    {
        AddArgument("debitInput", debitInput);
        return this;
    }

    public GiftCardDebitQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}