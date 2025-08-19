#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a note attribute for an order.
/// </summary>
public record OrderCreateCustomAttributeInput : GraphQLInputObject<OrderCreateCustomAttributeInput>
{
    /// <summary>
    /// The key or name of the custom attribute.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The value of the custom attribute.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}