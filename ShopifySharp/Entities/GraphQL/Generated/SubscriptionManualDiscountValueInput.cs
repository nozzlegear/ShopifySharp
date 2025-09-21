#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for the discount value and its distribution.
/// </summary>
public record SubscriptionManualDiscountValueInput : GraphQLInputObject<SubscriptionManualDiscountValueInput>
{
    /// <summary>
    /// Fixed amount input in the currency defined by the subscription.
    /// </summary>
    [JsonPropertyName("fixedAmount")]
    public SubscriptionManualDiscountFixedAmountInput? fixedAmount { get; set; } = null;

    /// <summary>
    /// The percentage value of the discount. Value must be between 0 - 100.
    /// </summary>
    [JsonPropertyName("percentage")]
    public int? percentage { get; set; } = null;
}