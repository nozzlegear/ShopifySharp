#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for specifying the order to mark as paid.
/// </summary>
public record OrderMarkAsPaidInput : GraphQLInputObject<OrderMarkAsPaidInput>
{
    /// <summary>
    /// The ID of the order to mark as paid.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}