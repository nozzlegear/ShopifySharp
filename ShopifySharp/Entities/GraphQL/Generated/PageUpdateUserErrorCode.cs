#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `PageUpdateUserError`.
/// </summary>
public enum PageUpdateUserErrorCode
{
    INVALID_PUBLISH_DATE,
    NOT_FOUND,
    BLANK,
    TOO_LONG,
    TOO_BIG,
    TAKEN,
    INVALID,
    INVALID_VALUE,
    INVALID_TYPE,
}