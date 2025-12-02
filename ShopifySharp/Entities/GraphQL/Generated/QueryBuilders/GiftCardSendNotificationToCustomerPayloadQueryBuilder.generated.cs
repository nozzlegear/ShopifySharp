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

public class GiftCardSendNotificationToCustomerPayloadQueryBuilder() : GraphQueryBuilder<GiftCardSendNotificationToCustomerPayload>("giftCardSendNotificationToCustomerPayload")
{
    public GiftCardSendNotificationToCustomerPayloadQueryBuilder AddFieldGiftCard(Func<GiftCardQueryBuilder, GiftCardQueryBuilder> build)
    {
        AddField<GiftCard, GiftCardQueryBuilder>("giftCard", build);
        return this;
    }

    public GiftCardSendNotificationToCustomerPayloadQueryBuilder AddFieldUserErrors(Func<GiftCardSendNotificationToCustomerUserErrorQueryBuilder, GiftCardSendNotificationToCustomerUserErrorQueryBuilder> build)
    {
        AddField<GiftCardSendNotificationToCustomerUserError, GiftCardSendNotificationToCustomerUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}