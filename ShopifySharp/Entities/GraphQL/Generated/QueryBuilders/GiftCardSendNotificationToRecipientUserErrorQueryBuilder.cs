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

public class GiftCardSendNotificationToRecipientUserErrorQueryBuilder() : GraphQueryBuilder<GiftCardSendNotificationToRecipientUserError>("query giftCardSendNotificationToRecipientUserError")
{
    public GiftCardSendNotificationToRecipientUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public GiftCardSendNotificationToRecipientUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public GiftCardSendNotificationToRecipientUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}