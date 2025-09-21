#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `MetafieldsSetUserError`.
/// </summary>
public enum MetafieldsSetUserErrorCode
{
    CAPABILITY_VIOLATION,
    STALE_OBJECT,
    INVALID_COMPARE_DIGEST,
    INVALID_TYPE,
    INVALID_VALUE,
    APP_NOT_AUTHORIZED,
    INCLUSION,
    TAKEN,
    PRESENT,
    BLANK,
    TOO_LONG,
    TOO_SHORT,
    LESS_THAN_OR_EQUAL_TO,
    INVALID,
    INTERNAL_ERROR,
}