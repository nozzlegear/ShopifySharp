#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a Subscription Line Pricing Policy.
/// </summary>
public record SubscriptionPricingPolicy : IGraphQLObject
{
    /// <summary>
    /// The base price per unit for the subscription line in the contract's currency.
    /// </summary>
    [JsonPropertyName("basePrice")]
    public MoneyV2? basePrice { get; set; } = null;

    /// <summary>
    /// The adjustments per cycle for the subscription line.
    /// </summary>
    [JsonPropertyName("cycleDiscounts")]
    public ICollection<SubscriptionCyclePriceAdjustment>? cycleDiscounts { get; set; } = null;
}