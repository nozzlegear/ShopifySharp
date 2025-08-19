#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Type of a theme file operation result.
/// </summary>
public enum OnlineStoreThemeFileResultType
{
    SUCCESS,
    ERROR,
    CONFLICT,
    UNPROCESSABLE_ENTITY,
    BAD_REQUEST,
    TIMEOUT,
    NOT_FOUND,
}