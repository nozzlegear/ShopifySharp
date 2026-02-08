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
/// Return type for `themeDuplicate` mutation.
/// </summary>
public record ThemeDuplicatePayload : IGraphQLObject
{
    /// <summary>
    /// The newly duplicated theme.
    /// </summary>
    [JsonPropertyName("newTheme")]
    public OnlineStoreTheme? newTheme { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ThemeDuplicateUserError>? userErrors { get; set; } = null;
}