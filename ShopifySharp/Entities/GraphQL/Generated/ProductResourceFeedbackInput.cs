#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to create a product feedback.
/// </summary>
public record ProductResourceFeedbackInput : GraphQLInputObject<ProductResourceFeedbackInput>
{
    /// <summary>
    /// The date and time when the payload is constructed.
    /// Used to help determine whether incoming feedback is outdated compared to
    /// feedback already received, and if it should be ignored upon arrival.
    /// </summary>
    [JsonPropertyName("feedbackGeneratedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? feedbackGeneratedAt { get; set; } = null;

    /// <summary>
    /// A concise set of copy strings to be displayed to merchants. Used to guide
    /// merchants in resolving problems that your app encounters when trying to make
    /// use of their products.
    /// You can specify up to ten messages. Each message is limited to 100 characters.
    /// </summary>
    [JsonPropertyName("messages")]
    public ICollection<string>? messages { get; set; } = null;

    /// <summary>
    /// The ID of the product that the feedback was created on.
    /// </summary>
    [JsonPropertyName("productId")]
    public string? productId { get; set; } = null;

    /// <summary>
    /// The timestamp of the product associated with the feedback.
    /// </summary>
    [JsonPropertyName("productUpdatedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? productUpdatedAt { get; set; } = null;

    /// <summary>
    /// Whether the merchant needs to take action on the product.
    /// </summary>
    [JsonPropertyName("state")]
    public ResourceFeedbackState? state { get; set; } = null;
}