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
/// Possible error codes that can be returned by `PointOfSaleDevicePaymentSessionCountUserError`.
/// </summary>
public enum PointOfSaleDevicePaymentSessionCountUserErrorCode
{
    STAFF_MEMBER_NOT_FOUND,
    PAYMENT_SESSION_NOT_FOUND,
    SESSION_ALREADY_CLOSED,
    TIME_BEFORE_SESSION_OPEN,
    REASON_CODE_NOT_FOUND,
    CURRENCY_MISMATCH,
    NO_CASH_DRAWER_ASSOCIATED,
    FAILED_TO_RECORD_COUNT,
}