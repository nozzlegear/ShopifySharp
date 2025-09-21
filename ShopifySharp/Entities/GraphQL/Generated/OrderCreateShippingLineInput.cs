#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a shipping line to create for an order.
/// </summary>
public record OrderCreateShippingLineInput : GraphQLInputObject<OrderCreateShippingLineInput>
{
    /// <summary>
    /// A reference to the shipping method.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;

    /// <summary>
    /// The price of this shipping method in the shop currency. Can't be negative.
    /// </summary>
    [JsonPropertyName("priceSet")]
    public MoneyBagInput? priceSet { get; set; } = null;

    /// <summary>
    /// The source of the shipping method.
    /// </summary>
    [JsonPropertyName("source")]
    public string? source { get; set; } = null;

    /// <summary>
    /// A list of tax line objects, each of which details a tax applicable to this shipping line.
    /// </summary>
    [JsonPropertyName("taxLines")]
    public ICollection<OrderCreateTaxLineInput>? taxLines { get; set; } = null;

    /// <summary>
    /// The title of the shipping method.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}