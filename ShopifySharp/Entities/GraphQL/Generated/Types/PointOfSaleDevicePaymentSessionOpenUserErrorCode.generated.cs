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
/// Possible error codes that can be returned by `PointOfSaleDevicePaymentSessionOpenUserError`.
/// </summary>
public enum PointOfSaleDevicePaymentSessionOpenUserErrorCode
{
    POINT_OF_SALE_DEVICE_NOT_FOUND,
    NO_CASH_DRAWER_ASSOCIATED,
    NOT_SAVED,
    ALREADY_OPEN,
    STAFF_MEMBER_NOT_FOUND,
    CURRENCY_MISMATCH,
    REASON_CODE_NOT_FOUND,
}