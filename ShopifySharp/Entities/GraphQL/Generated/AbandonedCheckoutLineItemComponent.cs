#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The list of line item components that belong to a line item.
/// </summary>
public record AbandonedCheckoutLineItemComponent : IGraphQLObject
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The variant image associated with the line item component.
    /// NULL if the variant associated doesn't have an image.
    /// </summary>
    [JsonPropertyName("image")]
    public Image? image { get; set; } = null;

    /// <summary>
    /// The quantity of the line item component.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// Title of the line item component.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The name of the variant.
    /// </summary>
    [JsonPropertyName("variantTitle")]
    public string? variantTitle { get; set; } = null;
}