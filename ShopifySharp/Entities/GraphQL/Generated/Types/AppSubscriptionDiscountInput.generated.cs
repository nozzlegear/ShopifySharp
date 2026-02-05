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
/// The input fields to specify a discount to the recurring pricing portion of a
/// subscription over a number of billing intervals.
/// </summary>
public record AppSubscriptionDiscountInput : GraphQLInputObject<AppSubscriptionDiscountInput>
{
    /// <summary>
    /// The total number of billing intervals to which the discount will be applied. Must be greater than 0.
    /// The discount will be applied to an indefinite number of billing intervals if this value is left blank.
    /// </summary>
    [JsonPropertyName("durationLimitInIntervals")]
    public int? durationLimitInIntervals { get; set; } = null;

    /// <summary>
    /// The value to be discounted every billing interval.
    /// </summary>
    [JsonPropertyName("value")]
    public AppSubscriptionDiscountValueInput? @value { get; set; } = null;
}