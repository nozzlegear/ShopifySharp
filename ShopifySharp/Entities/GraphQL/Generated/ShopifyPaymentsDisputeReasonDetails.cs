#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Details regarding a dispute reason.
/// </summary>
public record ShopifyPaymentsDisputeReasonDetails : IGraphQLObject
{
    /// <summary>
    /// The raw code provided by the payment network.
    /// </summary>
    [JsonPropertyName("networkReasonCode")]
    public string? networkReasonCode { get; set; } = null;

    /// <summary>
    /// The reason for the dispute provided by the cardholder's banks.
    /// </summary>
    [JsonPropertyName("reason")]
    public ShopifyPaymentsDisputeReason? reason { get; set; } = null;
}