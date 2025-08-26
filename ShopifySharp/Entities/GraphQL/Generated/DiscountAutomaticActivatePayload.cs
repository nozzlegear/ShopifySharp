#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
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