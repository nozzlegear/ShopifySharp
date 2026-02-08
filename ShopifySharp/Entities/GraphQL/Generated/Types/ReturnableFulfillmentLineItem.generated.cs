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
/// A returnable fulfillment line item.
/// </summary>
public record ReturnableFulfillmentLineItem : IGraphQLObject
{
    /// <summary>
    /// The fulfillment line item that can be returned.
    /// </summary>
    [JsonPropertyName("fulfillmentLineItem")]
    public FulfillmentLineItem? fulfillmentLineItem { get; set; } = null;

    /// <summary>
    /// The quantity available to be returned.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;
}