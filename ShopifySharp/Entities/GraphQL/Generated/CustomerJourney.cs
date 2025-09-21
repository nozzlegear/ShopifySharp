#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a customer's visiting activities on a shop's online store.
/// </summary>
public record CustomerJourney : IGraphQLObject
{
    /// <summary>
    /// The position of the current order within the customer's order history.
    /// </summary>
    [JsonPropertyName("customerOrderIndex")]
    public int? customerOrderIndex { get; set; } = null;

    /// <summary>
    /// The amount of days between first session and order creation date. First
    /// session represents first session since the last order, or first session within
    /// the 30 day attribution window, if more than 30 days has passed since the last order.
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
    /// Events preceding a customer order, such as shop sessions.
    /// </summary>
    [JsonPropertyName("moments")]
    public ICollection<ICustomerMoment>? moments { get; set; } = null;
}