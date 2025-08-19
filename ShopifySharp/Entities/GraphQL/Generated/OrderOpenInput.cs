#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for specifying a closed order to open.
/// </summary>
public record OrderOpenInput : GraphQLInputObject<OrderOpenInput>
{
    /// <summary>
    /// The ID of the order to open.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}