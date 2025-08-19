#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record OnlineStoreThemeFileBodyOnlineStoreThemeFileBodyBase64(OnlineStoreThemeFileBodyBase64 Value): OnlineStoreThemeFileBody;
internal record OnlineStoreThemeFileBodyOnlineStoreThemeFileBodyText(OnlineStoreThemeFileBodyText Value): OnlineStoreThemeFileBody;
internal record OnlineStoreThemeFileBodyOnlineStoreThemeFileBodyUrl(OnlineStoreThemeFileBodyUrl Value): OnlineStoreThemeFileBody;
#endif /// <summary>

/// Represents the base64 encoded body of a theme file.
/// </summary>
public record OnlineStoreThemeFileBodyBase64 : OnlineStoreThemeFileBody, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The body of the theme file, base64 encoded.
    /// </summary>
    [JsonPropertyName("contentBase64")]
    public string? contentBase64 { get; set; } = null;
}