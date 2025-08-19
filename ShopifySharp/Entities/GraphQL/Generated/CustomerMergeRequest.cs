#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A merge request for merging two customers.
/// </summary>
public record CustomerMergeRequest : IGraphQLObject
{
    /// <summary>
    /// The merge errors that occurred during the customer merge request.
    /// </summary>
    [JsonPropertyName("customerMergeErrors")]
    public ICollection<CustomerMergeError>? customerMergeErrors { get; set; } = null;

    /// <summary>
    /// The UUID of the merge job.
    /// </summary>
    [JsonPropertyName("jobId")]
    public string? jobId { get; set; } = null;

    /// <summary>
    /// The ID of the customer resulting from the merge.
    /// </summary>
    [JsonPropertyName("resultingCustomerId")]
    public string? resultingCustomerId { get; set; } = null;

    /// <summary>
    /// The status of the customer merge request.
    /// </summary>
    [JsonPropertyName("status")]
    public CustomerMergeRequestStatus? status { get; set; } = null;
}