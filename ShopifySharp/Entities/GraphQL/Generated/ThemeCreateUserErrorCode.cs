#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `ThemeCreateUserError`.
/// </summary>
public enum ThemeCreateUserErrorCode
{
    INVALID_ZIP,
    ZIP_IS_EMPTY,
    ZIP_TOO_LARGE,
    THEME_CREATION_NOT_ALLOWED_FOR_THEME_LIMITED_PLAN,
    INVALID_THEME_ROLE_FOR_THEME_CREATION,
}