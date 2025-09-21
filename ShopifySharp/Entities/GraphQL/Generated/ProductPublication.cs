#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents the channels where a product is published.
/// </summary>
public record ProductPublication : IGraphQLObject
{
    /// <summary>
    /// The channel where the product was or is published.
    /// </summary>
    [JsonPropertyName("channel")]
    public Channel? channel { get; set; } = null;

    /// <summary>
    /// Whether the publication is published or not.
    /// </summary>
    [JsonPropertyName("isPublished")]
    public bool? isPublished { get; set; } = null;

    /// <summary>
    /// The product that was or is going to be published on the channel.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;

    /// <summary>
    /// The date that the product was or is going to be published on the channel.
    /// </summary>
    [JsonPropertyName("publishDate")]
    public DateTime? publishDate { get; set; } = null;
}