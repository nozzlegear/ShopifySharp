#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `CustomerMergeUserError`.
/// </summary>
public enum CustomerMergeErrorCode
{
    INTERNAL_ERROR,
    INVALID_CUSTOMER,
    INVALID_CUSTOMER_ID,
    CUSTOMER_HAS_GIFT_CARDS,
    MISSING_OVERRIDE_ATTRIBUTE,
    OVERRIDE_ATTRIBUTE_INVALID,
}