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

public class GiftCardRecipientQueryBuilder() : GraphQueryBuilder<GiftCardRecipient>("query giftCardRecipient")
{
    public GiftCardRecipientQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }

    public GiftCardRecipientQueryBuilder AddFieldPreferredName()
    {
        AddField("preferredName");
        return this;
    }

    public GiftCardRecipientQueryBuilder AddFieldRecipient()
    {
        AddField("recipient");
        return this;
    }

    public GiftCardRecipientQueryBuilder AddFieldSendNotificationAt()
    {
        AddField("sendNotificationAt");
        return this;
    }
}