#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `ThemeUpdateUserError`.
/// </summary>
public enum ThemeUpdateUserErrorCode
{
    NOT_FOUND,
    TOO_LONG,
    INVALID,
}