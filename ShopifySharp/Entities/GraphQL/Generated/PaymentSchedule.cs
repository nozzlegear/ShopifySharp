#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the payment schedule for a single payment defined in the payment terms.
/// </summary>
public record PaymentSchedule : IGraphQLObject, INode
{
    /// <summary>
    /// Amount owed for this payment schedule.
    /// </summary>
    [JsonPropertyName("amount")]
    [Obsolete("Use `balanceDue`, `totalBalance`, or `Order.totalOutstandingSet` instead.")]
    public MoneyV2? amount { get; set; } = null;

    /// <summary>
    /// Date and time when the payment schedule is paid or fulfilled.
    /// </summary>
    [JsonPropertyName("completedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? completedAt { get; set; } = null;

    /// <summary>
    /// Date and time when the payment schedule is due.
    /// </summary>
    [JsonPropertyName("dueAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? dueAt { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Date and time when the invoice is sent.
    /// </summary>
    [JsonPropertyName("issuedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? issuedAt { get; set; } = null;

    /// <summary>
    /// The payment terms the payment schedule belongs to.
    /// </summary>
    [JsonPropertyName("paymentTerms")]
    public PaymentTerms? paymentTerms { get; set; } = null;
}