#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// An agreement between the merchant and customer to refund all or a portion of the order.
/// </summary>
public record RefundAgreement : IGraphQLObject, ISalesAgreement
{
    /// <summary>
    /// The application that created the agreement.
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; } = null;

    /// <summary>
    /// The date and time at which the agreement occured.
    /// </summary>
    [JsonPropertyName("happenedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? happenedAt { get; set; } = null;

    /// <summary>
    /// The unique ID for the agreement.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The reason the agremeent was created.
    /// </summary>
    [JsonPropertyName("reason")]
    public OrderActionType? reason { get; set; } = null;

    /// <summary>
    /// The refund associated with the agreement.
    /// </summary>
    [JsonPropertyName("refund")]
    public Refund? refund { get; set; } = null;

    /// <summary>
    /// The sales associated with the agreement.
    /// </summary>
    [JsonPropertyName("sales")]
    public SaleConnection? sales { get; set; } = null;

    /// <summary>
    /// The staff member associated with the agreement.
    /// </summary>
    [JsonPropertyName("user")]
    public StaffMember? user { get; set; } = null;
}