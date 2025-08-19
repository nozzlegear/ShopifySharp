#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a return line item.
/// </summary>
public record SuggestedOutcomeReturnLineItemInput : GraphQLInputObject<SuggestedOutcomeReturnLineItemInput>
{
    /// <summary>
    /// The ID of the return line item.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The quantity of the return line item.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;
}