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
/// Possible error codes that can be returned by `GiftCardUserError`.
/// </summary>
public enum GiftCardErrorCode
{
    TOO_LONG,
    TOO_SHORT,
    TAKEN,
    INVALID,
    INTERNAL_ERROR,
    MISSING_ARGUMENT,
    GREATER_THAN,
    GIFT_CARD_LIMIT_EXCEEDED,
    CUSTOMER_NOT_FOUND,
    RECIPIENT_NOT_FOUND,
}