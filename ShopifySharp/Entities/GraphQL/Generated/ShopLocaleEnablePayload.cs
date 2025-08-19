#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `shopLocaleEnable` mutation.
/// </summary>
public record ShopLocaleEnablePayload : IGraphQLObject
{
    /// <summary>
    /// ISO code of the locale that was enabled.
    /// </summary>
    [JsonPropertyName("shopLocale")]
    public ShopLocale? shopLocale { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}