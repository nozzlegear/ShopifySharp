#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `themeFilesUpsert` mutation.
/// </summary>
public record ThemeFilesUpsertPayload : IGraphQLObject
{
    /// <summary>
    /// The theme files write job triggered by the mutation.
    /// </summary>
    [JsonPropertyName("job")]
    public Job? job { get; set; } = null;

    /// <summary>
    /// The resulting theme files.
    /// </summary>
    [JsonPropertyName("upsertedThemeFiles")]
    public ICollection<OnlineStoreThemeFileOperationResult>? upsertedThemeFiles { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<OnlineStoreThemeFilesUserErrors>? userErrors { get; set; } = null;
}