#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to select a subset of subscription billing cycles within an index range.
/// </summary>
public record SubscriptionBillingCyclesIndexRangeSelector : GraphQLInputObject<SubscriptionBillingCyclesIndexRangeSelector>
{
    /// <summary>
    /// The end index for the range.
    /// </summary>
    [JsonPropertyName("endIndex")]
    public int? endIndex { get; set; } = null;

    /// <summary>
    /// The start index for the range.
    /// </summary>
    [JsonPropertyName("startIndex")]
    public int? startIndex { get; set; } = null;
}