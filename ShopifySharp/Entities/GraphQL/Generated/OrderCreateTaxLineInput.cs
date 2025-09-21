#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a tax line to create for an order.
/// </summary>
public record OrderCreateTaxLineInput : GraphQLInputObject<OrderCreateTaxLineInput>
{
    /// <summary>
    /// Whether the channel that submitted the tax line is liable for remitting. A
    /// value of `null` indicates unknown liability for the tax line.
    /// </summary>
    [JsonPropertyName("channelLiable")]
    public bool? channelLiable { get; set; } = null;

    /// <summary>
    /// The amount of tax to be charged on the item.
    /// </summary>
    [JsonPropertyName("priceSet")]
    public MoneyBagInput? priceSet { get; set; } = null;

    /// <summary>
    /// The proportion of the item price that the tax represents as a decimal.
    /// </summary>
    [JsonPropertyName("rate")]
    public decimal? rate { get; set; } = null;

    /// <summary>
    /// The name of the tax line to create.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}