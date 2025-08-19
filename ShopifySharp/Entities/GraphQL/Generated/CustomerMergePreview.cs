#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A preview of the results of a customer merge request.
/// </summary>
public record CustomerMergePreview : IGraphQLObject
{
    /// <summary>
    /// The fields that can be used to override the default fields.
    /// </summary>
    [JsonPropertyName("alternateFields")]
    public CustomerMergePreviewAlternateFields? alternateFields { get; set; } = null;

    /// <summary>
    /// The fields that will block the merge if the two customers are merged.
    /// </summary>
    [JsonPropertyName("blockingFields")]
    public CustomerMergePreviewBlockingFields? blockingFields { get; set; } = null;

    /// <summary>
    /// The errors blocking the customer merge.
    /// </summary>
    [JsonPropertyName("customerMergeErrors")]
    public ICollection<CustomerMergeError>? customerMergeErrors { get; set; } = null;

    /// <summary>
    /// The fields that will be kept if the two customers are merged.
    /// </summary>
    [JsonPropertyName("defaultFields")]
    public CustomerMergePreviewDefaultFields? defaultFields { get; set; } = null;

    /// <summary>
    /// The resulting customer ID if the two customers are merged.
    /// </summary>
    [JsonPropertyName("resultingCustomerId")]
    public string? resultingCustomerId { get; set; } = null;
}