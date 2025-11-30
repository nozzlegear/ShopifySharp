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
/// Represents a line item for a Shop Pay payment request.
/// </summary>
public record ShopPayPaymentRequestLineItem : IGraphQLObject
{
    /// <summary>
    /// The final item price for the line item.
    /// </summary>
    [JsonPropertyName("finalItemPrice")]
    public MoneyV2? finalItemPrice { get; set; } = null;

    /// <summary>
    /// The final line price for the line item.
    /// </summary>
    [JsonPropertyName("finalLinePrice")]
    public MoneyV2? finalLinePrice { get; set; } = null;

    /// <summary>
    /// The image of the line item.
    /// </summary>
    [JsonPropertyName("image")]
    public ShopPayPaymentRequestImage? image { get; set; } = null;

    /// <summary>
    /// The item discounts for the line item.
    /// </summary>
    [JsonPropertyName("itemDiscounts")]
    public ICollection<ShopPayPaymentRequestDiscount>? itemDiscounts { get; set; } = null;

    /// <summary>
    /// The label of the line item.
    /// </summary>
    [JsonPropertyName("label")]
    public string? label { get; set; } = null;

    /// <summary>
    /// The line discounts for the line item.
    /// </summary>
    [JsonPropertyName("lineDiscounts")]
    public ICollection<ShopPayPaymentRequestDiscount>? lineDiscounts { get; set; } = null;

    /// <summary>
    /// The original item price for the line item.
    /// </summary>
    [JsonPropertyName("originalItemPrice")]
    public MoneyV2? originalItemPrice { get; set; } = null;

    /// <summary>
    /// The original line price for the line item.
    /// </summary>
    [JsonPropertyName("originalLinePrice")]
    public MoneyV2? originalLinePrice { get; set; } = null;

    /// <summary>
    /// The quantity of the line item.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// Whether the line item requires shipping.
    /// </summary>
    [JsonPropertyName("requiresShipping")]
    public bool? requiresShipping { get; set; } = null;

    /// <summary>
    /// The SKU of the line item.
    /// </summary>
    [JsonPropertyName("sku")]
    public string? sku { get; set; } = null;
}