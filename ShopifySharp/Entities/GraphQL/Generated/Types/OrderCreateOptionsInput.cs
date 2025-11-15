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
/// The input fields that define the strategies for updating inventory and
/// whether to send shipping and order confirmations to customers.
/// </summary>
public record OrderCreateOptionsInput : GraphQLInputObject<OrderCreateOptionsInput>
{
    /// <summary>
    /// The strategy for handling updates to inventory: not claiming inventory, ignoring inventory policies,
    /// or following policies when claiming inventory.
    /// </summary>
    [JsonPropertyName("inventoryBehaviour")]
    public OrderCreateInputsInventoryBehavior? inventoryBehaviour { get; set; } = null;

    /// <summary>
    /// Whether to send a shipping confirmation to the customer.
    /// </summary>
    [JsonPropertyName("sendFulfillmentReceipt")]
    public bool? sendFulfillmentReceipt { get; set; } = null;

    /// <summary>
    /// Whether to send an order confirmation to the customer.
    /// </summary>
    [JsonPropertyName("sendReceipt")]
    public bool? sendReceipt { get; set; } = null;
}