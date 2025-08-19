#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a shop locale.
/// </summary>
public record ShopLocaleInput : GraphQLInputObject<ShopLocaleInput>
{
    /// <summary>
    /// The market web presences on which the locale should be enabled. Pass in an
    /// empty array to remove the locale across all market web presences.
    /// </summary>
    [JsonPropertyName("marketWebPresenceIds")]
    public ICollection<string>? marketWebPresenceIds { get; set; } = null;

    /// <summary>
    /// Whether the locale is published. Only published locales are visible to the buyer.
    /// </summary>
    [JsonPropertyName("published")]
    public bool? published { get; set; } = null;
}