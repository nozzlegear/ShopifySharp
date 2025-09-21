#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `OnlineStoreThemeFilesUserErrors`.
/// </summary>
public enum OnlineStoreThemeFilesUserErrorsCode
{
    NOT_FOUND,
    LESS_THAN_OR_EQUAL_TO,
    THEME_FILES_CONFLICT,
    DUPLICATE_FILE_INPUT,
    ACCESS_DENIED,
    THEME_LIMITED_PLAN,
    FILE_VALIDATION_ERROR,
    ERROR,
    THROTTLED,
}