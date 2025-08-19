#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `themeFilesCopy` mutation.
/// </summary>
public record ThemeFilesCopyPayload : IGraphQLObject
{
    /// <summary>
    /// The resulting theme files.
    /// </summary>
    [JsonPropertyName("copiedThemeFiles")]
    public ICollection<OnlineStoreThemeFileOperationResult>? copiedThemeFiles { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<OnlineStoreThemeFilesUserErrors>? userErrors { get; set; } = null;
}