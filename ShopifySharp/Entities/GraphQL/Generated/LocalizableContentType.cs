#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Specifies the type of the underlying localizable content. This can be used to
/// conditionally render different UI elements such as input fields.
/// </summary>
public enum LocalizableContentType
{
    JSON_STRING,
    JSON,
    LIST_MULTI_LINE_TEXT_FIELD,
    LIST_SINGLE_LINE_TEXT_FIELD,
    LIST_URL,
    MULTI_LINE_TEXT_FIELD,
    RICH_TEXT_FIELD,
    SINGLE_LINE_TEXT_FIELD,
    STRING,
    URL,
    LINK,
    LIST_LINK,
    FILE_REFERENCE,
    LIST_FILE_REFERENCE,
    HTML,
    URI,
    INLINE_RICH_TEXT,
}