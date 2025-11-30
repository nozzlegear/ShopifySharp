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

public class GiftCardCreditPayloadQueryBuilder() : GraphQueryBuilder<GiftCardCreditPayload>("giftCardCreditPayload")
{
    public GiftCardCreditPayloadQueryBuilder AddFieldGiftCardCreditTransaction(Func<GiftCardCreditTransactionQueryBuilder, GiftCardCreditTransactionQueryBuilder> build)
    {
        AddField<GiftCardCreditTransaction, GiftCardCreditTransactionQueryBuilder>("giftCardCreditTransaction", build);
        return this;
    }

    public GiftCardCreditPayloadQueryBuilder AddFieldUserErrors(Func<GiftCardTransactionUserErrorQueryBuilder, GiftCardTransactionUserErrorQueryBuilder> build)
    {
        AddField<GiftCardTransactionUserError, GiftCardTransactionUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}