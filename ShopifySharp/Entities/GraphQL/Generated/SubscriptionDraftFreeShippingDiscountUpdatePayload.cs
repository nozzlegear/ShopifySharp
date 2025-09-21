#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `subscriptionDraftFreeShippingDiscountUpdate` mutation.
/// </summary>
public record SubscriptionDraftFreeShippingDiscountUpdatePayload : IGraphQLObject
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