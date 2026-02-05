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
/// A calculated return line item.
/// </summary>
public record CalculatedReturnLineItem : IGraphQLObject
{
    /// <summary>
    /// The fulfillment line item from which items are returned.
    /// </summary>
    [JsonPropertyName("fulfillmentLineItem")]
    public FulfillmentLineItem? fulfillmentLineItem { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The quantity being returned.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The restocking fee of the return line item.
    /// </summary>
    [JsonPropertyName("restockingFee")]
    public CalculatedRestockingFee? restockingFee { get; set; } = null;

    /// <summary>
    /// The subtotal of the return line item before order discounts.
    /// </summary>
    [JsonPropertyName("subtotalBeforeOrderDiscountsSet")]
    public MoneyBag? subtotalBeforeOrderDiscountsSet { get; set; } = null;

    /// <summary>
    /// The subtotal of the return line item.
    /// </summary>
    [JsonPropertyName("subtotalSet")]
    public MoneyBag? subtotalSet { get; set; } = null;

    /// <summary>
    /// The total tax of the return line item.
    /// </summary>
    [JsonPropertyName("totalTaxSet")]
    public MoneyBag? totalTaxSet { get; set; } = null;
}