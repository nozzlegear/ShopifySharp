#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a subscription discount on a contract.
/// </summary>
public record SubscriptionManualDiscountInput : GraphQLInputObject<SubscriptionManualDiscountInput>
{
    /// <summary>
    /// Entitled line items used to apply the subscription discount on.
    /// </summary>
    [JsonPropertyName("entitledLines")]
    public SubscriptionManualDiscountEntitledLinesInput? entitledLines { get; set; } = null;

    /// <summary>
    /// The maximum number of times the subscription discount will be applied on orders.
    /// </summary>
    [JsonPropertyName("recurringCycleLimit")]
    public int? recurringCycleLimit { get; set; } = null;

    /// <summary>
    /// The title associated with the subscription discount.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// Percentage or fixed amount value of the discount.
    /// </summary>
    [JsonPropertyName("value")]
    public SubscriptionManualDiscountValueInput? @value { get; set; } = null;
}