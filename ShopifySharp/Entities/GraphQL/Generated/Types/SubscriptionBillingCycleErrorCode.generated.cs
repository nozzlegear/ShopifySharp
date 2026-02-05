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
/// Possible error codes that can be returned by `SubscriptionBillingCycleUserError`.
/// </summary>
public enum SubscriptionBillingCycleErrorCode
{
    INVALID,
    CYCLE_NOT_FOUND,
    NO_CYCLE_EDITS,
    INVALID_CYCLE_INDEX,
    INVALID_DATE,
    EMPTY_BILLING_CYCLE_EDIT_SCHEDULE_INPUT,
    BILLING_DATE_SET_ON_SKIPPED,
    OUT_OF_BOUNDS,
    UPCOMING_CYCLE_LIMIT_EXCEEDED,
    CYCLE_INDEX_OUT_OF_RANGE,
    CYCLE_START_DATE_OUT_OF_RANGE,
    INCOMPLETE_BILLING_ATTEMPTS,
}