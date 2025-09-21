#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `shopLocaleUpdate` mutation.
/// </summary>
public record ShopLocaleUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The locale that was updated.
    /// </summary>
    [JsonPropertyName("shopLocale")]
    public ShopLocale? shopLocale { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}