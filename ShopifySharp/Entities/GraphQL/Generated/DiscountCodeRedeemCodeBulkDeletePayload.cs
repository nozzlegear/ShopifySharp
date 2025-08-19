#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `discountCodeRedeemCodeBulkDelete` mutation.
/// </summary>
public record DiscountCodeRedeemCodeBulkDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The asynchronous job that deletes the discount codes.
    /// </summary>
    [JsonPropertyName("job")]
    public Job? job { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<DiscountUserError>? userErrors { get; set; } = null;
}