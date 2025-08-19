#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `MenuUpdateUserError`.
/// </summary>
public enum MenuUpdateUserErrorCode
{
    NOT_FOUND,
    NESTING_TOO_DEEP,
}