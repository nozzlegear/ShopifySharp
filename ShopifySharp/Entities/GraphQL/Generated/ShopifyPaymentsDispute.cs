#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A dispute occurs when a buyer questions the legitimacy of a charge with their financial institution.
/// </summary>
public record ShopifyPaymentsDispute : IGraphQLObject, ILegacyInteroperability, INode
{
    /// <summary>
    /// The total amount disputed by the cardholder.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyV2? amount { get; set; } = null;

    /// <summary>
    /// The deadline for evidence submission.
    /// </summary>
    [JsonPropertyName("evidenceDueBy")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateOnly? evidenceDueBy { get; set; } = null;

    /// <summary>
    /// The date when evidence was sent. Returns null if evidence hasn't yet been sent.
    /// </summary>
    [JsonPropertyName("evidenceSentOn")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateOnly? evidenceSentOn { get; set; } = null;

    /// <summary>
    /// The date when this dispute was resolved. Returns null if the dispute isn't yet resolved.
    /// </summary>
    [JsonPropertyName("finalizedOn")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateOnly? finalizedOn { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The date when this dispute was initiated.
    /// </summary>
    [JsonPropertyName("initiatedAt")]
    public DateTime? initiatedAt { get; set; } = null;

    /// <summary>
    /// The ID of the corresponding resource in the REST Admin API.
    /// </summary>
    [JsonPropertyName("legacyResourceId")]
    public ulong? legacyResourceId { get; set; } = null;

    /// <summary>
    /// The order that contains the charge that's under dispute.
    /// </summary>
    [JsonPropertyName("order")]
    public Order? order { get; set; } = null;

    /// <summary>
    /// The reason of the dispute.
    /// </summary>
    [JsonPropertyName("reasonDetails")]
    public ShopifyPaymentsDisputeReasonDetails? reasonDetails { get; set; } = null;

    /// <summary>
    /// The current state of the dispute.
    /// </summary>
    [JsonPropertyName("status")]
    public DisputeStatus? status { get; set; } = null;

    /// <summary>
    /// Indicates if this dispute is still in the inquiry phase or has turned into a chargeback.
    /// </summary>
    [JsonPropertyName("type")]
    public DisputeType? type { get; set; } = null;
}