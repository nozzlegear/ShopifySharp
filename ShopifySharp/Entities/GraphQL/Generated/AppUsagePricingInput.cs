#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields to issue arbitrary charges for app usage associated with a subscription.
/// </summary>
public record AppUsagePricingInput : GraphQLInputObject<AppUsagePricingInput>
{
    /// <summary>
    /// The maximum amount of usage charges that can be incurred within a subscription billing interval.
    /// </summary>
    [JsonPropertyName("cappedAmount")]
    public MoneyInput? cappedAmount { get; set; } = null;

    /// <summary>
    /// The terms and conditions for app usage. These terms stipulate the pricing model for the charges that an app creates.
    /// </summary>
    [JsonPropertyName("terms")]
    public string? terms { get; set; } = null;
}