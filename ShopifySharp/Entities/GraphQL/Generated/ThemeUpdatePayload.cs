#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `themeUpdate` mutation.
/// </summary>
public record ThemeUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The theme that was updated.
    /// </summary>
    [JsonPropertyName("theme")]
    public OnlineStoreTheme? theme { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ThemeUpdateUserError>? userErrors { get; set; } = null;
}