#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record DiscountEffectDiscountAmount(DiscountAmount Value): DiscountEffect;
internal record DiscountEffectDiscountPercentage(DiscountPercentage Value): DiscountEffect;
#endif /// <summary>

/// The input fields for how the discount will be applied. Currently, only percentage off is supported.
/// </summary>
public record DiscountEffectInput : GraphQLInputObject<DiscountEffectInput>
{
    /// <summary>
    /// The value of the discount.
    /// </summary>
    [JsonPropertyName("amount")]
    public decimal? amount { get; set; } = null;

    /// <summary>
    /// The percentage value of the discount. Value must be between 0.00 - 1.00.
    /// </summary>
    [JsonPropertyName("percentage")]
    public decimal? percentage { get; set; } = null;
}