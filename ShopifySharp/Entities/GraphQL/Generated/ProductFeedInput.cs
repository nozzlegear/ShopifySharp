#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields required to create a product feed.
/// </summary>
public record ProductFeedInput : GraphQLInputObject<ProductFeedInput>
{
    /// <summary>
    /// The country of the product feed.
    /// </summary>
    [JsonPropertyName("country")]
    public CountryCode? country { get; set; } = null;

    /// <summary>
    /// The language of the product feed.
    /// </summary>
    [JsonPropertyName("language")]
    public LanguageCode? language { get; set; } = null;
}