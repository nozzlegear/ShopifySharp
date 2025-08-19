#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a line item property for an order.
/// </summary>
public record OrderCreateLineItemPropertyInput : GraphQLInputObject<OrderCreateLineItemPropertyInput>
{
    /// <summary>
    /// The name of the line item property.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The value of the line item property.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}