#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `subscriptionDraftFreeShippingDiscountAdd` mutation.
/// </summary>
public record SubscriptionDraftFreeShippingDiscountAddPayload : IGraphQLObject
{
    /// <summary>
    /// The added subscription free shipping discount.
    /// </summary>
    [JsonPropertyName("discountAdded")]
    public SubscriptionManualDiscount? discountAdded { get; set; } = null;

    /// <summary>
    /// The subscription contract draft object.
    /// </summary>
    [JsonPropertyName("draft")]
    public SubscriptionDraft? draft { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<SubscriptionDraftUserError>? userErrors { get; set; } = null;
}