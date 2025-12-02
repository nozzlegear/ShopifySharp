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

public class GiftCardSendNotificationToRecipientPayloadQueryBuilder() : GraphQueryBuilder<GiftCardSendNotificationToRecipientPayload>("giftCardSendNotificationToRecipientPayload")
{
    public GiftCardSendNotificationToRecipientPayloadQueryBuilder AddFieldGiftCard(Func<GiftCardQueryBuilder, GiftCardQueryBuilder> build)
    {
        AddField<GiftCard, GiftCardQueryBuilder>("giftCard", build);
        return this;
    }

    public GiftCardSendNotificationToRecipientPayloadQueryBuilder AddFieldUserErrors(Func<GiftCardSendNotificationToRecipientUserErrorQueryBuilder, GiftCardSendNotificationToRecipientUserErrorQueryBuilder> build)
    {
        AddField<GiftCardSendNotificationToRecipientUserError, GiftCardSendNotificationToRecipientUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}