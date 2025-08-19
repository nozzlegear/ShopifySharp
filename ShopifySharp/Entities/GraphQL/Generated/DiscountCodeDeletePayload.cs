#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `discountCodeDelete` mutation.
/// </summary>
public record DiscountCodeDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the code discount that was deleted.
    /// </summary>
    [JsonPropertyName("deletedCodeDiscountId")]
    public string? deletedCodeDiscountId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<DiscountUserError>? userErrors { get; set; } = null;
}