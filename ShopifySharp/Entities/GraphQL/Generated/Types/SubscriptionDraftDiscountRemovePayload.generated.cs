#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `subscriptionDraftDiscountRemove` mutation.
/// </summary>
public record SubscriptionDraftDiscountRemovePayload : IGraphQLObject
{
    /// <summary>
    /// The removed subscription draft discount.
    /// </summary>
    [JsonPropertyName("discountRemoved")]
    public SubscriptionDiscount? discountRemoved { get; set; } = null;

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