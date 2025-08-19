#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `ErrorsWebPixelUserError`.
/// </summary>
public enum ErrorsWebPixelUserErrorCode
{
    BLANK,
    TAKEN,
    NOT_FOUND,
    INVALID_SETTINGS,
    [Obsolete("`UNABLE_TO_DELETE` is deprecated. Use `UNEXPECTED_ERROR` instead.")]
    UNABLE_TO_DELETE,
    NO_EXTENSION,
    INVALID_CONFIGURATION_JSON,
    INVALID_SETTINGS_DEFINITION,
    UNEXPECTED_ERROR,
    INVALID_RUNTIME_CONTEXT,
}