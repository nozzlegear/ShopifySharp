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

public class GiftCardSendNotificationToCustomerPayloadQueryBuilder() : GraphQueryBuilder<GiftCardSendNotificationToCustomerPayload>("query giftCardSendNotificationToCustomerPayload")
{
    public GiftCardSendNotificationToCustomerPayloadQueryBuilder AddFieldGiftCard()
    {
        AddField("giftCard");
        return this;
    }

    public GiftCardSendNotificationToCustomerPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}