#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `GiftCardSendNotificationToRecipientUserError`.
/// </summary>
public enum GiftCardSendNotificationToRecipientUserErrorCode
{
    INVALID,
    RECIPIENT_NOT_FOUND,
    GIFT_CARD_NOT_FOUND,
}