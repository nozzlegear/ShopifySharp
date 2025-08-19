#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for expected price changes of the subscription line over time.
/// </summary>
public record SubscriptionPricingPolicyInput : GraphQLInputObject<SubscriptionPricingPolicyInput>
{
    /// <summary>
    /// The base price per unit for the subscription line in the contract's currency.
    /// </summary>
    [JsonPropertyName("basePrice")]
    public decimal? basePrice { get; set; } = null;

    /// <summary>
    /// An array containing all pricing changes for each billing cycle.
    /// </summary>
    [JsonPropertyName("cycleDiscounts")]
    public ICollection<SubscriptionPricingPolicyCycleDiscountsInput>? cycleDiscounts { get; set; } = null;
}