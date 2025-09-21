#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The details about a reverse delivery line item.
/// </summary>
public record ReverseDeliveryLineItem : IGraphQLObject, INode
{
    /// <summary>
    /// The dispositions of the item.
    /// </summary>
    [JsonPropertyName("dispositions")]
    public ICollection<ReverseFulfillmentOrderDisposition>? dispositions { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The expected number of units.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The corresponding reverse fulfillment order line item.
    /// </summary>
    [JsonPropertyName("reverseFulfillmentOrderLineItem")]
    public ReverseFulfillmentOrderLineItem? reverseFulfillmentOrderLineItem { get; set; } = null;
}