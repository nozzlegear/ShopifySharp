#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `discountCodeActivate` mutation.
/// </summary>
public record DiscountCodeActivatePayload : IGraphQLObject
{
    /// <summary>
    /// The activated code discount.
    /// </summary>
    [JsonPropertyName("codeDiscountNode")]
    public DiscountCodeNode? codeDiscountNode { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<DiscountUserError>? userErrors { get; set; } = null;
}