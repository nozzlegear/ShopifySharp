#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `subscriptionDraftDiscountCodeApply` mutation.
/// </summary>
public record SubscriptionDraftDiscountCodeApplyPayload : IGraphQLObject
{
    /// <summary>
    /// The added subscription discount.
    /// </summary>
    [JsonPropertyName("appliedDiscount")]
    public SubscriptionAppliedCodeDiscount? appliedDiscount { get; set; } = null;

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