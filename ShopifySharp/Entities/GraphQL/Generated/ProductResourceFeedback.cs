#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Reports the status of product for a Sales Channel or Storefront API.
/// This might include why a product is not available in a Sales Channel
/// and how a merchant might fix this.
/// </summary>
public record ProductResourceFeedback : IGraphQLObject
{
    /// <summary>
    /// The time when the feedback was generated. Used to help determine whether
    /// incoming feedback is outdated compared to existing feedback.
    /// </summary>
    [JsonPropertyName("feedbackGeneratedAt")]
    public DateTime? feedbackGeneratedAt { get; set; } = null;

    /// <summary>
    /// The feedback messages presented to the merchant.
    /// </summary>
    [JsonPropertyName("messages")]
    public ICollection<string>? messages { get; set; } = null;

    /// <summary>
    /// The ID of the product associated with the feedback.
    /// </summary>
    [JsonPropertyName("productId")]
    public string? productId { get; set; } = null;

    /// <summary>
    /// The timestamp of the product associated with the feedback.
    /// </summary>
    [JsonPropertyName("productUpdatedAt")]
    public DateTime? productUpdatedAt { get; set; } = null;

    /// <summary>
    /// Conveys the state of the feedback and whether it requires merchant action or not.
    /// </summary>
    [JsonPropertyName("state")]
    public ResourceFeedbackState? state { get; set; } = null;
}