#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The details about a reverse fulfillment order line item.
/// </summary>
public record ReverseFulfillmentOrderLineItem : IGraphQLObject, INode
{
    /// <summary>
    /// The dispositions of the item.
    /// </summary>
    [JsonPropertyName("dispositions")]
    public ICollection<ReverseFulfillmentOrderDisposition>? dispositions { get; set; } = null;

    /// <summary>
    /// The corresponding fulfillment line item for a reverse fulfillment order line item.
    /// </summary>
    [JsonPropertyName("fulfillmentLineItem")]
    public FulfillmentLineItem? fulfillmentLineItem { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The total number of units to be processed.
    /// </summary>
    [JsonPropertyName("totalQuantity")]
    public int? totalQuantity { get; set; } = null;
}