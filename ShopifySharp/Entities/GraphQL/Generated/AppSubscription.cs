#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Provides users access to services and/or features for a duration of time.
/// </summary>
public record AppSubscription : IGraphQLObject, INode
{
    /// <summary>
    /// The date and time when the app subscription was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// The date and time when the current app subscription period ends. Returns `null` if the subscription isn't active.
    /// </summary>
    [JsonPropertyName("currentPeriodEnd")]
    public DateTime? currentPeriodEnd { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The plans attached to the app subscription.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public ICollection<AppSubscriptionLineItem>? lineItems { get; set; } = null;

    /// <summary>
    /// The name of the app subscription.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The URL that the merchant is redirected to after approving the app subscription.
    /// </summary>
    [JsonPropertyName("returnUrl")]
    public string? returnUrl { get; set; } = null;

    /// <summary>
    /// The status of the app subscription.
    /// </summary>
    [JsonPropertyName("status")]
    public AppSubscriptionStatus? status { get; set; } = null;

    /// <summary>
    /// Specifies whether the app subscription is a test transaction.
    /// </summary>
    [JsonPropertyName("test")]
    public bool? test { get; set; } = null;

    /// <summary>
    /// The number of free trial days, starting at the subscription's creation date, by which billing is delayed.
    /// </summary>
    [JsonPropertyName("trialDays")]
    public int? trialDays { get; set; } = null;
}