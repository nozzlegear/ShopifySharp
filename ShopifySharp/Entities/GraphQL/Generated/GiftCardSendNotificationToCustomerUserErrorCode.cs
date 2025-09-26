#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `GiftCardSendNotificationToCustomerUserError`.
/// </summary>
public enum GiftCardSendNotificationToCustomerUserErrorCode
{
    INVALID,
    CUSTOMER_NOT_FOUND,
    GIFT_CARD_NOT_FOUND,
}