#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields to select a subset of subscription billing cycles within a date range.
/// </summary>
public record SubscriptionBillingCyclesDateRangeSelector : GraphQLInputObject<SubscriptionBillingCyclesDateRangeSelector>
{
    /// <summary>
    /// The end date and time for the range.
    /// </summary>
    [JsonPropertyName("endDate")]
    public DateTime? endDate { get; set; } = null;

    /// <summary>
    /// The start date and time for the range.
    /// </summary>
    [JsonPropertyName("startDate")]
    public DateTime? startDate { get; set; } = null;
}