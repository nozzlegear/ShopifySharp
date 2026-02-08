#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

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
    /// Remaining balance to be captured for this payment schedule.
    /// </summary>
    [JsonPropertyName("balanceDue")]
    public MoneyV2? balanceDue { get; set; } = null;

    /// <summary>
    /// Date and time when the payment schedule is paid or fulfilled.
    /// </summary>
    [JsonPropertyName("completedAt")]
    public DateTimeOffset? completedAt { get; set; } = null;

    /// <summary>
    /// Whether the payment schedule is due.
    /// </summary>
    [JsonPropertyName("due")]
    public bool? due { get; set; } = null;

    /// <summary>
    /// Date and time when the payment schedule is due.
    /// </summary>
    [JsonPropertyName("dueAt")]
    public DateTimeOffset? dueAt { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Date and time when the invoice is sent.
    /// </summary>
    [JsonPropertyName("issuedAt")]
    public DateTimeOffset? issuedAt { get; set; } = null;

    /// <summary>
    /// The payment terms the payment schedule belongs to.
    /// </summary>
    [JsonPropertyName("paymentTerms")]
    public PaymentTerms? paymentTerms { get; set; } = null;

    /// <summary>
    /// Remaining balance to be paid or authorized by the customer for this payment schedule.
    /// </summary>
    [JsonPropertyName("totalBalance")]
    public MoneyV2? totalBalance { get; set; } = null;
}