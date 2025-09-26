#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields to select SubscriptionBillingCycle by either date or index.
/// Both past and future billing cycles can be selected.
/// </summary>
public record SubscriptionBillingCycleSelector : GraphQLInputObject<SubscriptionBillingCycleSelector>
{
    /// <summary>
    /// Returns a billing cycle by date.
    /// </summary>
    [JsonPropertyName("date")]
    public DateTime? date { get; set; } = null;

    /// <summary>
    /// Returns a billing cycle by index.
    /// </summary>
    [JsonPropertyName("index")]
    public int? index { get; set; } = null;
}