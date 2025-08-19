#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `UrlRedirectImportUserError`.
/// </summary>
public enum UrlRedirectImportErrorCode
{
    [Obsolete("This error code is never returned")]
    FILE_DOES_NOT_EXIST,
    NOT_FOUND,
    ALREADY_IMPORTED,
    IN_PROGRESS,
}