#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A subscription billing cycle.
/// </summary>
public record SubscriptionBillingCycle : IGraphQLObject
{
    /// <summary>
    /// The date on which the billing attempt is expected to be made.
    /// </summary>
    [JsonPropertyName("billingAttemptExpectedDate")]
    public DateTime? billingAttemptExpectedDate { get; set; } = null;

    /// <summary>
    /// The list of billing attempts associated with the billing cycle.
    /// </summary>
    [JsonPropertyName("billingAttempts")]
    public SubscriptionBillingAttemptConnection? billingAttempts { get; set; } = null;

    /// <summary>
    /// The end date of the billing cycle.
    /// </summary>
    [JsonPropertyName("cycleEndAt")]
    public DateTime? cycleEndAt { get; set; } = null;

    /// <summary>
    /// The index of the billing cycle.
    /// </summary>
    [JsonPropertyName("cycleIndex")]
    public int? cycleIndex { get; set; } = null;

    /// <summary>
    /// The start date of the billing cycle.
    /// </summary>
    [JsonPropertyName("cycleStartAt")]
    public DateTime? cycleStartAt { get; set; } = null;

    /// <summary>
    /// Whether this billing cycle was edited.
    /// </summary>
    [JsonPropertyName("edited")]
    public bool? edited { get; set; } = null;

    /// <summary>
    /// The active edited contract for the billing cycle.
    /// </summary>
    [JsonPropertyName("editedContract")]
    public SubscriptionBillingCycleEditedContract? editedContract { get; set; } = null;

    /// <summary>
    /// Whether this billing cycle was skipped.
    /// </summary>
    [JsonPropertyName("skipped")]
    public bool? skipped { get; set; } = null;

    /// <summary>
    /// The subscription contract that the billing cycle belongs to.
    /// </summary>
    [JsonPropertyName("sourceContract")]
    public SubscriptionContract? sourceContract { get; set; } = null;

    /// <summary>
    /// The status of the billing cycle.
    /// </summary>
    [JsonPropertyName("status")]
    public SubscriptionBillingCycleBillingCycleStatus? status { get; set; } = null;
}