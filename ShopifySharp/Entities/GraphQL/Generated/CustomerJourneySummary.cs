#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a customer's visiting activities on a shop's online store.
/// </summary>
public record CustomerJourneySummary : IGraphQLObject
{
    /// <summary>
    /// The position of the current order within the customer's order history. Test orders aren't included.
    /// </summary>
    [JsonPropertyName("customerOrderIndex")]
    public int? customerOrderIndex { get; set; } = null;

    /// <summary>
    /// The number of days between the first session and the order creation date. The
    /// first session represents the first session since the last order, or the first
    /// session within the 30 day attribution window, if more than 30 days have passed
    /// since the last order.
    /// </summary>
    [JsonPropertyName("daysToConversion")]
    public int? daysToConversion { get; set; } = null;

    /// <summary>
    /// The customer's first session going into the shop.
    /// </summary>
    [JsonPropertyName("firstVisit")]
    public CustomerVisit? firstVisit { get; set; } = null;

    /// <summary>
    /// The last session before an order is made.
    /// </summary>
    [JsonPropertyName("lastVisit")]
    public CustomerVisit? lastVisit { get; set; } = null;

    /// <summary>
    /// The events preceding a customer's order, such as shop sessions.
    /// </summary>
    [JsonPropertyName("moments")]
    public CustomerMomentConnection? moments { get; set; } = null;

    /// <summary>
    /// The total number of customer moments associated with this order. Returns null
    /// if the order is still in the process of being attributed.
    /// </summary>
    [JsonPropertyName("momentsCount")]
    public Count? momentsCount { get; set; } = null;

    /// <summary>
    /// Whether the attributed sessions for the order have been created yet.
    /// </summary>
    [JsonPropertyName("ready")]
    public bool? ready { get; set; } = null;
}