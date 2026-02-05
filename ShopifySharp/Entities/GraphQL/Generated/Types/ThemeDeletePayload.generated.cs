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
/// Return type for `themeDelete` mutation.
/// </summary>
public record ThemeDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the deleted theme.
    /// </summary>
    [JsonPropertyName("deletedThemeId")]
    public string? deletedThemeId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ThemeDeleteUserError>? userErrors { get; set; } = null;
}