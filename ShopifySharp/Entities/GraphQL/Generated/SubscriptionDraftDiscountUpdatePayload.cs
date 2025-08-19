#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `subscriptionDraftDiscountUpdate` mutation.
/// </summary>
public record SubscriptionDraftDiscountUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated Subscription Discount.
    /// </summary>
    [JsonPropertyName("discountUpdated")]
    public SubscriptionManualDiscount? discountUpdated { get; set; } = null;

    /// <summary>
    /// The Subscription Contract draft object.
    /// </summary>
    [JsonPropertyName("draft")]
    public SubscriptionDraft? draft { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<SubscriptionDraftUserError>? userErrors { get; set; } = null;
}