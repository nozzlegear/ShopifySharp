#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `ThemePublishUserError`.
/// </summary>
public enum ThemePublishUserErrorCode
{
    NOT_FOUND,
    CANNOT_PUBLISH_THEME_DURING_INSTALL,
    THEME_PUBLISH_NOT_AVAILABLE_FOR_THEME_LIMITED_PLAN,
}