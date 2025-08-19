#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A summary of the important details for a dispute on an order.
/// </summary>
public record OrderDisputeSummary : IGraphQLObject, INode
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The type that the dispute was initiated as.
    /// </summary>
    [JsonPropertyName("initiatedAs")]
    public DisputeType? initiatedAs { get; set; } = null;

    /// <summary>
    /// The current status of the dispute.
    /// </summary>
    [JsonPropertyName("status")]
    public DisputeStatus? status { get; set; } = null;
}