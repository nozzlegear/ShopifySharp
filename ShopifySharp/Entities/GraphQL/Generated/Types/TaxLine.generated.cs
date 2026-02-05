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
/// A tax applied to a
/// [`LineItem`](https://shopify.dev/docs/api/admin-graphql/latest/objects/LineItem) or [`ShippingLine`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ShippingLine).
/// Includes the tax amount, rate, title, and whether the channel that submitted the
/// tax is liable for remitting it.
/// The tax amount in both shop and presentment currencies after applying discounts.
/// Includes information about the tax rate, whether the channel is liable for
/// remitting the tax, and other tax-related details.
/// </summary>
public record TaxLine : IGraphQLObject
{
    /// <summary>
    /// Whether the channel that submitted the tax line is liable for remitting. A
    /// value of null indicates unknown liability for this tax line.
    /// </summary>
    [JsonPropertyName("channelLiable")]
    public bool? channelLiable { get; set; } = null;

    /// <summary>
    /// The amount of tax, in shop currency, after discounts and before returns.
    /// </summary>
    [JsonPropertyName("price")]
    [Obsolete("Use `priceSet` instead.")]
    public decimal? price { get; set; } = null;

    /// <summary>
    /// The amount of tax, in shop and presentment currencies, after discounts and before returns.
    /// </summary>
    [JsonPropertyName("priceSet")]
    public MoneyBag? priceSet { get; set; } = null;

    /// <summary>
    /// The proportion of the line item price that the tax represents as a decimal.
    /// </summary>
    [JsonPropertyName("rate")]
    public decimal? rate { get; set; } = null;

    /// <summary>
    /// The proportion of the line item price that the tax represents as a percentage.
    /// </summary>
    [JsonPropertyName("ratePercentage")]
    public decimal? ratePercentage { get; set; } = null;

    /// <summary>
    /// The source of the tax.
    /// </summary>
    [JsonPropertyName("source")]
    public string? source { get; set; } = null;

    /// <summary>
    /// The name of the tax.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}