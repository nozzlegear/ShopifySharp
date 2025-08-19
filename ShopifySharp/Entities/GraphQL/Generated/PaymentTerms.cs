#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the payment terms for an order or draft order.
/// </summary>
public record PaymentTerms : IGraphQLObject, INode
{
    /// <summary>
    /// The draft order associated with the payment terms.
    /// </summary>
    [JsonPropertyName("draftOrder")]
    public DraftOrder? draftOrder { get; set; } = null;

    /// <summary>
    /// Duration of payment terms in days based on the payment terms template used to create the payment terms.
    /// </summary>
    [JsonPropertyName("dueInDays")]
    public int? dueInDays { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The order associated with the payment terms.
    /// </summary>
    [JsonPropertyName("order")]
    public Order? order { get; set; } = null;

    /// <summary>
    /// Whether the payment terms have overdue payment schedules.
    /// </summary>
    [JsonPropertyName("overdue")]
    public bool? overdue { get; set; } = null;

    /// <summary>
    /// List of schedules for the payment terms.
    /// </summary>
    [JsonPropertyName("paymentSchedules")]
    public PaymentScheduleConnection? paymentSchedules { get; set; } = null;

    /// <summary>
    /// The name of the payment terms template used to create the payment terms.
    /// </summary>
    [JsonPropertyName("paymentTermsName")]
    public string? paymentTermsName { get; set; } = null;

    /// <summary>
    /// The payment terms template type used to create the payment terms.
    /// </summary>
    [JsonPropertyName("paymentTermsType")]
    public PaymentTermsType? paymentTermsType { get; set; } = null;

    /// <summary>
    /// The payment terms name, translated into the shop admin's preferred language.
    /// </summary>
    [JsonPropertyName("translatedName")]
    public string? translatedName { get; set; } = null;
}