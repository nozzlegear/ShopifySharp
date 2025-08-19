#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The order associated to the balance transaction.
/// </summary>
public record ShopifyPaymentsAssociatedOrder : IGraphQLObject
{
    /// <summary>
    /// The ID of the associated order.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The name of the associated order.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}