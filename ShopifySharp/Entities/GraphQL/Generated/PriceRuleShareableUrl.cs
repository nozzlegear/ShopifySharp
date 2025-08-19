#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Shareable URL for the discount code associated with the price rule.
/// </summary>
public record PriceRuleShareableUrl : IGraphQLObject
{
    /// <summary>
    /// The image URL of the item (product or collection) to which the discount applies.
    /// </summary>
    [JsonPropertyName("targetItemImage")]
    public Image? targetItemImage { get; set; } = null;

    /// <summary>
    /// The type of page that's associated with the URL.
    /// </summary>
    [JsonPropertyName("targetType")]
    public PriceRuleShareableUrlTargetType? targetType { get; set; } = null;

    /// <summary>
    /// The title of the page that's associated with the URL.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The URL for the discount code.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}