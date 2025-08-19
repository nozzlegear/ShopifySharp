#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `subscriptionDraftLineUpdate` mutation.
/// </summary>
public record SubscriptionDraftLineUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The Subscription Contract draft object.
    /// </summary>
    [JsonPropertyName("draft")]
    public SubscriptionDraft? draft { get; set; } = null;

    /// <summary>
    /// The updated Subscription Line.
    /// </summary>
    [JsonPropertyName("lineUpdated")]
    public SubscriptionLine? lineUpdated { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<SubscriptionDraftUserError>? userErrors { get; set; } = null;
}