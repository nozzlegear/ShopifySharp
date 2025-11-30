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

public class GiftCardDebitPayloadQueryBuilder() : GraphQueryBuilder<GiftCardDebitPayload>("query giftCardDebitPayload")
{
    public GiftCardDebitPayloadQueryBuilder AddFieldGiftCardDebitTransaction()
    {
        AddField("giftCardDebitTransaction");
        return this;
    }

    public GiftCardDebitPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}