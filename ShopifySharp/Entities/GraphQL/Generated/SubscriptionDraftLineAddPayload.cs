#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `subscriptionDraftLineAdd` mutation.
/// </summary>
public record SubscriptionDraftLineAddPayload : IGraphQLObject
{
    /// <summary>
    /// The Subscription Contract draft object.
    /// </summary>
    [JsonPropertyName("draft")]
    public SubscriptionDraft? draft { get; set; } = null;

    /// <summary>
    /// The added Subscription Line.
    /// </summary>
    [JsonPropertyName("lineAdded")]
    public SubscriptionLine? lineAdded { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<SubscriptionDraftUserError>? userErrors { get; set; } = null;
}