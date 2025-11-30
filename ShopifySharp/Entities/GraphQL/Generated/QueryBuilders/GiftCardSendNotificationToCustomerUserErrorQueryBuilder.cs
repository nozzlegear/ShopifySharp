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

public class GiftCardSendNotificationToCustomerUserErrorQueryBuilder() : GraphQueryBuilder<GiftCardSendNotificationToCustomerUserError>("query giftCardSendNotificationToCustomerUserError")
{
    public GiftCardSendNotificationToCustomerUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public GiftCardSendNotificationToCustomerUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public GiftCardSendNotificationToCustomerUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}