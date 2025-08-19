#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `BlogUpdateUserError`.
/// </summary>
public enum BlogUpdateUserErrorCode
{
    NOT_FOUND,
    INVALID,
    BLANK,
    TOO_LONG,
    INCLUSION,
}