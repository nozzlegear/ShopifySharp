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

public class GiftCardDebitPayloadQueryBuilder() : GraphQueryBuilder<GiftCardDebitPayload>("giftCardDebitPayload")
{
    public GiftCardDebitPayloadQueryBuilder AddFieldGiftCardDebitTransaction(Func<GiftCardDebitTransactionQueryBuilder, GiftCardDebitTransactionQueryBuilder> build)
    {
        AddField<GiftCardDebitTransaction, GiftCardDebitTransactionQueryBuilder>("giftCardDebitTransaction", build);
        return this;
    }

    public GiftCardDebitPayloadQueryBuilder AddFieldUserErrors(Func<GiftCardTransactionUserErrorQueryBuilder, GiftCardTransactionUserErrorQueryBuilder> build)
    {
        AddField<GiftCardTransactionUserError, GiftCardTransactionUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}