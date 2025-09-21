#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for an exchange line item.
/// </summary>
public record SuggestedOutcomeExchangeLineItemInput : GraphQLInputObject<SuggestedOutcomeExchangeLineItemInput>
{
    /// <summary>
    /// The ID of the exchange line item.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The quantity of the exchange line item.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;
}