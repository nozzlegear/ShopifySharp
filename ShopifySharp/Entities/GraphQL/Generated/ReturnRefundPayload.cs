#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `returnRefund` mutation.
/// </summary>
public record ReturnRefundPayload : IGraphQLObject
{
    /// <summary>
    /// The created refund.
    /// </summary>
    [JsonPropertyName("refund")]
    public Refund? refund { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ReturnUserError>? userErrors { get; set; } = null;
}