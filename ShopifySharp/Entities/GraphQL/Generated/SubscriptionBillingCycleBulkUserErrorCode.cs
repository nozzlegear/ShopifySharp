#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `SubscriptionBillingCycleBulkUserError`.
/// </summary>
public enum SubscriptionBillingCycleBulkUserErrorCode
{
    INVALID,
    BLANK,
    END_DATE_IN_THE_FUTURE,
    INVALID_DATE_RANGE,
    START_DATE_BEFORE_END_DATE,
}