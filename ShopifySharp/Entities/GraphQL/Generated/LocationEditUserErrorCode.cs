#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `LocationEditUserError`.
/// </summary>
public enum LocationEditUserErrorCode
{
    TOO_LONG,
    BLANK,
    NOT_FOUND,
    INVALID,
    TAKEN,
    INVALID_US_ZIPCODE,
    GENERIC_ERROR,
    CANNOT_DISABLE_ONLINE_ORDER_FULFILLMENT,
    CANNOT_MODIFY_ONLINE_ORDER_FULFILLMENT_FOR_FS_LOCATION,
    INVALID_TYPE,
    INVALID_VALUE,
    APP_NOT_AUTHORIZED,
    UNSTRUCTURED_RESERVED_NAMESPACE,
    DISALLOWED_OWNER_TYPE,
    INCLUSION,
    PRESENT,
    TOO_SHORT,
    CAPABILITY_VIOLATION,
    INTERNAL_ERROR,
}