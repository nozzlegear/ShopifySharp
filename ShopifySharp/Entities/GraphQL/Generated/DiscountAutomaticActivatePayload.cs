#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record DiscountAutomaticDiscountAutomaticApp(DiscountAutomaticApp Value): DiscountAutomatic;
internal record DiscountAutomaticDiscountAutomaticBasic(DiscountAutomaticBasic Value): DiscountAutomatic;
internal record DiscountAutomaticDiscountAutomaticBxgy(DiscountAutomaticBxgy Value): DiscountAutomatic;
internal record DiscountAutomaticDiscountAutomaticFreeShipping(DiscountAutomaticFreeShipping Value): DiscountAutomatic;
#endif /// <summary>

/// Return type for `discountAutomaticActivate` mutation.
/// </summary>
public record DiscountAutomaticActivatePayload : IGraphQLObject
{
    /// <summary>
    /// The activated automatic discount.
    /// </summary>
    [JsonPropertyName("automaticDiscountNode")]
    public DiscountAutomaticNode? automaticDiscountNode { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<DiscountUserError>? userErrors { get; set; } = null;
}