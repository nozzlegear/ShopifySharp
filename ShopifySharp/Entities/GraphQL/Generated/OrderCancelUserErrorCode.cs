#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `OrderCancelUserError`.
/// </summary>
public enum OrderCancelUserErrorCode
{
    NO_REFUND_PERMISSION,
    NO_REFUND_TO_STORE_CREDIT_PERMISSION,
    STORE_CREDIT_REFUND_EXPIRATION_IN_PAST,
    STORE_CREDIT_REFUND_MISSING_CUSTOMER,
    STORE_CREDIT_REFUND_B2B_NOT_SUPPORTED,
    NOT_FOUND,
    INVALID,
    INTERNAL_ERROR,
}