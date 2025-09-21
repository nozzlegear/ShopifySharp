#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents an applied code discount.
/// </summary>
public record SubscriptionAppliedCodeDiscount : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The redeem code of the discount that applies on the subscription.
    /// </summary>
    [JsonPropertyName("redeemCode")]
    public string? redeemCode { get; set; } = null;

    /// <summary>
    /// The reason that the discount on the subscription draft is rejected.
    /// </summary>
    [JsonPropertyName("rejectionReason")]
    public SubscriptionDiscountRejectionReason? rejectionReason { get; set; } = null;
}