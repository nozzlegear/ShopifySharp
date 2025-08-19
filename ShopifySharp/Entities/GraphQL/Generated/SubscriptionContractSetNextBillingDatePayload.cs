#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `subscriptionContractSetNextBillingDate` mutation.
/// </summary>
public record SubscriptionContractSetNextBillingDatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated Subscription Contract object.
    /// </summary>
    [JsonPropertyName("contract")]
    public SubscriptionContract? contract { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<SubscriptionContractUserError>? userErrors { get; set; } = null;
}