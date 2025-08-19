#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `discountAutomaticBasicCreate` mutation.
/// </summary>
public record DiscountAutomaticBasicCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The automatic discount that was created.
    /// </summary>
    [JsonPropertyName("automaticDiscountNode")]
    public DiscountAutomaticNode? automaticDiscountNode { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<DiscountUserError>? userErrors { get; set; } = null;
}