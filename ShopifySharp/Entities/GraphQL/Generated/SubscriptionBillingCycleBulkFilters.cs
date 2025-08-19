#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for filtering subscription billing cycles in bulk actions.
/// </summary>
public record SubscriptionBillingCycleBulkFilters : GraphQLInputObject<SubscriptionBillingCycleBulkFilters>
{
    /// <summary>
    /// Filters the billing cycles based on the presence of billing attempts.
    /// </summary>
    [JsonPropertyName("billingAttemptStatus")]
    public SubscriptionBillingCycleBillingAttemptStatus? billingAttemptStatus { get; set; } = null;

    /// <summary>
    /// Filters the billing cycles based on their status.
    /// </summary>
    [JsonPropertyName("billingCycleStatus")]
    public ICollection<SubscriptionBillingCycleBillingCycleStatus>? billingCycleStatus { get; set; } = null;

    /// <summary>
    /// Filters the billing cycles based on the status of their associated subscription contracts.
    /// </summary>
    [JsonPropertyName("contractStatus")]
    public ICollection<SubscriptionContractSubscriptionStatus>? contractStatus { get; set; } = null;
}