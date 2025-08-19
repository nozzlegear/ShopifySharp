#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `shopLocaleDisable` mutation.
/// </summary>
public record ShopLocaleDisablePayload : IGraphQLObject
{
    /// <summary>
    /// ISO code of the locale that was deleted.
    /// </summary>
    [JsonPropertyName("locale")]
    public string? locale { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}