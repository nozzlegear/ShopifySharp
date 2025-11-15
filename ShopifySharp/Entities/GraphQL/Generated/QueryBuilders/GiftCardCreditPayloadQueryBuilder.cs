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

public class GiftCardCreditPayloadQueryBuilder() : GraphQueryBuilder<GiftCardCreditPayload>("query giftCardCreditPayload")
{
    public GiftCardCreditPayloadQueryBuilder AddFieldGiftCardCreditTransaction()
    {
        AddField("giftCardCreditTransaction");
        return this;
    }

    public GiftCardCreditPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}