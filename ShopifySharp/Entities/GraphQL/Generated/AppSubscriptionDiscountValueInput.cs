#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields to specify the value discounted every billing interval.
/// </summary>
public record AppSubscriptionDiscountValueInput : GraphQLInputObject<AppSubscriptionDiscountValueInput>
{
    /// <summary>
    /// The monetary value of a discount.
    /// </summary>
    [JsonPropertyName("amount")]
    public decimal? amount { get; set; } = null;

    /// <summary>
    /// The percentage value of a discount.
    /// </summary>
    [JsonPropertyName("percentage")]
    public decimal? percentage { get; set; } = null;
}