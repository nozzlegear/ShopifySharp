#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `subscriptionBillingCycleContractDraftCommit` mutation.
/// </summary>
public record SubscriptionBillingCycleContractDraftCommitPayload : IGraphQLObject
{
    /// <summary>
    /// The committed Subscription Billing Cycle Edited Contract object.
    /// </summary>
    [JsonPropertyName("contract")]
    public SubscriptionBillingCycleEditedContract? contract { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<SubscriptionDraftUserError>? userErrors { get; set; } = null;
}