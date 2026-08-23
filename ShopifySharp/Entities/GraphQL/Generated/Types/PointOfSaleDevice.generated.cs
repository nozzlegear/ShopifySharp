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
/// Represents a mobile device that Shopify Point of Sale has been installed on.
/// </summary>
public record PointOfSaleDevice : IGraphQLObject, INode
{
    /// <summary>
    /// The currently open payment session for this device. Data is returned only if
    /// the device's location has a POS Pro subscription.
    /// </summary>
    [JsonPropertyName("activePaymentSession")]
    public PointOfSaleDevicePaymentSession? activePaymentSession { get; set; } = null;

    /// <summary>
    /// The cash drawer that this device is currently assigned to. Data is returned
    /// only if the device's location has a POS Pro subscription.
    /// </summary>
    [JsonPropertyName("cashDrawer")]
    public CashDrawer? cashDrawer { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}