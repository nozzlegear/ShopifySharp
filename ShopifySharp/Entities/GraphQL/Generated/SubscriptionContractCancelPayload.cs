#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `subscriptionContractCancel` mutation.
/// </summary>
public record SubscriptionContractCancelPayload : IGraphQLObject
{
    /// <summary>
    /// The new Subscription Contract object.
    /// </summary>
    [JsonPropertyName("contract")]
    public SubscriptionContract? contract { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<SubscriptionContractStatusUpdateUserError>? userErrors { get; set; } = null;
}