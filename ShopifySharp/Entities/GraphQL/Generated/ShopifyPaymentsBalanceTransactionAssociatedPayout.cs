#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The payout associated with a balance transaction.
/// </summary>
public record ShopifyPaymentsBalanceTransactionAssociatedPayout : IGraphQLObject
{
    /// <summary>
    /// The ID of the payout associated with the balance transaction.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The status of the payout associated with the balance transaction.
    /// </summary>
    [JsonPropertyName("status")]
    public ShopifyPaymentsBalanceTransactionPayoutStatus? status { get; set; } = null;
}