#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `BlogCreateUserError`.
/// </summary>
public enum BlogCreateUserErrorCode
{
    INVALID,
    TOO_LONG,
    INCLUSION,
    INVALID_VALUE,
    INVALID_TYPE,
}