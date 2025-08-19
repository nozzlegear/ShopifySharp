#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A fulfillment order line item warning. For example, a warning about why a fulfillment request was rejected.
/// </summary>
public record FulfillmentOrderLineItemWarning : IGraphQLObject
{
    /// <summary>
    /// The description of warning.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The title of warning.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}