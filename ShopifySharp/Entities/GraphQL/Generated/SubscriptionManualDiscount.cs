#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Custom subscription discount.
/// </summary>
public record SubscriptionManualDiscount : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// Entitled line items used to apply the subscription discount on.
    /// </summary>
    [JsonPropertyName("entitledLines")]
    public SubscriptionDiscountEntitledLines? entitledLines { get; set; } = null;

    /// <summary>
    /// The unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The maximum number of times the subscription discount will be applied on orders.
    /// </summary>
    [JsonPropertyName("recurringCycleLimit")]
    public int? recurringCycleLimit { get; set; } = null;

    /// <summary>
    /// The reason that the discount on the subscription draft is rejected.
    /// </summary>
    [JsonPropertyName("rejectionReason")]
    public SubscriptionDiscountRejectionReason? rejectionReason { get; set; } = null;

    /// <summary>
    /// Type of line the discount applies on.
    /// </summary>
    [JsonPropertyName("targetType")]
    public DiscountTargetType? targetType { get; set; } = null;

    /// <summary>
    /// The title associated with the subscription discount.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The type of the subscription discount.
    /// </summary>
    [JsonPropertyName("type")]
    public DiscountType? type { get; set; } = null;

    /// <summary>
    /// The number of times the discount was applied.
    /// </summary>
    [JsonPropertyName("usageCount")]
    public int? usageCount { get; set; } = null;

    /// <summary>
    /// The value of the subscription discount.
    /// </summary>
    [JsonPropertyName("value")]
    public SubscriptionDiscountValue? @value { get; set; } = null;
}