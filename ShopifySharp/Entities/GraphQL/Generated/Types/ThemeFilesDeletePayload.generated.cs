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
/// Return type for `themeFilesDelete` mutation.
/// </summary>
public record ThemeFilesDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The resulting theme files.
    /// </summary>
    [JsonPropertyName("deletedThemeFiles")]
    public ICollection<OnlineStoreThemeFileOperationResult>? deletedThemeFiles { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<OnlineStoreThemeFilesUserErrors>? userErrors { get; set; } = null;
}