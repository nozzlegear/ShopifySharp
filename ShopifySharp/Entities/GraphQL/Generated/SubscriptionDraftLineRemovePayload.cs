#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `subscriptionDraftLineRemove` mutation.
/// </summary>
public record SubscriptionDraftLineRemovePayload : IGraphQLObject
{
    /// <summary>
    /// The list of updated subscription discounts impacted by the removed line.
    /// </summary>
    [JsonPropertyName("discountsUpdated")]
    public ICollection<SubscriptionManualDiscount>? discountsUpdated { get; set; } = null;

    /// <summary>
    /// The Subscription Contract draft object.
    /// </summary>
    [JsonPropertyName("draft")]
    public SubscriptionDraft? draft { get; set; } = null;

    /// <summary>
    /// The removed Subscription Line.
    /// </summary>
    [JsonPropertyName("lineRemoved")]
    public SubscriptionLine? lineRemoved { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<SubscriptionDraftUserError>? userErrors { get; set; } = null;
}