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
/// A cash drawer for cash management.
/// </summary>
public record CashDrawer : IGraphQLObject, INode
{
    /// <summary>
    /// The activities on the cash drawer.
    /// </summary>
    [JsonPropertyName("cashActivities")]
    public CashActivityConnection? cashActivities { get; set; } = null;

    /// <summary>
    /// A unique ID for the cash drawer.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The location of the cash drawer.
    /// </summary>
    [JsonPropertyName("location")]
    public Location? location { get; set; } = null;

    /// <summary>
    /// The name of the cash drawer.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The net sales for this cash drawer.
    /// </summary>
    [JsonPropertyName("netSales")]
    public MoneyV2? netSales { get; set; } = null;

    /// <summary>
    /// The Point of Sale devices assigned to this cash drawer.
    /// </summary>
    [JsonPropertyName("pointOfSaleDevices")]
    public PointOfSaleDeviceConnection? pointOfSaleDevices { get; set; } = null;

    /// <summary>
    /// The total adjustments for this cash drawer.
    /// </summary>
    [JsonPropertyName("totalAdjustments")]
    public MoneyV2? totalAdjustments { get; set; } = null;

    /// <summary>
    /// The total discrepancies for this cash drawer.
    /// </summary>
    [JsonPropertyName("totalDiscrepancies")]
    public MoneyV2? totalDiscrepancies { get; set; } = null;

    /// <summary>
    /// The total refunds for this cash drawer.
    /// </summary>
    [JsonPropertyName("totalRefunds")]
    public MoneyV2? totalRefunds { get; set; } = null;

    /// <summary>
    /// The total sales for this cash drawer.
    /// </summary>
    [JsonPropertyName("totalSales")]
    public MoneyV2? totalSales { get; set; } = null;
}