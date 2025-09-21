#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The plan attached to an app subscription.
/// </summary>
public record AppSubscriptionLineItem : IGraphQLObject
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The pricing model for the app subscription.
    /// </summary>
    [JsonPropertyName("plan")]
    public AppPlanV2? plan { get; set; } = null;

    /// <summary>
    /// A list of the store's usage records for a usage pricing plan.
    /// </summary>
    [JsonPropertyName("usageRecords")]
    public AppUsageRecordConnection? usageRecords { get; set; } = null;
}