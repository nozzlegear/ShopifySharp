#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `quantityRulesDelete` mutation.
/// </summary>
public record QuantityRulesDeletePayload : IGraphQLObject
{
    /// <summary>
    /// A list of product variant IDs whose quantity rules were removed from the price list.
    /// </summary>
    [JsonPropertyName("deletedQuantityRulesVariantIds")]
    public ICollection<string>? deletedQuantityRulesVariantIds { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<QuantityRuleUserError>? userErrors { get; set; } = null;
}