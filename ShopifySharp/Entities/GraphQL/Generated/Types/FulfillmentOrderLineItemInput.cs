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
/// The input fields used to include the quantity of the fulfillment order line item that should be fulfilled.
/// </summary>
public record FulfillmentOrderLineItemInput : GraphQLInputObject<FulfillmentOrderLineItemInput>
{
    /// <summary>
    /// The ID of the fulfillment order line item.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The quantity of the fulfillment order line item.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;
}