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

public class GiftCardSendNotificationToRecipientPayloadQueryBuilder() : GraphQueryBuilder<GiftCardSendNotificationToRecipientPayload>("query giftCardSendNotificationToRecipientPayload")
{
    public GiftCardSendNotificationToRecipientPayloadQueryBuilder AddFieldGiftCard()
    {
        AddField("giftCard");
        return this;
    }

    public GiftCardSendNotificationToRecipientPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}