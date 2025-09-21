#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `BillingAttemptUserError`.
/// </summary>
public enum BillingAttemptUserErrorCode
{
    INVALID,
    BLANK,
    CONTRACT_NOT_FOUND,
    ORIGIN_TIME_BEFORE_CONTRACT_CREATION,
    UPCOMING_CYCLE_LIMIT_EXCEEDED,
    CYCLE_INDEX_OUT_OF_RANGE,
    CYCLE_START_DATE_OUT_OF_RANGE,
    ORIGIN_TIME_OUT_OF_RANGE,
    BILLING_CYCLE_CHARGE_BEFORE_EXPECTED_DATE,
    BILLING_CYCLE_SKIPPED,
    CONTRACT_UNDER_REVIEW,
    CONTRACT_TERMINATED,
    CONTRACT_PAUSED,
}