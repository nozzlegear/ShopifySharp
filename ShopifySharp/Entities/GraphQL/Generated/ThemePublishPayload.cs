#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `themePublish` mutation.
/// </summary>
public record ThemePublishPayload : IGraphQLObject
{
    /// <summary>
    /// The theme that was published.
    /// </summary>
    [JsonPropertyName("theme")]
    public OnlineStoreTheme? theme { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ThemePublishUserError>? userErrors { get; set; } = null;
}