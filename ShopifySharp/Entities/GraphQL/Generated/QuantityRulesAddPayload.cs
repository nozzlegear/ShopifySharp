#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `quantityRulesAdd` mutation.
/// </summary>
public record QuantityRulesAddPayload : IGraphQLObject
{
    /// <summary>
    /// The list of quantity rules that were added to or updated in the price list.
    /// </summary>
    [JsonPropertyName("quantityRules")]
    public ICollection<QuantityRule>? quantityRules { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<QuantityRuleUserError>? userErrors { get; set; } = null;
}