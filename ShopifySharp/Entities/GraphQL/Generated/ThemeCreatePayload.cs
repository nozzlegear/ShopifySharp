#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `themeCreate` mutation.
/// </summary>
public record ThemeCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The theme that was created.
    /// </summary>
    [JsonPropertyName("theme")]
    public OnlineStoreTheme? theme { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ThemeCreateUserError>? userErrors { get; set; } = null;
}