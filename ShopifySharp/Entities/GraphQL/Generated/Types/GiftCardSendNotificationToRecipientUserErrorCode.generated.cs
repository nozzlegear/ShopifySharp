#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `GiftCardSendNotificationToRecipientUserError`.
/// </summary>
public enum GiftCardSendNotificationToRecipientUserErrorCode
{
    INVALID,
    RECIPIENT_NOT_FOUND,
    GIFT_CARD_NOT_FOUND,
}